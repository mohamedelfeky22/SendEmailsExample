using System.ComponentModel.DataAnnotations;

namespace SendEmailsWithDotNet5.Dtos
{
    public class WelcomeEmailtDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
