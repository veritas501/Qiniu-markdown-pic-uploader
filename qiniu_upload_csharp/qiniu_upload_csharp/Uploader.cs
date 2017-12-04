using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Qiniu.Util;
using Qiniu.Storage;
using Qiniu.Http;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace qiniu_upload_csharp
{
	class Uploader
	{

		public class QiniuInfoStruc
		{
			public string AK;
			public string SK;
			public string BucketName;
			public string BucketUrl;
			public string FolderName;
		}

		public QiniuInfoStruc QiniuInfo;
		public string TmpImagePath;
		public string ConfigPath;

		public Uploader()
		{
			TmpImagePath = System.Environment.CurrentDirectory + @"\Clipboard_image.png";
			ConfigPath = System.Environment.CurrentDirectory + @"\qiniu.config";
			QiniuInfo = new QiniuInfoStruc();
		}

		public void UpdateInfo()
		{
			string Out_json;
			string Fmt = "\"AK\": \"{0}\", \"SK\": \"{1}\", \"BucketName\": \"{2}\", \"BucketUrl\": \"{3}\", \"FolderName\": \"{4}\"";
			Out_json = string.Format(Fmt, QiniuInfo.AK, QiniuInfo.SK, QiniuInfo.BucketName, QiniuInfo.BucketUrl, QiniuInfo.FolderName);
			Out_json = "{" + Out_json + "}";

			try
			{
				File.WriteAllText(ConfigPath, Out_json);
			}
			catch (Exception ex)
			{
				throw new Exception("UpdateInfo() fail, error:" + ex.Message);
			}
		}

		public void InitInfoFromFile(string FilePath = "")
		{
			if(FilePath == "")
			{
				FilePath = ConfigPath;
			}

			if (File.Exists(FilePath))
			{
				string InJson = File.ReadAllText(FilePath);

				try
				{
					QiniuInfo = (QiniuInfoStruc)JsonConvert.DeserializeObject(InJson, typeof(QiniuInfoStruc));
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					QiniuInfo.AK = "";
					QiniuInfo.SK = "";
					QiniuInfo.BucketName = "";
					QiniuInfo.BucketUrl = "";
					QiniuInfo.FolderName = "";
				}

			}
			else
			{
				QiniuInfo.AK = "";
				QiniuInfo.SK = "";
				QiniuInfo.BucketName = "";
				QiniuInfo.BucketUrl = "";
				QiniuInfo.FolderName = "";
			}
		}

		public string GetMD5HashFromFile(string fileName)
		{
			try
			{
				FileStream file = new FileStream(fileName, FileMode.Open);
				System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
				byte[] retVal = md5.ComputeHash(file);
				file.Close();

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < retVal.Length; i++)
				{
					sb.Append(retVal[i].ToString("x2"));
				}
				return sb.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception("GetMD5HashFromFile() fail, error:" + ex.Message);
			}
		}

		public bool UploadAndPaste()
		{
			Image Clipboard_image = Clipboard.GetImage();
			if (Clipboard_image != null)
			{
				Clipboard_image.Save(TmpImagePath);
				string filename = QiniuInfo.FolderName + "_" + GetMD5HashFromFile(TmpImagePath) + ".png";
				Mac mac = new Mac(QiniuInfo.AK, QiniuInfo.SK);
				PutPolicy putPolicy = new PutPolicy
				{
					Scope = QiniuInfo.BucketName
				};
				string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
				Config config = new Config
				{
					// 设置上传区域
					Zone = Zone.ZONE_CN_East,
					// 设置 http 或者 https 上传
					UseHttps = true,
					UseCdnDomains = true,
					ChunkSize = ChunkUnit.U512K
				};
				// 表单上传
				FormUploader target = new FormUploader(config);
				HttpResult result = target.UploadFile(TmpImagePath, filename, token, null);
				string Clipboard_out = "![](http://" + QiniuInfo.BucketUrl + "/" + filename + ")";
				Clipboard.SetText(Clipboard_out);
				if (File.Exists(TmpImagePath))
				{
					File.Delete(TmpImagePath);
				}
				return true;
			}
			return false;
		}

	}
}
