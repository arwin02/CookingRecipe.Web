using CookingRecipe.Web.Infrastructures.Domain.Data;
using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using CookingRecipe.Web.Infrastructures.Domain.Models;
using CookingRecipe.Web.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CookingRecipe.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly DefaultDbContext _context;
        public AccountController(DefaultDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet, Route("/account/register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost, Route("/account/register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Registration form cannot be empty. Please fill up the form");
                return View(model);
            }
                

            if (model.FirstName == model.LastName)
            {
                ModelState.AddModelError("LastName",
                                         "The last name cannot be the same as the first name.");
            }
            else if(model.Address == model.EmailAddress)
            {
                ModelState.AddModelError("EmailAddress", "The Email-Address cannot be the same as the Address");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Surname = model.SurName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                Gender = model.Gender,
                EmailAddress = model.EmailAddress,
                Password = model.Password,
                LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,

            };

            _context.UserRoles.Add(new UserRole
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Role = Infrastructures.Domain.Enums.Role.User,

            });


            this._context.Users.Add(user);
            this._context.SaveChanges();

            return RedirectToAction("Login");
        }


        [HttpGet, Route("~/account/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, Route("~/account/login")]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Email & Password cannot be empty! Please valid your account");
                return View(model);
            }
          

            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress == model.EmailAddress && u.Password == model.Password);
            

            if (user != null)
            {
                var userRole = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);

                if (userRole.Role == Infrastructures.Domain.Enums.Role.User && user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Active)
                {
                    user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;
                    WebUser.GetUser(user.Id);
                    this._context.Users.Update(user);
                    this._context.SaveChanges();
                }

                return Redirect("~/manage/cookings/index");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Email and password. Please create your account first");
                return View(model);
            }
              
        }
    }
}