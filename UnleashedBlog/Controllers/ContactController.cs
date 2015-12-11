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
            //return View(Contact, new ContactInfo);
        }

        public ActionResult Contact()
        {
            return View();
            //return View(Contact, new ContactInfo);
        }
        [HttpPost]
        public ActionResult Contact(ContactInfo contact) {
            if (ModelState.IsValid) 
            {
                //try
                //{
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(contact.email);
                    //message.From = new MailAddress("dacute1x3@gmail.com");
                    message.To.Add("dacute1x3@gmail.com");
                    message.Subject = "Feel Free to Contact Us";
                    message.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient();
                    //smtp.Host = "smtp.gmail.com";
                    //smtp.Port = 25;
                    //smtp.EnableSsl = true;
                    //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //smtp.Credentials = new System.Net.NetworkCredential("dacute1x3@gmail.com", "Jaimechocolat#93");


                    StringBuilder sb = new StringBuilder();
                    sb.Append("First Name: " + contact.firstName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Last Name: " + contact.lastName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + contact.email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Comments" + contact.comment);

                    message.Body = sb.ToString();
                    try{
                    smtp.Send(message);
                    return View("Contact", contact);
                    //message.Dispose();

                   
                    
                }
                catch (Exception exception) 
                {
                   
                     Console.Write(exception);
                    return View("Error");
                }
            }
            return View("Contact", contact);
        }

    }
}
