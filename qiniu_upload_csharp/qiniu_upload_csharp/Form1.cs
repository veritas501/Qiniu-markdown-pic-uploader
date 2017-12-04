﻿using System;
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
using Qiniu.Storage;
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

		Uploader up = new Uploader();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			uint MOD_CONTROL = 0x2;
			uint MOD_SHIFT = 0x4;
			RegisterHotKey(this.Handle, 233, MOD_CONTROL | MOD_SHIFT, Keys.V);

			up.InitInfoFromFile();

			textBox_AK.Text = up.QiniuInfo.AK;
			textBox_SK.Text = up.QiniuInfo.SK;
			textBox_bucket_name.Text = up.QiniuInfo.BucketName;
			textBox_folder_name.Text = up.QiniuInfo.FolderName;
			this.ActiveControl = label_AK;


		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x0312:    //window消息定义的注册的热键消息 
					if (m.WParam.ToString().Equals("233"))
					{
						//触发热键
						if (up.UploadAndPaste())
						{

							UnregisterHotKey(this.Handle, 233);
							byte VK_CONTROL = 0x11;
							byte V_key = 0x56;
							keybd_event(VK_CONTROL, 0, 2, 0);
							keybd_event(V_key, 0, 2, 0);
							keybd_event(VK_CONTROL, 0, 0, 0);
							keybd_event(V_key, 0, 0, 0);
							keybd_event(VK_CONTROL, 0, 2, 0);
							keybd_event(V_key, 0, 2, 0);
							RegisterHotKey(this.Handle, 233, 2 | 4, Keys.V);
							break;

						}
					}
					break;
			}
			base.WndProc(ref m);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			UnregisterHotKey(this.Handle, 233);
		}

		private void buttonQiniuSave_Click(object sender, EventArgs e)
		{
			if (up.CheckInfo(textBox_AK.Text, textBox_SK.Text, textBox_bucket_name.Text))
			{
				up.QiniuInfo.AK = textBox_AK.Text;
				up.QiniuInfo.SK = textBox_SK.Text;
				up.QiniuInfo.BucketName = textBox_bucket_name.Text;
				up.QiniuInfo.FolderName = textBox_folder_name.Text;
				up.UpdateInfo();
			}
		}
	}
}
