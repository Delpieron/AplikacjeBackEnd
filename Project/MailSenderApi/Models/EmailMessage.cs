using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSenderApi.Models
{
    public class EmailMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public EmailMessage()
        {
            ToAddresses = new MailSender();
            FromAddresses = new MailSender();
        }
        /// <summary>
        /// 
        /// </summary>
        public MailSender ToAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MailSender FromAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }
    }
}
