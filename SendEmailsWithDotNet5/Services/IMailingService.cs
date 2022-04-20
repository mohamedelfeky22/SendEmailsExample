
using Microsoft.AspNetCore.Http;
using SendEmailsWithDotNet5.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
 
namespace SendEmailsWithDotNet5.Services
{
    public interface IMailingService
    {
        Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachments = null);

        Task SendWelcomeEmailAsync(WelcomeEmailtDto dto);
    }
}
