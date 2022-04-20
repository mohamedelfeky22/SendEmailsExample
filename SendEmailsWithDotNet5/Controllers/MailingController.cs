using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmailsWithDotNet5.Services;
using SendEmailsWithDotNet5.Dtos;
using System.Threading.Tasks;

namespace SendEmailsWithDotNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailingController : ControllerBase
    {
        private readonly IMailingService _mailingService;

        public MailingController(IMailingService mailingService)
        {
            _mailingService = mailingService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequestDto dto)
        {
            await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, dto.Attachments);
            return Ok();
        }

        [HttpPost("send-welcoome-email")]
        public async Task<IActionResult> SendWelcome(WelcomeEmailtDto dto)
        {
            await _mailingService.SendWelcomeEmailAsync(dto);
            return Ok();
        }

    }
}
