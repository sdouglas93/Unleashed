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
        //}

    }
}