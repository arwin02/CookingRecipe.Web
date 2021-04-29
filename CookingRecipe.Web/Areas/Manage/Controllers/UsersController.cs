using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingRecipe.Web.Infrastructures.Domain.Data;
using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CookingRecipe.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;
        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet,Route("manage/users/logout/{userId}")]
        public IActionResult Logout(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if(user != null)
            {
                WebUser.UserId = null;
            }
            return Redirect("~/home/index");
        }
    }
}