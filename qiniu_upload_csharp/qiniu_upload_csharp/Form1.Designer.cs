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
			this.label_AK = new System.Windows.Forms.Label();
			this.label_SK = new System.Windows.Forms.Label();
			this.label_bucket_name = new System.Windows.Forms.Label();
			this.label_bucket_url = new System.Windows.Forms.Label();
			this.label_folder_name = new System.Windows.Forms.Label();
			this.textBox_SK = new System.Windows.Forms.TextBox();
			this.textBox_bucket_name = new System.Windows.Forms.TextBox();
			this.textBox_bucket_url = new System.Windows.Forms.TextBox();
			this.textBox_folder_name = new System.Windows.Forms.TextBox();
			this.label_hint = new System.Windows.Forms.Label();
			this.textBox_AK = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label_AK
			// 
			this.label_AK.AutoSize = true;
			this.label_AK.Location = new System.Drawing.Point(75, 16);
			this.label_AK.Name = "label_AK";
			this.label_AK.Size = new System.Drawing.Size(29, 12);
			this.label_AK.TabIndex = 0;
			this.label_AK.Text = "AK：";
			// 
			// label_SK
			// 
			this.label_SK.AutoSize = true;
			this.label_SK.Location = new System.Drawing.Point(75, 49);
			this.label_SK.Name = "label_SK";
			this.label_SK.Size = new System.Drawing.Size(29, 12);
			this.label_SK.TabIndex = 1;
			this.label_SK.Text = "SK：";
			// 
			// label_bucket_name
			// 
			this.label_bucket_name.AutoSize = true;
			this.label_bucket_name.Location = new System.Drawing.Point(27, 82);
			this.label_bucket_name.Name = "label_bucket_name";
			this.label_bucket_name.Size = new System.Drawing.Size(77, 12);
			this.label_bucket_name.TabIndex = 2;
			this.label_bucket_name.Text = "BucketName：";
			// 
			// label_bucket_url
			// 
			this.label_bucket_url.AutoSize = true;
			this.label_bucket_url.Location = new System.Drawing.Point(33, 115);
			this.label_bucket_url.Name = "label_bucket_url";
			this.label_bucket_url.Size = new System.Drawing.Size(71, 12);
			this.label_bucket_url.TabIndex = 3;
			this.label_bucket_url.Text = "BucketURL：";
			// 
			// label_folder_name
			// 
			this.label_folder_name.AutoSize = true;
			this.label_folder_name.Location = new System.Drawing.Point(27, 148);
			this.label_folder_name.Name = "label_folder_name";
			this.label_folder_name.Size = new System.Drawing.Size(77, 12);
			this.label_folder_name.TabIndex = 4;
			this.label_folder_name.Text = "FolderName：";
			// 
			// textBox_SK
			// 
			this.textBox_SK.Location = new System.Drawing.Point(110, 45);
			this.textBox_SK.Name = "textBox_SK";
			this.textBox_SK.Size = new System.Drawing.Size(250, 21);
			this.textBox_SK.TabIndex = 6;
			this.textBox_SK.TextChanged += new System.EventHandler(this.textBox_SK_TextChanged);
			// 
			// textBox_bucket_name
			// 
			this.textBox_bucket_name.Location = new System.Drawing.Point(110, 78);
			this.textBox_bucket_name.Name = "textBox_bucket_name";
			this.textBox_bucket_name.Size = new System.Drawing.Size(250, 21);
			this.textBox_bucket_name.TabIndex = 7;
			this.textBox_bucket_name.TextChanged += new System.EventHandler(this.textBox_bucket_name_TextChanged);
			// 
			// textBox_bucket_url
			// 
			this.textBox_bucket_url.Location = new System.Drawing.Point(110, 111);
			this.textBox_bucket_url.Name = "textBox_bucket_url";
			this.textBox_bucket_url.Size = new System.Drawing.Size(250, 21);
			this.textBox_bucket_url.TabIndex = 8;
			this.textBox_bucket_url.TextChanged += new System.EventHandler(this.textBox_bucket_url_TextChanged);
			// 
			// textBox_folder_name
			// 
			this.textBox_folder_name.Location = new System.Drawing.Point(110, 144);
			this.textBox_folder_name.Name = "textBox_folder_name";
			this.textBox_folder_name.Size = new System.Drawing.Size(250, 21);
			this.textBox_folder_name.TabIndex = 9;
			this.textBox_folder_name.TextChanged += new System.EventHandler(this.textBox_folder_name_TextChanged);
			// 
			// label_hint
			// 
			this.label_hint.AutoSize = true;
			this.label_hint.Location = new System.Drawing.Point(131, 189);
			this.label_hint.Name = "label_hint";
			this.label_hint.Size = new System.Drawing.Size(107, 12);
			this.label_hint.TabIndex = 10;
			this.label_hint.Text = "热键 Ctrl+Shift+V";
			// 
			// textBox_AK
			// 
			this.textBox_AK.Location = new System.Drawing.Point(110, 12);
			this.textBox_AK.Name = "textBox_AK";
			this.textBox_AK.Size = new System.Drawing.Size(250, 21);
			this.textBox_AK.TabIndex = 5;
			this.textBox_AK.TextChanged += new System.EventHandler(this.textBox_AK_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 210);
			this.Controls.Add(this.textBox_AK);
			this.Controls.Add(this.label_hint);
			this.Controls.Add(this.textBox_folder_name);
			this.Controls.Add(this.textBox_bucket_url);
			this.Controls.Add(this.textBox_bucket_name);
			this.Controls.Add(this.textBox_SK);
			this.Controls.Add(this.label_AK);
			this.Controls.Add(this.label_SK);
			this.Controls.Add(this.label_folder_name);
			this.Controls.Add(this.label_bucket_url);
			this.Controls.Add(this.label_bucket_name);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Qiniu Pic Markdown Uploader ver0.11";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_AK;
		private System.Windows.Forms.Label label_SK;
		private System.Windows.Forms.Label label_bucket_name;
		private System.Windows.Forms.Label label_bucket_url;
		private System.Windows.Forms.Label label_folder_name;
		private System.Windows.Forms.TextBox textBox_SK;
		private System.Windows.Forms.TextBox textBox_bucket_name;
		private System.Windows.Forms.TextBox textBox_bucket_url;
		private System.Windows.Forms.TextBox textBox_folder_name;
		private System.Windows.Forms.Label label_hint;
		private System.Windows.Forms.TextBox textBox_AK;
	}
}

