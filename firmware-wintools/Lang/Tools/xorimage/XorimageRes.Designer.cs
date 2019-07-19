﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace firmware_wintools.Lang.Tools {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class XorimageRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal XorimageRes() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("firmware_wintools.Lang.Tools.xorimage.XorimageRes", typeof(XorimageRes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   the numbers of charactors (hex) is incorrect に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Error_InvalidHexPatternLen {
            get {
                return ResourceManager.GetString("Error.InvalidHexPatternLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   incorrect pattern length (must be &gt; 0) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Error_InvalidPatternLen {
            get {
                return ResourceManager.GetString("Error.InvalidPatternLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   provided hex pattern is too long に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Error_LongHexPattern {
            get {
                return ResourceManager.GetString("Error.LongHexPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   encode/decode firmware by xor with a pattern に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FuncDesc {
            get {
                return ResourceManager.GetString("FuncDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Options:
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Help_Options {
            get {
                return ResourceManager.GetString("Help.Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///     -x			use &quot;hex pattern&quot; mode
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Help_Options_Hex {
            get {
                return ResourceManager.GetString("Help.Options.Hex", resourceCulture);
            }
        }
        
        /// <summary>
        ///     -p &lt;pattern&gt;		use &lt;pattern&gt; for encode/decode the firmware by xor
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Help_Options_Pattern {
            get {
                return ResourceManager.GetString("Help.Options.Pattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Usage: firmware-wintools xorimage [OPTIONS...]
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Help_Usage {
            get {
                return ResourceManager.GetString("Help.Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ===== xorimage mode ===== に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Info {
            get {
                return ResourceManager.GetString("Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///    hex mode	: {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Info_Hex {
            get {
                return ResourceManager.GetString("Info.Hex", resourceCulture);
            }
        }
        
        /// <summary>
        ///    pattern	: {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Info_Pattern {
            get {
                return ResourceManager.GetString("Info.Pattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///       {0}		: {1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Main_FuncDesc_Fmt {
            get {
                return ResourceManager.GetString("Main.FuncDesc.Fmt", resourceCulture);
            }
        }
    }
}