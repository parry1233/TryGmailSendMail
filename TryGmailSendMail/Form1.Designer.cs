namespace TryGmailSendMail
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.MailFromTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.MailToTextBox = new System.Windows.Forms.TextBox();
			this.RandomShowLabel = new System.Windows.Forms.Label();
			this.SendBTN = new System.Windows.Forms.Button();
			this.GenerateBTN = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.PwdTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// MailFromTextBox
			// 
			this.MailFromTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.MailFromTextBox.Location = new System.Drawing.Point(95, 9);
			this.MailFromTextBox.Name = "MailFromTextBox";
			this.MailFromTextBox.Size = new System.Drawing.Size(321, 27);
			this.MailFromTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mail From:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(28, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mail To:";
			// 
			// MailToTextBox
			// 
			this.MailToTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.MailToTextBox.Location = new System.Drawing.Point(95, 91);
			this.MailToTextBox.Name = "MailToTextBox";
			this.MailToTextBox.Size = new System.Drawing.Size(321, 27);
			this.MailToTextBox.TabIndex = 2;
			// 
			// RandomShowLabel
			// 
			this.RandomShowLabel.AutoSize = true;
			this.RandomShowLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.RandomShowLabel.Location = new System.Drawing.Point(12, 148);
			this.RandomShowLabel.Name = "RandomShowLabel";
			this.RandomShowLabel.Size = new System.Drawing.Size(101, 16);
			this.RandomShowLabel.TabIndex = 4;
			this.RandomShowLabel.Text = "Random Text: ";
			// 
			// SendBTN
			// 
			this.SendBTN.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SendBTN.Location = new System.Drawing.Point(209, 182);
			this.SendBTN.Name = "SendBTN";
			this.SendBTN.Size = new System.Drawing.Size(85, 31);
			this.SendBTN.TabIndex = 5;
			this.SendBTN.Text = "Send";
			this.SendBTN.UseVisualStyleBackColor = true;
			this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
			// 
			// GenerateBTN
			// 
			this.GenerateBTN.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.GenerateBTN.Location = new System.Drawing.Point(118, 182);
			this.GenerateBTN.Name = "GenerateBTN";
			this.GenerateBTN.Size = new System.Drawing.Size(85, 31);
			this.GenerateBTN.TabIndex = 6;
			this.GenerateBTN.Text = "Generate";
			this.GenerateBTN.UseVisualStyleBackColor = true;
			this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(12, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mail PWD:";
			// 
			// PwdTextBox
			// 
			this.PwdTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PwdTextBox.Location = new System.Drawing.Point(95, 45);
			this.PwdTextBox.Name = "PwdTextBox";
			this.PwdTextBox.PasswordChar = '＊';
			this.PwdTextBox.Size = new System.Drawing.Size(321, 27);
			this.PwdTextBox.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 225);
			this.Controls.Add(this.PwdTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.GenerateBTN);
			this.Controls.Add(this.SendBTN);
			this.Controls.Add(this.RandomShowLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MailToTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MailFromTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MailFromTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox MailToTextBox;
		private System.Windows.Forms.Label RandomShowLabel;
		private System.Windows.Forms.Button SendBTN;
		private System.Windows.Forms.Button GenerateBTN;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PwdTextBox;
	}
}

