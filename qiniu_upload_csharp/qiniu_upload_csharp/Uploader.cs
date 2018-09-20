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
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
		[DllImport("user32.dll")]
		static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

		public Uploader()
		{
			
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

		public bool CheckInfo(string AK, string SK, string BucketName)
		{
			string TestFileName = "QiniuUploaderTestFile";
			string TestFilePath = System.Environment.CurrentDirectory + "\\" + TestFileName;
			string TestFileContent = "Test";

			File.WriteAllText(TestFilePath, TestFileContent);

			Mac mac = new Mac(AK, SK);
			PutPolicy putPolicy = new PutPolicy
			{
				Scope = BucketName
			};
			string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
			Config config = new Config
			{
				// 设置上传区域
				//Zone = Zone.ZONE_CN_East,
				// 设置 http 或者 https 上传
				UseHttps = true,
				UseCdnDomains = true,
				ChunkSize = ChunkUnit.U512K
			};
			FormUploader target = new FormUploader(config);
			HttpResult result = target.UploadFile(TestFilePath, TestFileName, token, null);
			if (File.Exists(TestFilePath))
			{
				File.Delete(TestFilePath);
			}

			switch (result.RefCode)
			{
				case 200:
					{
						//delete temp file
						BucketManager bm = new BucketManager(mac, config);
						HttpResult deleteRet = bm.Delete(BucketName, TestFileName);

						MessageBox.Show("Information saved!", "Success:", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return true;
					}
				case 631:
					{
						MessageBox.Show("No such Bucket!", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				case 401:
					{
						MessageBox.Show("AK or SK is incorrect!", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
			}
			MessageBox.Show(result.RefText, "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		public string GetBucketURL()
		{
			return ProgramConfig.OutConfig.UPStruct.Domain;
		}


		public bool UploadAndPaste()
		{

			Image Clipboard_image = Clipboard.GetImage();
			if (Clipboard_image != null)
			{
				Console.WriteLine(DateTime.Now + "have image");
				Clipboard_image.Save(ProgramConfig.TmpImagePath);
				string filename = ProgramConfig.OutConfig.UPStruct.FolderName + "_" + GetMD5HashFromFile(ProgramConfig.TmpImagePath) + ".png";
				Mac mac = new Mac(ProgramConfig.OutConfig.UPStruct.AK, ProgramConfig.OutConfig.UPStruct.SK);
				PutPolicy putPolicy = new PutPolicy
				{
					Scope = ProgramConfig.OutConfig.UPStruct.BucketName
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
				HttpResult result = target.UploadFile(ProgramConfig.TmpImagePath, filename, token, null);
				string Clipboard_out;

				if (ProgramConfig.OutConfig.MarkdownMode)
				{
					Clipboard_out = "![](http://" + GetBucketURL() + "/" + filename + ")";
				}
				else
				{
					Clipboard_out = "http://" + GetBucketURL() + "/" + filename;
				}
				
				Clipboard.SetText(Clipboard_out);
				if (File.Exists(ProgramConfig.TmpImagePath))
				{
					File.Delete(ProgramConfig.TmpImagePath);
				}
				return true;
			}

			Console.WriteLine(DateTime.Now + "no image");
			return false;

		}

	}
}
