using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RegisterViewModel
    {
        [Required, MaxLengthAttribute(256)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), CompareAttribute(nameof(RegisterViewModel.Password))]
        public string ConfirmPassword { get; set; }
    }
}