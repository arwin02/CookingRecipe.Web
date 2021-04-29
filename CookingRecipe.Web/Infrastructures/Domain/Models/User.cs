using CookingRecipe.Web.Infrastructures.Domain.Enums;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class User : BaseModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }


        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public Gender Gender { get; set; }
    }
}
