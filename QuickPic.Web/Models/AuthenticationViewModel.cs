using System.ComponentModel.DataAnnotations;

namespace QuickPic.Web.Models
{
    public class AuthenticationViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
