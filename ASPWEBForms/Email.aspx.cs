using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWEBForms
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ToEmail.Text == null || ToEmail.Text == "")
                {
                    ToEmail.Text = "abc@gmail.com";
                }
                MailMessage mail = new MailMessage("FromSender@email.com", ToEmail.Text);
                mail.Subject = "Excel Sheet";
                mail.Body = "Please find below the excel attachment";
                if (FileUpload1.HasFile)
                {
                    string Filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    mail.Attachments.Add(new Attachment(FileUpload1.PostedFile.InputStream, Filename));

                }
                mail.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                NetworkCredential NetworkCred = new NetworkCredential("email", "password");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mail);
                Response.Write("Send mail");
            }
            catch(Exception ex)
            {
                Response.Write("Send mail failed");
            }
            ToEmail.Text = "";
           
        }
    }
}