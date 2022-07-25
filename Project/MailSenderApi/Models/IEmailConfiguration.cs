using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSenderApi.Models
{
    public interface IEmailConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        string SmtpServer { get; }
        /// <summary>
        /// 
        /// </summary>
        int SmtpPort { get; }
        /// <summary>
        /// 
        /// </summary>
        string SmtpUsername { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string SmtpPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string PopServer { get; }
        /// <summary>
        /// 
        /// </summary>
        int PopPort { get; }
        /// <summary>
        /// 
        /// </summary>
        string PopUsername { get; }
        /// <summary>
        /// 
        /// </summary>
        string PopPassword { get; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EmailConfiguration : IEmailConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        public string SmtpServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SmtpPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpUsername { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SmtpPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PopServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PopPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PopUsername { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PopPassword { get; set; }
    }
}
