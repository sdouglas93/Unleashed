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
            //btnSend.Click += new EventHandler(this.btnSend_Click);
        }

        //public void btnSend_Click(object sender, eventargs e)
        //{


        //    mailmessage message = new mailmessage();
        //    message.to.add("dacute1x3@gmail.com");
        //    message.from = new mailaddress(txtemail.text);
        //    message.subject = textsubject.text;
        //    message.body = txtname.text + environment.newline + txtmessage.value;

        //    smtpclient smtp = new smtpclient();
        //    smtp.host = "smtp.gmail.com";
        //    smtp.port = 587;
        //    smtp.enablessl = true;
        //    smtp.deliverymethod = smtpdeliverymethod.network;
        //    smtp.credentials = new system.net.networkcredential("dacute1x3@gmail.com", "babyface");
        //    smtp.send(message);

        //    MailMessage message = new MailMessage();
        //    message.To.Add("");
        //    message.From = new MailAddress(txtEmail.Text);
        //    message.Subject = TextSubject.Text;
        //    message.Body = txtName.Text + Environment.NewLine + txtMessage.Value;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    smtp.EnableSsl = true;
        //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    smtp.Credentials = new System.Net.NetworkCredential("", "");
        //    smtp.Send(message);

        //}


    }
}
