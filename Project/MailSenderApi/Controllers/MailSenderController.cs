using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MailSenderApi.Services;
using MailSenderApi.Models;

namespace MailSenderApi.Controllers
{
    [ApiController]
    public class MailSenderController : ControllerBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="mailSenderService"></param>
        /// <param name="emailConfiguration"></param>
        public MailSenderController(IMailSenderService mailSenderService, IEmailConfiguration emailConfiguration)
        {
            MailSenderService = mailSenderService;
            _emailConfiguration = emailConfiguration;
        }
        /// <summary>
        /// Email Configuration
        /// </summary>
        public IEmailConfiguration _emailConfiguration;
        /// <summary>
        /// Interface IMailSenderService
        /// </summary>
        public IMailSenderService MailSenderService { get; }

        /// <summary>
        /// Wysyłanie Maila (Wypełniasz wszystko)
        /// </summary>
        [AllowAnonymous]
        [HttpPost("api/v1/MailSenderPost")]
        public IActionResult Send([FromBody] EmailMessage emailMessage)
        {
            var result = MailSenderService.MailSend(emailMessage);
            return Ok(result);
        }
    }
}
