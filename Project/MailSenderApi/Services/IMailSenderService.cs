using MailSenderApi.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSenderApi.Services
{
    public interface IMailSenderService
    {
        /// <param name="emailMessage"></param>
        public bool MailSend(EmailMessage emailMessage);
    }
}
