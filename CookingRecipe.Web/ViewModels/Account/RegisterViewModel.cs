using CookingRecipe.Web.Infrastructures.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CookingRecipe.Web.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Firstname length can't be more than 50.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Lastname length can't be more than 50.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Surname length can't be more than 50.")]
        public string SurName { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Phone-number length can't be more than 11.")]
        [Display(Name = "Phone Number ")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public Gender Gender { get; set; }
    }
}
