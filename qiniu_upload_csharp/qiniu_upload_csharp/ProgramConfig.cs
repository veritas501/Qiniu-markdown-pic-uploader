using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static qiniu_upload_csharp.HotKey;

namespace qiniu_upload_csharp
{
	class ProgramConfig
	{
		public class QiniuInfoStruc
		{
			public string AK;
			public string SK;
			public string BucketName;
			public string FolderName;
		}

		public class HotKeyStruct
		{
			public Keys KeyCode;
			public uint ControlKey1;
			public uint ControlKey2;
		}

		public class OutConfigStruct
		{
			public QiniuInfoStruc UPStruct;
			public HotKeyStruct HKStruct;
			public bool TopMost;
			public bool MarkdownMode;
		}

		public static string TmpImagePath;
		public static string ConfigPath;
		public static string BucketUrl;

		public static OutConfigStruct OutConfig;

		public ProgramConfig()
		{

			OutConfig = new OutConfigStruct
			{
				UPStruct = new QiniuInfoStruc(),
				HKStruct = new HotKeyStruct()
			};
			TmpImagePath = System.Environment.CurrentDirectory + @"\Clipboard_image.png";
			ConfigPath = System.Environment.CurrentDirectory + @"\qiniu.config";
			BucketUrl = "";
		}

		public void InitInfoFromFile()
		{
			if (File.Exists(ConfigPath))
			{
				try
				{
					JavaScriptSerializer js = new JavaScriptSerializer();
					dynamic modelDy = js.Deserialize<dynamic>(File.ReadAllText(ConfigPath));
					OutConfig.TopMost = modelDy["TopMost"];
					OutConfig.MarkdownMode = modelDy["MarkdownMode"];
					OutConfig.UPStruct.AK = modelDy["UPStruct"]["AK"];
					OutConfig.UPStruct.SK = modelDy["UPStruct"]["SK"];
					OutConfig.UPStruct.BucketName = modelDy["UPStruct"]["BucketName"];
					OutConfig.UPStruct.FolderName = modelDy["UPStruct"]["FolderName"];
					OutConfig.HKStruct.KeyCode = (Keys)modelDy["HKStruct"]["KeyCode"];
					OutConfig.HKStruct.ControlKey1 = (uint)modelDy["HKStruct"]["ControlKey1"];
					OutConfig.HKStruct.ControlKey2 = (uint)modelDy["HKStruct"]["ControlKey2"];
				}
				catch (Exception)
				{
					OutConfig.TopMost = false;
					OutConfig.MarkdownMode = true;
					OutConfig.UPStruct.AK = "";
					OutConfig.UPStruct.SK = "";
					OutConfig.UPStruct.BucketName = "";
					OutConfig.UPStruct.FolderName = "";
					OutConfig.HKStruct.KeyCode = Keys.V;
					OutConfig.HKStruct.ControlKey1 = (uint)ControlKey.MOD_CONTROL;
					OutConfig.HKStruct.ControlKey2 = (uint)ControlKey.none;
				}
				
			}
			else
			{
				OutConfig.TopMost = false;
				OutConfig.MarkdownMode = true;
				OutConfig.UPStruct.AK = "";
				OutConfig.UPStruct.SK = "";
				OutConfig.UPStruct.BucketName = "";
				OutConfig.UPStruct.FolderName = "";
				OutConfig.HKStruct.KeyCode = Keys.V;
				OutConfig.HKStruct.ControlKey1 = (uint)ControlKey.MOD_CONTROL;
				OutConfig.HKStruct.ControlKey2 = (uint)ControlKey.none;
			}

		}

		public void UpdateInfo()
		{
			try
			{
				File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(OutConfig));
			}
			catch (Exception ex)
			{
				throw new Exception("UpdateInfo() fail, error:" + ex.Message);
			}
		}
	}
}
