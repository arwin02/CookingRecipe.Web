using BCrypt;
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
                Password = BCryptHelper.HashPassword(model.Password, BCryptHelper.GenerateSalt(8)),
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


            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress == model.EmailAddress);


            if (user != null)
            {
                var userRole = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
                if (BCrypt.BCryptHelper.CheckPassword(model.Password, user.Password))
                {
                    if (user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.InActive)
                    {

                        ModelState.AddModelError("", "Your account is In-active. Please verify your account.");
                        return View(model);
                    }
                    else if (user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.AccountLocked)
                    {
                        ModelState.AddModelError("", "Your account has been locked!");
                        return View(model);
                    }
                    else if (user.LoginRetries == 3 && user.Password != model.Password)
                    {
                        user.LoginRetries = user.LoginRetries + 1;
                        user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.AccountLocked;
                        this._context.Users.Update(user);
                        this._context.SaveChanges();

                        ModelState.AddModelError("", "Your login is failed 4 times. Your account has been locked!.");
                        return View(model);
                    }

                    else if (user.LoginRetries == 3 && user.Password == model.Password)
                    {
                        user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.NeedToChangePassword;
                        this._context.Users.Update(user);
                        this._context.SaveChanges();

                        ModelState.AddModelError("", "Your login is failed more than " + user.LoginRetries + " times. your account need to change password if you failed one more the account has been locked!.");
                        return View(model);
                    }

                    else if (user.Password != model.Password)
                    {

                        user.LoginRetries = user.LoginRetries + 1;
                        this._context.Users.Update(user);
                        this._context.SaveChanges();


                        ModelState.AddModelError("", "Invalid password. Login failed :" + user.LoginRetries);
                        return View(model);
                    }
                    else if (userRole.Role == Infrastructures.Domain.Enums.Role.User && user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Active && user.Password == model.Password)
                    {
                        user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;
                        user.LoginRetries = 0;
                        WebUser.GetUser(user.Id, user.Surname);
                        this._context.Users.Update(user);
                        this._context.SaveChanges();

                        return Redirect("~/manage/authors/index");
                    }

                }

                ModelState.AddModelError("", "Invalid Login.");
                return View();
            }

            return View(model);
        }
    }
}