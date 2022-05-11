using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTH5.Models;

namespace BaiTH5.Controllers
{
    public class GuiMailController : Controller
    {
        // GET: GuiMail
        public ActionResult GuiMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuiMail(MailInfo model)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(model.From);
            mail.To.Add(model.To);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            smtp.UseDefaultCredentials = false;
            return RedirectToAction("GuiMail", "GuiMail");
        }
    }
}