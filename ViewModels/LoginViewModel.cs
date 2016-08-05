using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Rememeber Me?")]
        public bool RememeberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}