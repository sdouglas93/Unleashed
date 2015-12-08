using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.Net.Mail;

namespace UnleashedBlog.Views.Contact
{
    public partial class NewForm : ViewUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public void btnSend_Click(object sender, EventArgs e)
        //{

        //    MailMessage message = new MailMessage();
        //    message.To.Add("dacute1x3@gmail.com");
        //    message.From = new MailAddress(txtEmail.Text);
        //    message.Subject = TextSubject.Text;
        //    message.Body = txtName.Text + Environment.NewLine + txtMessage.Value;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    smtp.EnableSsl = true;
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    smtp.Credentials = new System.Net.NetworkCredential("dacute1x3@gmail.com", "babyface");
        //    smtp.Send(message);
        //}

    }
}