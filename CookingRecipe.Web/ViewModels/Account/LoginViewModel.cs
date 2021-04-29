using System.ComponentModel.DataAnnotations;

namespace CookingRecipe.Web.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
