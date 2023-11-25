using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalR.WebUI.Dtos.MailDtos;

namespace SignalR.WebUI.Controllers
{
    //mail gönderme işlemleri yapılır
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreateMailDto createMailDto)
        {
            #region mail gönderme işlemi

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("SignalR Rezervasyon", "emirdeneme41@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDto.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder=new BodyBuilder();  
            bodyBuilder.TextBody=createMailDto.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody(); //mail içeriği eklendi
            mimeMessage.Subject = createMailDto.Subject;

            //lfgn gwbx cojo tgmz

            //şifreleme işlemleri
            SmtpClient client =new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            //client.Authenticate("mesajınGönderileceğiMailAdresi", "key");
            client.Authenticate("emirdeneme41@gmail.com", "lfgn gwbx cojo tgmz");
            client.Send(mimeMessage);
            client.Disconnect(true);


            #endregion

            return RedirectToAction("Index","Default");
        }
    }
}
