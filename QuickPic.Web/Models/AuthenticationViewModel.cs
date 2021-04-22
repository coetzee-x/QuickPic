using System.ComponentModel.DataAnnotations;

namespace QuickPic.Web.Models
{
    public class AuthenticationViewModel
    {
        [Required(ErrorMessage = "Please enter your username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }
    }
}
