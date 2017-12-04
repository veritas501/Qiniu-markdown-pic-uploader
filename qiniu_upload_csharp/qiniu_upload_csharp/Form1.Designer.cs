namespace qiniu_upload_csharp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox_AK = new System.Windows.Forms.TextBox();
			this.textBox_folder_name = new System.Windows.Forms.TextBox();
			this.textBox_bucket_name = new System.Windows.Forms.TextBox();
			this.textBox_SK = new System.Windows.Forms.TextBox();
			this.label_AK = new System.Windows.Forms.Label();
			this.label_SK = new System.Windows.Forms.Label();
			this.label_folder_name = new System.Windows.Forms.Label();
			this.label_bucket_name = new System.Windows.Forms.Label();
			this.buttonQiniuSave = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonGeneralSave = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
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
			this.tabPage1.Controls.Add(this.checkBox2);
			this.tabPage1.Controls.Add(this.checkBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(388, 227);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
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
			// textBox_AK
			// 
			this.textBox_AK.Location = new System.Drawing.Point(113, 35);
			this.textBox_AK.Name = "textBox_AK";
			this.textBox_AK.Size = new System.Drawing.Size(250, 21);
			this.textBox_AK.TabIndex = 15;
			// 
			// textBox_folder_name
			// 
			this.textBox_folder_name.Location = new System.Drawing.Point(113, 134);
			this.textBox_folder_name.Name = "textBox_folder_name";
			this.textBox_folder_name.Size = new System.Drawing.Size(250, 21);
			this.textBox_folder_name.TabIndex = 19;
			// 
			// textBox_bucket_name
			// 
			this.textBox_bucket_name.Location = new System.Drawing.Point(113, 101);
			this.textBox_bucket_name.Name = "textBox_bucket_name";
			this.textBox_bucket_name.Size = new System.Drawing.Size(250, 21);
			this.textBox_bucket_name.TabIndex = 17;
			// 
			// textBox_SK
			// 
			this.textBox_SK.Location = new System.Drawing.Point(113, 68);
			this.textBox_SK.Name = "textBox_SK";
			this.textBox_SK.Size = new System.Drawing.Size(250, 21);
			this.textBox_SK.TabIndex = 16;
			// 
			// label_AK
			// 
			this.label_AK.AutoSize = true;
			this.label_AK.Location = new System.Drawing.Point(30, 38);
			this.label_AK.Name = "label_AK";
			this.label_AK.Size = new System.Drawing.Size(77, 12);
			this.label_AK.TabIndex = 10;
			this.label_AK.Text = "Access Key：";
			// 
			// label_SK
			// 
			this.label_SK.AutoSize = true;
			this.label_SK.Location = new System.Drawing.Point(30, 71);
			this.label_SK.Name = "label_SK";
			this.label_SK.Size = new System.Drawing.Size(77, 12);
			this.label_SK.TabIndex = 11;
			this.label_SK.Text = "Secret Key：";
			// 
			// label_folder_name
			// 
			this.label_folder_name.AutoSize = true;
			this.label_folder_name.Location = new System.Drawing.Point(30, 137);
			this.label_folder_name.Name = "label_folder_name";
			this.label_folder_name.Size = new System.Drawing.Size(77, 12);
			this.label_folder_name.TabIndex = 14;
			this.label_folder_name.Text = "FolderName：";
			// 
			// label_bucket_name
			// 
			this.label_bucket_name.AutoSize = true;
			this.label_bucket_name.Location = new System.Drawing.Point(30, 104);
			this.label_bucket_name.Name = "label_bucket_name";
			this.label_bucket_name.Size = new System.Drawing.Size(77, 12);
			this.label_bucket_name.TabIndex = 12;
			this.label_bucket_name.Text = "BucketName：";
			// 
			// buttonQiniuSave
			// 
			this.buttonQiniuSave.Location = new System.Drawing.Point(288, 189);
			this.buttonQiniuSave.Name = "buttonQiniuSave";
			this.buttonQiniuSave.Size = new System.Drawing.Size(75, 23);
			this.buttonQiniuSave.TabIndex = 20;
			this.buttonQiniuSave.Text = "Save";
			this.buttonQiniuSave.UseVisualStyleBackColor = true;
			this.buttonQiniuSave.Click += new System.EventHandler(this.buttonQiniuSave_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(25, 33);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(30);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "窗口总在最前";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(196, 33);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(138, 16);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "使用Markdown格式Url";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(25, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(338, 109);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置粘贴热键";
			// 
			// buttonGeneralSave
			// 
			this.buttonGeneralSave.Location = new System.Drawing.Point(288, 189);
			this.buttonGeneralSave.Name = "buttonGeneralSave";
			this.buttonGeneralSave.Size = new System.Drawing.Size(75, 23);
			this.buttonGeneralSave.TabIndex = 3;
			this.buttonGeneralSave.Text = "Save";
			this.buttonGeneralSave.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(74, 23);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 0;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "辅键一：";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(74, 49);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "辅键二：";
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(74, 75);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 4;
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
			this.Text = "Qiniu Pic Markdown Uploader ver0.11";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button buttonGeneralSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
	}
}

