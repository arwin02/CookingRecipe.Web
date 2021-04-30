using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipe.Web.Infrastructures.Domain.Helpers
{
    public static class WebUser
    {
        public static Guid? UserId { get; set; }

        public static string UserName { get; set; }

        public static void GetUser(Guid? Id, string userName)
        {
                    
            UserId = Id;
            UserName = userName;
        }

    }
}
