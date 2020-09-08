using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;//Send Mail

namespace TryGmailSendMail
{
	public partial class Form1 : Form
	{
		private Random rnd = new Random();
		private string RdmText;
		public Form1()
		{
			InitializeComponent();
			this.RdmText = "";
		}

		private void GenerateBTN_Click(object sender, EventArgs e)
		{
			string RdmTemp;
			var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var stringChars = new char[6];
			
			for(int i=0;i<stringChars.Length;i++)
			{
				stringChars[i] = chars[this.rnd.Next(chars.Length)];
			}

			RdmTemp = new string(stringChars);
			this.RdmText = RdmTemp;

			RandomShowLabel.Text = "Random Text: " + this.RdmText;
		}

		private void SendBTN_Click(object sender, EventArgs e)
		{
			try
			{
				System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
				msg.To.Add(MailToTextBox.Text);
				//msg.To.Add("b@b.com");可以發送給多人
				//msg.CC.Add("c@c.com");
				//msg.CC.Add("c@c.com");可以抄送副本給多人 
				//這裡可以隨便填，不是很重要
				msg.From = new MailAddress(MailFromTextBox.Text, "CCUiGO_GM", System.Text.Encoding.UTF8);
				/* 上面3個參數分別是發件人地址（可以隨便寫），發件人姓名，編碼*/
				msg.Subject = "Your Verify Code";//郵件標題
				msg.SubjectEncoding = System.Text.Encoding.UTF8;//郵件標題編碼
				msg.Body = "We appreciate you for using CCUiGO.\nYour Verify Code is: "+this.RdmText+"."; //郵件內容
				msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
				//msg.Attachments.Add(new Attachment(@"D:\test2.docx"));  //附件
				msg.IsBodyHtml = true;//是否是HTML郵件 
				//msg.Priority = MailPriority.High;//郵件優先級 

				SmtpClient client = new SmtpClient();
				client.Credentials = new System.Net.NetworkCredential(MailFromTextBox.Text, PwdTextBox.Text); //這裡要填正確的帳號跟密碼
				client.Host = "smtp.gmail.com"; //設定smtp Server
				client.Port = 25; //設定Port
				client.EnableSsl = true; //gmail預設開啟驗證
				client.Send(msg); //寄出信件
				client.Dispose();
				msg.Dispose();
				MessageBox.Show(this, "郵件寄送成功！");
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}
	}
}
