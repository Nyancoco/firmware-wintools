﻿namespace firmware_wintools.Tools
{
	partial class Buffalo_Lib
	{
		public const int ENC_PRODUCT_LEN = 32;
		/// <summary>
		/// versionの長さ
		/// <para>文字列7文字 + NULL文字1文字 = 長さ8</para>
		/// </summary>
		public const int ENC_VERSION_LEN = 8;
		/// <summary>
		/// magicの長さ
		/// <para>文字列5文字 + NULL文字1文字 = 長さ6</para>
		/// </summary>
		public const int ENC_MAGIC_LEN = 6;

		public struct Enc_Param
		{
			public byte[] key;
			public byte[] magic;
			public byte[] product;
			public byte[] version;
			public byte seed;
			public bool longstate;
			public int datalen;
			public uint cksum;
		}

		public const int BCRYPT_DEFAULT_STATE_LEN = 256;
		public const int BCRYPT_MAX_KEYLEN = 254;

		public struct Bcrypt_ctx
		{
			public ulong i;
			public ulong j;
			public byte[] buf;
			public long buf_len;
		}
	}
}
