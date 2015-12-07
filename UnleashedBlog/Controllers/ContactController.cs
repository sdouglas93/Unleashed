using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnleashedBlog.Models;
using System.Net.Mail;
using System.Text;

namespace UnleashedBlog.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactInfo contact) {
            if (ModelState.IsValid) 
            {
                try
                {
                    MailMessage message = new MailMessage();
                    MailAddress from = new MailAddress(contact.email.ToString());
                    message.To.Add("dacute1x3@gmail.com");
                    message.Subject = "Feel Free to Contact Us";
                    message.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("dacute1x3@gmail.com", "babyface");


                    StringBuilder sb = new StringBuilder();
                    sb.Append("First Name: " + contact.firstName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Last Name: " + contact.lastName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + contact.email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Comments" + contact.comment);

                    message.Body = sb.ToString();
                    smtp.Send(message);

                    message.Dispose();

                    return View("Success");
                    
                }
                catch (Exception) 
                {
                    return View("Error");
                }
            }
            return View();
        }

    }
}
