using CookingRecipe.Web.Infrastructures.Domain.Enums;
using System;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class UserRole : BaseModel
    {

        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
