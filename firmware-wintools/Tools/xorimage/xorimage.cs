﻿using System;
using System.IO;
using System.Text;

namespace firmware_wintools.Tools
{
	class XorImage
	{
		/// <summary>
		/// xorimageの機能プロパティ
		/// </summary>
		public struct Properties
		{
			/// <summary>
			/// xorに用いるpattern
			/// </summary>
			public string pattern;
			/// <summary>
			/// 指定されたパターンがhex値であるか否か
			/// </summary>
			public bool ishex;
		}

		/// <summary>
		/// xorimageの機能ヘルプを表示します
		/// </summary>
		private void PrintHelp()
		{
			Console.WriteLine("Usage: firmware-wintools xorimage [OPTIONS...]\n" +
				Environment.NewLine +
				"Options:\n" +
				"  -i <file>\tinput file\n" +
				"  -o <file>\toutput file\n" +
				"  -p <pattern>\tuse <pattern> for encode/decode the firmware by xor\n" +
				"  -x\t\tuse \"hex pattern\" mode\n");
		}

		/// <summary>
		/// xorimageの実行情報を表示します
		/// </summary>
		/// <param name="props"></param>
		private void PrintInfo(Properties props)
		{
			Console.WriteLine("===== xorimage mode =====");
			Console.WriteLine(" pattern:\t{0}\n", props.pattern);
			Console.WriteLine(" hex mode:\t{0}\n", props.ishex.ToString());
		}

		/// <summary>
		/// 指定された <paramref name="props"/> 内のpatternを用いて、<paramref name="data"/>
		/// のxorを行います
		/// </summary>
		/// <param name="data">xor対象データ</param>
		/// <param name="len">xor対象データの長さ</param>
		/// <param name="props">xorimageの機能プロパティ</param>
		/// <param name="p_len">パターン長</param>
		/// <param name="p_off">パターン オフセット</param>
		/// <returns></returns>
		private int XorData(ref byte[] data, int len, Properties props, int p_len, int p_off)
		{
			int data_pos = 0;
			int offset = p_off;
			byte[] byteKey = new byte[(props.ishex) ? p_len/2 : p_len];

			if (props.ishex)
				for (int i = 0; i < (p_len / 2); i++)
				{
					byteKey[i] = Convert.ToByte(props.pattern.Substring(i * 2, 2), 16);
				}
			else
				byteKey = Encoding.UTF8.GetBytes(props.pattern);

			while (len-- > 0)
			{
				data[data_pos] ^= byteKey[offset];
				data_pos++;
				offset = (offset + 1) % ((props.ishex) ? p_len / 2 : p_len);
			}

			return offset;
		}

		/// <summary>
		/// xorimageメイン関数
		/// <para>コマンドライン引数とメインプロパティから、xorによりファームウェアの
		/// エンコード/デコード を行います</para>
		/// </summary>
		/// <param name="args">コマンドライン引数</param>
		/// <param name="props">Program内のメインプロパティ</param>
		/// <returns></returns>
		public int Do_Xor(string[] args, Program.Properties props)
		{
			int read_len, p_off = 0;
			byte[] hex_pattern = new byte[128];
			byte[] buf = new byte[4096];
			Properties subprops = new Properties();

			subprops.pattern = "12345678";

			ToolsArgMap argMap = new ToolsArgMap();
			argMap.Init_args_Xorimage(args, ref subprops);

			if (props.help)
			{
				PrintHelp();
				return 0;
			}

			int p_len = subprops.pattern.Length;
			if (p_len == 0)
			{
				Console.Error.WriteLine("error: incorrect pattern length (must be > 0");
				return 1;
			}

			PrintInfo(subprops);

			if (subprops.ishex)
			{
				if ((p_len / 2) > hex_pattern.Length)
				{
					Console.Error.WriteLine("error: provided hex pattern is too long");
					return 1;
				}

				if (p_len % 2 != 0)
				{
					Console.Error.WriteLine("error: the numbers of charactors (hex) is incorrect");
					return 1;
				}
			}

			if (!File.Exists(props.inFile))
			{
				Console.WriteLine("cannot open input file (not found)");
				return 1;
			}

			FileStream inFs;
			FileStream outFs;
			FileMode outFMode =
				File.Exists(props.outFile) ? FileMode.Truncate : FileMode.Create;
			try
			{
				inFs = new FileStream(props.inFile, FileMode.Open, FileAccess.Read, FileShare.Read);
				outFs = new FileStream(props.outFile, outFMode, FileAccess.Write, FileShare.None);
			} catch (IOException i)
			{
				Console.Error.WriteLine(i.Message);
				return 1;
			}

			while ((read_len = inFs.Read(buf, 0, buf.Length)) > 0)
			{
				p_off = XorData(ref buf, read_len, subprops, p_len, p_off);

				outFs.Write(buf, 0, read_len);
			}

			inFs.Close();
			outFs.Close();

			return 0;
		}
	}
}
