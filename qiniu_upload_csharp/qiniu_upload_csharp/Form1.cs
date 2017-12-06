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
using Qiniu.Storage;
using static qiniu_upload_csharp.HotKey;
using Newtonsoft.Json;

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

		HotKey HK;
		Uploader UP;
		ProgramConfig programConfig;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			string[] ComboBoxStr = { "None", "Alt", "Ctrl", "Shift", "Win" };
			comboBox_func1.Items.AddRange(ComboBoxStr);
			comboBox_func2.Items.AddRange(ComboBoxStr);
			comboBox_func1.SelectedIndex = 0;
			comboBox_func2.SelectedIndex = 0;

			programConfig = new ProgramConfig();

			HK = new HotKey(this.Handle);
			UP = new Uploader();

			programConfig.InitInfoFromFile();

			textBox_AK.Text = ProgramConfig.OutConfig.UPStruct.AK;
			textBox_SK.Text = ProgramConfig.OutConfig.UPStruct.SK;
			textBox_bucket_name.Text = ProgramConfig.OutConfig.UPStruct.BucketName;
			textBox_folder_name.Text = ProgramConfig.OutConfig.UPStruct.FolderName;

			checkBox_topmost.Checked = ProgramConfig.OutConfig.TopMost;
			TopMost = ProgramConfig.OutConfig.TopMost;
			checkBox_MarkdownMode.Checked = ProgramConfig.OutConfig.MarkdownMode;

			switch (ProgramConfig.OutConfig.HKStruct.ControlKey1)
			{
				case 0:
					{
						comboBox_func1.SelectedIndex = 0;
						break;
					}
				case 1:
					{
						comboBox_func1.SelectedIndex = 1;
						break;
					}
				case 2:
					{
						comboBox_func1.SelectedIndex = 2;
						break;
					}
				case 4:
					{
						comboBox_func1.SelectedIndex = 3;
						break;
					}
				case 8:
					{
						comboBox_func1.SelectedIndex = 4;
						break;
					}
				default:
					{
						comboBox_func1.SelectedIndex = 0;
						break;
					}
			}

			switch (ProgramConfig.OutConfig.HKStruct.ControlKey2)
			{
				case 0:
					{
						comboBox_func2.SelectedIndex = 0;
						break;
					}
				case 1:
					{
						comboBox_func2.SelectedIndex = 1;
						break;
					}
				case 2:
					{
						comboBox_func2.SelectedIndex = 2;
						break;
					}
				case 4:
					{
						comboBox_func2.SelectedIndex = 3;
						break;
					}
				case 8:
					{
						comboBox_func2.SelectedIndex = 4;
						break;
					}
				default:
					{
						comboBox_func2.SelectedIndex = 0;
						break;
					}
			}

			checkBoxMain.Text = ProgramConfig.OutConfig.HKStruct.KeyCode.ToString();

			HK.RegHotKey();

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
						if (UP.UploadAndPaste())
						{
							HK.UnRegHotKey();

							byte VK_CONTROL = 0x11;
							byte V_key = 0x56;
							keybd_event(VK_CONTROL, 0, 0, 0);
							keybd_event(V_key, 0, 0, 0);
							keybd_event(VK_CONTROL, 0, 2, 0);
							keybd_event(V_key, 0, 2, 0);

							HK.RegHotKey();
						}
						else
						{
							HK.UnRegHotKey();
							keybd_event((byte)ProgramConfig.OutConfig.HKStruct.KeyCode, 0, 0, 0);
							switch (ProgramConfig.OutConfig.HKStruct.ControlKey1){
								case 1:
									{
										keybd_event((byte)Keys.Menu, 0, 0, 0);
										break;
									}
								case 2:
									{
										keybd_event((byte)Keys.ControlKey, 0, 0, 0);
										break;
									}
								case 4:
									{
										keybd_event((byte)Keys.ShiftKey, 0, 0, 0);
										break;
									}
								case 8:
									{
										keybd_event((byte)Keys.LWin, 0, 0, 0);
										break;
									}
								default:
									{
										break;
									}
							}
							switch (ProgramConfig.OutConfig.HKStruct.ControlKey2)
							{
								case 1:
									{
										keybd_event((byte)Keys.Menu, 0, 0, 0);
										break;
									}
								case 2:
									{
										keybd_event((byte)Keys.ControlKey, 0, 0, 0);
										break;
									}
								case 4:
									{
										keybd_event((byte)Keys.ShiftKey, 0, 0, 0);
										break;
									}
								case 8:
									{
										keybd_event((byte)Keys.LWin, 0, 0, 0);
										break;
									}
								default:
									{
										break;
									}
							}

							keybd_event((byte)ProgramConfig.OutConfig.HKStruct.KeyCode, 0, 2, 0);
							switch (ProgramConfig.OutConfig.HKStruct.ControlKey1)
							{
								case 1:
									{
										keybd_event((byte)Keys.Menu, 0, 2, 0);
										break;
									}
								case 2:
									{
										keybd_event((byte)Keys.ControlKey, 0, 2, 0);
										break;
									}
								case 4:
									{
										keybd_event((byte)Keys.ShiftKey, 0, 2, 0);
										break;
									}
								case 8:
									{
										keybd_event((byte)Keys.LWin, 0, 2, 0);
										break;
									}
								default:
									{
										break;
									}
							}
							switch (ProgramConfig.OutConfig.HKStruct.ControlKey2)
							{
								case 1:
									{
										keybd_event((byte)Keys.Menu, 0, 2, 0);
										break;
									}
								case 2:
									{
										keybd_event((byte)Keys.ControlKey, 0, 2, 0);
										break;
									}
								case 4:
									{
										keybd_event((byte)Keys.ShiftKey, 0, 2, 0);
										break;
									}
								case 8:
									{
										keybd_event((byte)Keys.LWin, 0, 2, 0);
										break;
									}
								default:
									{
										break;
									}
							}
							HK.RegHotKey();
						}
					}
					break;
			}
			base.WndProc(ref m);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			HK.UnRegHotKey();
		}

		private void buttonQiniuSave_Click(object sender, EventArgs e)
		{
			if (UP.CheckInfo(textBox_AK.Text, textBox_SK.Text, textBox_bucket_name.Text))
			{
				ProgramConfig.OutConfig.UPStruct.AK = textBox_AK.Text;
				ProgramConfig.OutConfig.UPStruct.SK = textBox_SK.Text;
				ProgramConfig.OutConfig.UPStruct.BucketName = textBox_bucket_name.Text;
				ProgramConfig.OutConfig.UPStruct.FolderName = textBox_folder_name.Text;
				programConfig.UpdateInfo();
			}
		}

		private void buttonGeneralSave_Click(object sender, EventArgs e)
		{
			ProgramConfig.OutConfig.TopMost = checkBox_topmost.Checked;
			TopMost = checkBox_topmost.Checked;
			ProgramConfig.OutConfig.MarkdownMode = checkBox_MarkdownMode.Checked;

			switch (comboBox_func1.SelectedIndex)
			{
				case 0:
					{

						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 0;
						break;
					}
				case 1:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 1;
						break;
					}
				case 2:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 2;
						break;
					}
				case 3:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 4;
						break;
					}
				case 4:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 8;
						break;
					}
				default:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey1 = 0;
						break;
					}
			}

			switch (comboBox_func2.SelectedIndex)
			{
				case 0:
					{

						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 0;
						break;
					}
				case 1:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 1;
						break;
					}
				case 2:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 2;
						break;
					}
				case 3:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 4;
						break;
					}
				case 4:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 8;
						break;
					}
				default:
					{
						ProgramConfig.OutConfig.HKStruct.ControlKey2 = 0;
						break;
					}
			}

			HK.RegHotKey();
			programConfig.UpdateInfo();
			MessageBox.Show("Information saved!", "Success:", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void checkBoxMain_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxMain.Checked)
			{
				checkBoxMain.Text = "等待按下主键";
			}
			else
			{
				checkBoxMain.Text = ProgramConfig.OutConfig.HKStruct.KeyCode.ToString();
			}
		}

		private void checkBoxMain_KeyUp(object sender, KeyEventArgs e)
		{
			if (checkBoxMain.Checked)
			{
				checkBoxMain.Text = e.KeyCode.ToString();
				ProgramConfig.OutConfig.HKStruct.KeyCode = e.KeyCode;
				checkBoxMain.Checked = false;
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{ 
				WindowState = FormWindowState.Normal;
				this.Activate();
				this.ShowInTaskbar = true;
				notifyIcon1.Visible = false;
				HK.UpdatehWnd(this.Handle);
				HK.RegHotKey();
			}
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.ShowInTaskbar = false;
				notifyIcon1.Visible = true;
				HK.UpdatehWnd(this.Handle);
				HK.RegHotKey();
			}
		}

		private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Normal;
			this.Activate();
			this.ShowInTaskbar = true;
			notifyIcon1.Visible = false;
			HK.UpdatehWnd(this.Handle);
			HK.RegHotKey();
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				HK.UnRegHotKey();
				this.Dispose();
				this.Close();
			}
		}

	}
}
