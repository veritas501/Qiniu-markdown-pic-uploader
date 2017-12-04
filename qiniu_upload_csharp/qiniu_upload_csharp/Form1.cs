using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Json;
using Qiniu.Util;
using Qiniu.Storage;
using Qiniu.Http;

namespace qiniu_upload_csharp
{
	public partial class Form1 : Form
	{

		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
		[DllImport("user32.dll")]
		static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

		public class QiniuInfo
		{
			public string AK;
			public string SK;
			public string Bucket_name;
			public string Bucket_url;
			public string Folder_name;
		}

		private QiniuInfo i_QiniuInfo = new QiniuInfo();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			uint MOD_CONTROL = 0x2;
			uint MOD_SHIFT = 0x4;
			RegisterHotKey(this.Handle, 233, MOD_CONTROL | MOD_SHIFT, Keys.V);

			if (File.Exists(System.Environment.CurrentDirectory + @"\qiniu.config"))
			{
				if (File.Exists(System.Environment.CurrentDirectory + @"\qiniu.config"))
				{
					string In_json = File.ReadAllText(System.Environment.CurrentDirectory + @"\qiniu.config");

					var serializer = new DataContractJsonSerializer(typeof(QiniuInfo));// json deserialize
					var mStream = new MemoryStream(Encoding.Default.GetBytes(In_json));
					try
					{
						i_QiniuInfo = (QiniuInfo)serializer.ReadObject(mStream);
					}
					catch (Exception)
					{
						i_QiniuInfo.AK = "";
						i_QiniuInfo.SK = "";
						i_QiniuInfo.Bucket_name = "";
						i_QiniuInfo.Bucket_url = "";
						i_QiniuInfo.Folder_name = "";
					}
					
				}
				else
				{
					i_QiniuInfo.AK = "";
					i_QiniuInfo.SK = "";
					i_QiniuInfo.Bucket_name = "";
					i_QiniuInfo.Bucket_url = "";
					i_QiniuInfo.Folder_name = "";
				}

				textBox_AK.Text = i_QiniuInfo.AK;
				textBox_SK.Text = i_QiniuInfo.SK;
				textBox_bucket_name.Text = i_QiniuInfo.Bucket_name;
				textBox_bucket_url.Text = i_QiniuInfo.Bucket_url;
				textBox_folder_name.Text = i_QiniuInfo.Folder_name;
				this.ActiveControl = label_AK;

			}

		}

		private static string GetMD5HashFromFile(string fileName)
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

		private void Upload()
		{
			Image Clipboard_image = Clipboard.GetImage();
			if (Clipboard_image != null)
			{
				Clipboard_image.Save(System.Environment.CurrentDirectory + @"\Clipboard_image.png");
				string filename = i_QiniuInfo.Folder_name + "_" + GetMD5HashFromFile(System.Environment.CurrentDirectory + @"\Clipboard_image.png") + ".png";
				Mac mac = new Mac(i_QiniuInfo.AK, i_QiniuInfo.SK);
				PutPolicy putPolicy = new PutPolicy();
				putPolicy.Scope = i_QiniuInfo.Bucket_name;
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
				HttpResult result = target.UploadFile(System.Environment.CurrentDirectory + @"\Clipboard_image.png", filename, token, null);
				string Clipboard_out = "![](http://" + i_QiniuInfo.Bucket_url + "/" + filename + ")";
				Clipboard.SetText(Clipboard_out);
				if (File.Exists(System.Environment.CurrentDirectory + @"\Clipboard_image.png"))
				{
					File.Delete(System.Environment.CurrentDirectory + @"\Clipboard_image.png");
				}
				byte VK_CONTROL = 0x11;
				byte V_key = 0x56;
				keybd_event(VK_CONTROL, 0, 0, 0);
				keybd_event(V_key, 0, 0, 0);
				keybd_event(VK_CONTROL, 0, 2, 0);
				keybd_event(V_key, 0, 2, 0);
			}

		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x0312:    //window消息定义的注册的热键消息 
					if (m.WParam.ToString().Equals("233"))
					{
						//触发热键
						Upload();
					}
					break;
			}
			base.WndProc(ref m);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			UnregisterHotKey(this.Handle, 233);
		}

		private void Write_config_to_file()
		{
			string Out_json;
			string Fmt = "\"AK\": \"{0}\", \"SK\": \"{1}\", \"Bucket_name\": \"{2}\", \"Bucket_url\": \"{3}\", \"Folder_name\": \"{4}\"";
			Out_json = string.Format(Fmt, i_QiniuInfo.AK, i_QiniuInfo.SK, i_QiniuInfo.Bucket_name, i_QiniuInfo.Bucket_url, i_QiniuInfo.Folder_name);
			Out_json = "{" + Out_json + "}";

			File.WriteAllText(System.Environment.CurrentDirectory + @"\qiniu.config", Out_json);

		}

		private void textBox_AK_TextChanged(object sender, EventArgs e)
		{
			i_QiniuInfo.AK = textBox_AK.Text;
			Write_config_to_file();
		}

		private void textBox_SK_TextChanged(object sender, EventArgs e)
		{
			i_QiniuInfo.SK = textBox_SK.Text;
			Write_config_to_file();
		}

		private void textBox_bucket_name_TextChanged(object sender, EventArgs e)
		{
			i_QiniuInfo.Bucket_name = textBox_bucket_name.Text;
			Write_config_to_file();
		}

		private void textBox_bucket_url_TextChanged(object sender, EventArgs e)
		{
			i_QiniuInfo.Bucket_url = textBox_bucket_url.Text;
			Write_config_to_file();
		}

		private void textBox_folder_name_TextChanged(object sender, EventArgs e)
		{
			i_QiniuInfo.Folder_name = textBox_folder_name.Text;
			Write_config_to_file();
		}
	}
}
