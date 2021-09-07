using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnstrumanDunyam.Models;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;




namespace EnstrumanDunyam.Controllers
{
    public class ContactController : Controller
    {

        private readonly IEmailSender _emailSender;

        public ContactController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<IActionResult> ContactMail(Contact contact)
        {
            var msg =  "<br />" + "Adı: " + contact.FirstName + "<br /> " + "Soyadı: "  + contact.LastName + "<br /> " + "Telefon Numarası: " + contact.PhoneNumber + "<br /> " + "Email: " + contact.YourEmail + "<br /> " + "Mesaj: " + contact.Message;
            await _emailSender.SendEmailAsync(contact.YourEmail, "İletişim Formu Mail Geldi", msg);
            TempData["Message"] = "Mailiniz başarıyla gönderildi, teşekkürler. ";
            return Redirect("/Home/Contact");

        }

    }

}
