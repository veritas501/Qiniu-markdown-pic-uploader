﻿namespace qiniu_upload_csharp
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGeneralSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_func2 = new System.Windows.Forms.ComboBox();
            this.comboBox_func1 = new System.Windows.Forms.ComboBox();
            this.checkBoxMain = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_MarkdownMode = new System.Windows.Forms.CheckBox();
            this.checkBox_topmost = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonQiniuSave = new System.Windows.Forms.Button();
            this.textBox_AK = new System.Windows.Forms.TextBox();
            this.textBox_folder_name = new System.Windows.Forms.TextBox();
            this.textBox_bucket_name = new System.Windows.Forms.TextBox();
            this.textBox_SK = new System.Windows.Forms.TextBox();
            this.label_AK = new System.Windows.Forms.Label();
            this.label_SK = new System.Windows.Forms.Label();
            this.label_folder_name = new System.Windows.Forms.Label();
            this.label_bucket_name = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Domain = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 253);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGeneralSave);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.checkBox_MarkdownMode);
            this.tabPage1.Controls.Add(this.checkBox_topmost);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGeneralSave
            // 
            this.buttonGeneralSave.Location = new System.Drawing.Point(288, 189);
            this.buttonGeneralSave.Name = "buttonGeneralSave";
            this.buttonGeneralSave.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneralSave.TabIndex = 3;
            this.buttonGeneralSave.Text = "Save";
            this.buttonGeneralSave.UseVisualStyleBackColor = true;
            this.buttonGeneralSave.Click += new System.EventHandler(this.buttonGeneralSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_func2);
            this.groupBox1.Controls.Add(this.comboBox_func1);
            this.groupBox1.Controls.Add(this.checkBoxMain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置粘贴热键";
            // 
            // comboBox_func2
            // 
            this.comboBox_func2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_func2.FormattingEnabled = true;
            this.comboBox_func2.Location = new System.Drawing.Point(74, 85);
            this.comboBox_func2.Name = "comboBox_func2";
            this.comboBox_func2.Size = new System.Drawing.Size(121, 20);
            this.comboBox_func2.TabIndex = 8;
            // 
            // comboBox_func1
            // 
            this.comboBox_func1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_func1.FormattingEnabled = true;
            this.comboBox_func1.Location = new System.Drawing.Point(74, 55);
            this.comboBox_func1.Name = "comboBox_func1";
            this.comboBox_func1.Size = new System.Drawing.Size(121, 20);
            this.comboBox_func1.TabIndex = 7;
            // 
            // checkBoxMain
            // 
            this.checkBoxMain.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMain.Location = new System.Drawing.Point(74, 20);
            this.checkBoxMain.Name = "checkBoxMain";
            this.checkBoxMain.Size = new System.Drawing.Size(121, 24);
            this.checkBoxMain.TabIndex = 6;
            this.checkBoxMain.Text = "按下设置主键";
            this.checkBoxMain.UseVisualStyleBackColor = true;
            this.checkBoxMain.CheckedChanged += new System.EventHandler(this.checkBoxMain_CheckedChanged);
            this.checkBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkBoxMain_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "辅键二：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "辅键一：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主键：";
            // 
            // checkBox_MarkdownMode
            // 
            this.checkBox_MarkdownMode.AutoSize = true;
            this.checkBox_MarkdownMode.Checked = true;
            this.checkBox_MarkdownMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MarkdownMode.Location = new System.Drawing.Point(196, 33);
            this.checkBox_MarkdownMode.Name = "checkBox_MarkdownMode";
            this.checkBox_MarkdownMode.Size = new System.Drawing.Size(138, 16);
            this.checkBox_MarkdownMode.TabIndex = 1;
            this.checkBox_MarkdownMode.Text = "使用Markdown格式Url";
            this.checkBox_MarkdownMode.UseVisualStyleBackColor = true;
            // 
            // checkBox_topmost
            // 
            this.checkBox_topmost.AutoSize = true;
            this.checkBox_topmost.Location = new System.Drawing.Point(25, 33);
            this.checkBox_topmost.Margin = new System.Windows.Forms.Padding(30);
            this.checkBox_topmost.Name = "checkBox_topmost";
            this.checkBox_topmost.Size = new System.Drawing.Size(96, 16);
            this.checkBox_topmost.TabIndex = 0;
            this.checkBox_topmost.Text = "窗口总在最前";
            this.checkBox_topmost.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_Domain);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonQiniuSave);
            this.tabPage2.Controls.Add(this.textBox_AK);
            this.tabPage2.Controls.Add(this.textBox_folder_name);
            this.tabPage2.Controls.Add(this.textBox_bucket_name);
            this.tabPage2.Controls.Add(this.textBox_SK);
            this.tabPage2.Controls.Add(this.label_AK);
            this.tabPage2.Controls.Add(this.label_SK);
            this.tabPage2.Controls.Add(this.label_folder_name);
            this.tabPage2.Controls.Add(this.label_bucket_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Qiniu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonQiniuSave
            // 
            this.buttonQiniuSave.Location = new System.Drawing.Point(288, 181);
            this.buttonQiniuSave.Name = "buttonQiniuSave";
            this.buttonQiniuSave.Size = new System.Drawing.Size(75, 23);
            this.buttonQiniuSave.TabIndex = 20;
            this.buttonQiniuSave.Text = "Save";
            this.buttonQiniuSave.UseVisualStyleBackColor = true;
            this.buttonQiniuSave.Click += new System.EventHandler(this.buttonQiniuSave_Click);
            // 
            // textBox_AK
            // 
            this.textBox_AK.Location = new System.Drawing.Point(113, 25);
            this.textBox_AK.Name = "textBox_AK";
            this.textBox_AK.Size = new System.Drawing.Size(250, 21);
            this.textBox_AK.TabIndex = 15;
            // 
            // textBox_folder_name
            // 
            this.textBox_folder_name.Location = new System.Drawing.Point(113, 124);
            this.textBox_folder_name.Name = "textBox_folder_name";
            this.textBox_folder_name.Size = new System.Drawing.Size(250, 21);
            this.textBox_folder_name.TabIndex = 19;
            // 
            // textBox_bucket_name
            // 
            this.textBox_bucket_name.Location = new System.Drawing.Point(113, 91);
            this.textBox_bucket_name.Name = "textBox_bucket_name";
            this.textBox_bucket_name.Size = new System.Drawing.Size(250, 21);
            this.textBox_bucket_name.TabIndex = 17;
            // 
            // textBox_SK
            // 
            this.textBox_SK.Location = new System.Drawing.Point(113, 58);
            this.textBox_SK.Name = "textBox_SK";
            this.textBox_SK.Size = new System.Drawing.Size(250, 21);
            this.textBox_SK.TabIndex = 16;
            // 
            // label_AK
            // 
            this.label_AK.AutoSize = true;
            this.label_AK.Location = new System.Drawing.Point(30, 28);
            this.label_AK.Name = "label_AK";
            this.label_AK.Size = new System.Drawing.Size(77, 12);
            this.label_AK.TabIndex = 10;
            this.label_AK.Text = "Access Key：";
            // 
            // label_SK
            // 
            this.label_SK.AutoSize = true;
            this.label_SK.Location = new System.Drawing.Point(30, 61);
            this.label_SK.Name = "label_SK";
            this.label_SK.Size = new System.Drawing.Size(77, 12);
            this.label_SK.TabIndex = 11;
            this.label_SK.Text = "Secret Key：";
            // 
            // label_folder_name
            // 
            this.label_folder_name.AutoSize = true;
            this.label_folder_name.Location = new System.Drawing.Point(30, 127);
            this.label_folder_name.Name = "label_folder_name";
            this.label_folder_name.Size = new System.Drawing.Size(77, 12);
            this.label_folder_name.TabIndex = 14;
            this.label_folder_name.Text = "FolderName：";
            // 
            // label_bucket_name
            // 
            this.label_bucket_name.AutoSize = true;
            this.label_bucket_name.Location = new System.Drawing.Point(30, 94);
            this.label_bucket_name.Name = "label_bucket_name";
            this.label_bucket_name.Size = new System.Drawing.Size(77, 12);
            this.label_bucket_name.TabIndex = 12;
            this.label_bucket_name.Text = "BucketName：";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Qiniu Pic Markdown Uploader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Domain(Ro)：";
            // 
            // comboBox_Domain
            // 
            this.comboBox_Domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Domain.FormattingEnabled = true;
            this.comboBox_Domain.Location = new System.Drawing.Point(113, 155);
            this.comboBox_Domain.Name = "comboBox_Domain";
            this.comboBox_Domain.Size = new System.Drawing.Size(250, 20);
            this.comboBox_Domain.TabIndex = 23;
            this.comboBox_Domain.Click += new System.EventHandler(this.comboBox_Domain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qiniu Pic Markdown Uploader ver1.0.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox_AK;
		private System.Windows.Forms.TextBox textBox_folder_name;
		private System.Windows.Forms.TextBox textBox_bucket_name;
		private System.Windows.Forms.TextBox textBox_SK;
		private System.Windows.Forms.Label label_AK;
		private System.Windows.Forms.Label label_SK;
		private System.Windows.Forms.Label label_folder_name;
		private System.Windows.Forms.Label label_bucket_name;
		private System.Windows.Forms.Button buttonQiniuSave;
		private System.Windows.Forms.CheckBox checkBox_topmost;
		private System.Windows.Forms.Button buttonGeneralSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox_MarkdownMode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxMain;
		private System.Windows.Forms.ComboBox comboBox_func2;
		private System.Windows.Forms.ComboBox comboBox_func1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Domain;
    }
}

