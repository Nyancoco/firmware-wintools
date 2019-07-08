﻿namespace firmware_wintools.Tools
{
	partial class ToolsArgMap
	{
		public void Init_args_Xorimage(string[] args, ref Tools.XorImage.Properties props)
		{
			for (int i = 0; i < args.Length; i++)
			{
				string param = args[i];

				if (param.StartsWith("-"))
				{
					switch (param.Replace("-", ""))
					{
						case "p":
							if (ArgMap.Set_StrParamFromArgs(args, i, ref props.pattern) == 0)
								i++;
							break;
						case "x":
							props.ishex = true;
							break;
					}
				}
			}
		}
	}
}
