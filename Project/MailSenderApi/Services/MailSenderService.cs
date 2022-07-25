using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MailKit.Net.Pop3;
using MailKit.Net.Smtp;

using MailSenderApi.Models;

using MimeKit;
using MimeKit.Text;

namespace MailSenderApi.Services
{
    public class MailSenderService : IMailSenderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailConfiguration"></param>
        public MailSenderService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }
        public IEmailConfiguration _emailConfiguration { get; }
       
        bool IMailSenderService.MailSend(EmailMessage emailMessage)
        {
            var message = new MimeMessage();
            message.To.Add(new MailboxAddress(emailMessage.ToAddresses.Name, emailMessage.ToAddresses.Address));
            message.From.Add(new MailboxAddress(emailMessage.FromAddresses.Name, emailMessage.FromAddresses.Address));
            message.Subject = emailMessage.Subject;
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = emailMessage.Content
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
                emailClient.Send(message);
                emailClient.Disconnect(true);
            }
            return true;
        }
    }
}
