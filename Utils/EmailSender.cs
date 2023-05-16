using SendGrid;
using System;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonashUWCC.Utils
{
    public class EmailSender
    {
        
        private const String API_KEY = "";


        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("rajeshwari.nikitha@gmail.com", "Monash University Women's Cricket Club");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}
