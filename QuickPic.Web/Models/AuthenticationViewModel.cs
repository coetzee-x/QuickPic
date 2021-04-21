using System.ComponentModel.DataAnnotations;

namespace QuickPic.Web.Models
{
    public class AuthenticationViewModel
    {
        [Required(ErrorMessage = "Please enter a Username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password { get; set; }
    }
}
