using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingRecipe.Web.Infrastructures.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace CookingRecipe.Web.Areas.Manage.Controllers
{
    public class DataInitController : Controller
    {
        private readonly DefaultDbContext _context;
        public DataInitController(DefaultDbContext context)
        {
            _context = context;
        }


        [HttpGet,Route("/manage/data-init/execute")]
        public IActionResult DataInitializer()
        {

            #region Users(15 Records)
            if (this._context.Users.Count() < 1)
            {

                //1
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("24551e81-1887-4288-89f4-7d4d433120fa"),
                            FirstName = "Cd",
                            LastName = "Casupanan",
                            FullName = "CD Casupanan",
                            Surname = "cdbcasupanan",
                            EmailAddress = "cdbcasupanan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //2
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("62fb0427-e259-4874-b904-5f5d4d6c4b9e"),
                            FirstName = "Xyrille",
                            LastName = "Mamalateo",
                            FullName = "Xyrille Mamalateo",
                            Surname = "XyAnn",
                            EmailAddress = "Xyrille@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //3
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("1e5a951c-ae94-42dd-b01b-62460c556408"),
                            FirstName = "Joy",
                            LastName = "Flores",
                            FullName = "Joy Flores",
                            Surname = "JoyJoy",
                            EmailAddress = "Joy@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //4
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("7f5c0d24-0d38-48b4-a5b7-bd6b5e3bbe22"),
                            FirstName = "Arwin",
                            LastName = "Tolentino",
                            FullName = "Arwin Tolentino",
                            Surname = "Arwin02",
                            EmailAddress = "Arwin@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });

                //5
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("385fd1f1-82a6-4eb8-826f-89d8873bcdb1"),
                            FirstName = "Allan",
                            LastName = "Chavez",
                            FullName = "Allan Chavez",
                            Surname = "Allan",
                            EmailAddress = "Allan@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                           
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //6
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("a09573f5-62b9-4548-b153-4d2eac8ef29e"),
                            FirstName = "Luisa",
                            LastName = "Reyes",
                            FullName = "Luisa Kathrina Reyes",
                            Surname = "LuisaKath",
                            EmailAddress = "Luisa@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                          
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //7
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("984797ad-c1c8-4d36-a527-80e41dd6592e"),
                            FirstName = "Larich",
                            LastName = "Morales",
                            FullName = "Larich Morales",
                            Surname = "Larich01",
                            EmailAddress = "larich@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                           
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //8
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("e5037a48-8f1e-4811-8d51-72cef2238ce3"),
                            FirstName = "Jane",
                            LastName = "Ticar",
                            FullName = "Jane Ticar",
                            Surname = "Jane02",
                            EmailAddress = "jane@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                         
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //9
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("f178c3cb-db20-436d-a2e2-36d34772dba8"),
                            FirstName = "Wesley",
                            LastName = "SA",
                            FullName = "Wesley SA",
                            Surname = "Wesley03",
                            EmailAddress = "Wesley@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                           
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //10
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("e358f015-6a5f-4a20-8718-513a23fef0fd"),
                            FirstName = "Reniel ",
                            LastName = "David",
                            FullName = "Reniel David",
                            Surname = "Reniel04",
                            EmailAddress = "Reniel@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                           
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //11
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("b36f7f45-1b05-4905-9a66-8183809ff8c8"),
                            FirstName = "Jhon Cedric",
                            LastName = "Romano",
                            FullName = "Jhon Cedric Romano",
                            Surname = "Jhon06",
                            EmailAddress = "Jhon@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //12
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("41494e0e-cde7-46de-897c-a8369fba5ba9"),
                            FirstName = "Elmo",
                            LastName = "Cahilo",
                            FullName = "Elmo Cahilo",
                            Surname = "Elmo07",
                            EmailAddress = "Elmo@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                          
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //13
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("83349c71-bbe2-4c2d-a9a5-3d555a00305c"),
                            FirstName = "Jake Renzo",
                            LastName = "Carlos",
                            FullName = "Jake Renzo Carlos",
                            Surname = "Jake08",
                            EmailAddress = "Jake@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                         
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //14
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("634e0321-5f02-458b-a2b8-7bd07bc86672"),
                            FirstName = "Christian",
                            LastName = "Cruz",
                            FullName = "Christian Cruz",
                            Surname = "Christian09",
                            EmailAddress = "Christian@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Male,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });


                //15
                this._context.Users.Add(
                        new Infrastructures.Domain.Models.User()
                        {

                            Id = Guid.Parse("9c304fab-d362-483c-be13-885381731ba8"),
                            FirstName = "MAMA",
                            LastName = "KO",
                            FullName = "MAMA KO",
                            Surname = "MAMA00",
                            EmailAddress = "mama@gmail.com",
                            Password = "123456789",
                            PhoneNumber = "123456789",
                            
                            LoginRetries = 0,
                            Gender = Infrastructures.Domain.Enums.Gender.Female,
                            LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                            Address = "Dinalupihan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,




                        });
            }
            #endregion

            #region UserRole(15 Records)
            if (this._context.UserRoles.Count() < 1)
            {

                //1
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {

                            Id = Guid.Parse("880e8918-8e8f-488b-9ffc-bd06285881dc"),
                            UserId = Guid.Parse("24551e81-1887-4288-89f4-7d4d433120fa"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User
                        });

                //2
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {


                            Id = Guid.Parse("f5cd2ec2-8f70-4c06-917b-188a245e61ff"),
                            UserId = Guid.Parse("62fb0427-e259-4874-b904-5f5d4d6c4b9e"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User




                        });

                //3
             
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {

                            Id = Guid.Parse("8436f69d-200e-4ef9-81bd-46038f11d644"),
                            UserId = Guid.Parse("1e5a951c-ae94-42dd-b01b-62460c556408"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User

                        });

                //4
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {


                             Id = Guid.Parse("87abcfc2-60f1-4632-9e06-bc363d57b88b"),
                             UserId = Guid.Parse("7f5c0d24-0d38-48b4-a5b7-bd6b5e3bbe22"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User

                         });

                //5
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {


                             Id = Guid.Parse("9cc6bada-f43f-47e2-b8e6-462f97f0a9ed"),
                             UserId = Guid.Parse("385fd1f1-82a6-4eb8-826f-89d8873bcdb1"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User

                         });


                //6
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {

                             Id = Guid.Parse("bd436a4b-dac7-43c7-bd5d-1a434da9a99c"),
                             UserId = Guid.Parse("a09573f5-62b9-4548-b153-4d2eac8ef29e"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User

                         });


                //7
                this._context.UserRoles.Add(
                         new Infrastructures.Domain.Models.UserRole()
                         {





                             Id = Guid.Parse("ec54e10c-21eb-4509-8d13-23edcc6b494d"),
                             UserId = Guid.Parse("984797ad-c1c8-4d36-a527-80e41dd6592e"),
                             CreatedAt = DateTime.UtcNow,
                             UpdatedAt = DateTime.UtcNow,
                             Role = Infrastructures.Domain.Enums.Role.User


                         });


                //8
                this._context.UserRoles.Add(
                        new Infrastructures.Domain.Models.UserRole()
                        {



                            Id = Guid.Parse("82400738-a126-4341-a8bc-dd38409174d8"),
                            UserId = Guid.Parse("e5037a48-8f1e-4811-8d51-72cef2238ce3"),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Role = Infrastructures.Domain.Enums.Role.User
                        });


                //9
                this._context.UserRoles.Add(
                      new Infrastructures.Domain.Models.UserRole()
                      {



                          Id = Guid.Parse("b95ac303-abac-43cd-801d-02bd480c231b"),
                          UserId = Guid.Parse("f178c3cb-db20-436d-a2e2-36d34772dba8"),
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Role = Infrastructures.Domain.Enums.Role.User


                      });


                //10
                this._context.UserRoles.Add(
                     new Infrastructures.Domain.Models.UserRole()
                     {

                         Id = Guid.Parse("f72a76a3-bd79-4c36-a454-2dfc8077cdc1"),
                         UserId = Guid.Parse("e358f015-6a5f-4a20-8718-513a23fef0fd"),
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Role = Infrastructures.Domain.Enums.Role.User

                     });


                //11
                this._context.UserRoles.Add(
                   new Infrastructures.Domain.Models.UserRole()
                   {

                       Id = Guid.Parse("5acf73f4-d64e-4a58-9762-f42067d43fa6"),
                       UserId = Guid.Parse("b36f7f45-1b05-4905-9a66-8183809ff8c8"),
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Role = Infrastructures.Domain.Enums.Role.User

                   });


                //12
                this._context.UserRoles.Add(
                   new Infrastructures.Domain.Models.UserRole()
                   {

                       Id = Guid.Parse("3ec2072d-af85-41e4-a69e-48068d0ba8b0"),
                       UserId = Guid.Parse("41494e0e-cde7-46de-897c-a8369fba5ba9"),
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Role = Infrastructures.Domain.Enums.Role.User


                   });


                //13
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {


                        Id = Guid.Parse("5d56eb33-d5d2-4bdc-9a06-7e07f1b32f30"),
                        UserId = Guid.Parse("83349c71-bbe2-4c2d-a9a5-3d555a00305c"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User



                    });


                //14
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {



                        Id = Guid.Parse("dc49b9f8-254d-4bca-82db-a4aff22287c8"),
                        UserId = Guid.Parse("634e0321-5f02-458b-a2b8-7bd07bc86672"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User

                    });


                //15
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {


                        Id = Guid.Parse("faf2ed2d-370e-48cc-aa57-cdee56d72fdb"),
                        UserId = Guid.Parse("9c304fab-d362-483c-be13-885381731ba8"),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Role = Infrastructures.Domain.Enums.Role.User
                    });
            }
            #endregion

            #region Cooking(15 Records)
            if (this._context.Cookings.Count() < 1)
            {

                //1
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                            Name = "Adobong Baboy",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                          
                        });

                //2
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("765d31e6-e9cb-4f11-a9be-4b38518db304"),
                            Name = "Tinolang Manok",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });


                //3
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("04a8beb5-d3fc-4cab-9f2e-78ee68fb2555"),
                            Name = "Sinigang Isda",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });


                //4
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("daf66e9e-f51c-41f6-bde7-196022b00bdb"),
                            Name = "Sinigang Baboy",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });


                //5
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("5d15a152-4a5f-4c49-925c-92ff2cabac4e"),
                            Name = "Afritada",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //6
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("49d33a16-2cc2-41af-8a35-568f08bcd904"),
                            Name = "Dinuguan",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //7
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("b2fdf377-576b-4f61-822f-c847cc0b7515"),
                            Name = "Sisig",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //8
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("f17f738d-376c-403e-a503-fc8837dbddfc"),
                            Name = "Daing",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //9
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("16aa5e0c-886e-4807-b1de-13942600ce23"),
                            Name = "Bicol Express",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //10
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("1ff74660-f576-4fbf-8691-fe8e28358a64"),
                            Name = "Chop Suey",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //11
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("b6e97a13-c953-46b3-afe2-4d709e722e3b"),
                            Name = "Pork Bistek",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //12
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("6cc73fbb-39a4-4df2-9390-9e678409d30e"),
                            Name = "Ginataang Langka",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //13
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("6b7a50e7-a90e-4be6-a869-c33084c02bfe"),
                            Name = "Beef Bulalo",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //14
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("96405bf3-5174-4596-9fb1-b45225cee1c9"),
                            Name = "Achara",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



                //15
                this._context.Cookings.Add(
                        new Infrastructures.Domain.Models.Cooking()
                        {

                            Id = Guid.Parse("0339bd26-b895-4471-8052-ab2ffe29be98"),
                            Name = "Paksiw Isda",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        });



            }



            #endregion


            #region Employees(15 Records)
            if (this._context.Ingredients.Count() < 1)
            {
                //1
                //Adobong Baboy Ingredients List

                  this._context.Ingredients.Add(
                  new Infrastructures.Domain.Models.Ingredient()
                  {

                      Id = Guid.Parse("ca25c528-627b-4b80-9b91-02d06afc3c55"),
                      CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                      Name = "Chicken Thights",
                      Quantity = 1,
                      UnitCost = 50,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,




                  });

                    this._context.Ingredients.Add(
                new Infrastructures.Domain.Models.Ingredient()
                {

                    Id = Guid.Parse("0b483fb6-f736-4baa-ab3c-d8f2a1e163c7"),
                    CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                    Name = "Vegetable Oil",
                    Quantity = 1,
                    UnitCost = 35,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,




                });

                this._context.Ingredients.Add(
                   new Infrastructures.Domain.Models.Ingredient()
                    {

                        Id = Guid.Parse("711b6d5a-19a3-44c8-81d9-8cb361fc01d3"),
                        CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                        Name = "Onion",
                        Quantity = 2,
                        UnitCost = 10,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,

                    });

                    this._context.Ingredients.Add(
                    new Infrastructures.Domain.Models.Ingredient()
                    {

                        Id = Guid.Parse("eeb8ba33-56c5-401a-967e-d3a9721dcd2a"),
                        CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                        Name = "Garlic",
                        Quantity = 5,
                        UnitCost = 10,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,




                    });

                    this._context.Ingredients.Add(
                     new Infrastructures.Domain.Models.Ingredient()
                     {

                         Id = Guid.Parse("3ff17f0c-cc61-4080-b521-b3aebca7cb4d"),
                         CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                         Name = "Sugar",
                         Quantity = 2,
                         UnitCost = 15,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,




                     });


                     this._context.Ingredients.Add(
                     new Infrastructures.Domain.Models.Ingredient()
                     {

                         Id = Guid.Parse("e489d772-baa5-4e5b-ae96-60e49b0ce3f2"),
                         CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                         Name = "Vinegar",
                         Quantity = 1,
                         UnitCost = 7,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,




                     });

                    this._context.Ingredients.Add(
                   new Infrastructures.Domain.Models.Ingredient()
                   {

                       Id = Guid.Parse("48ba0fda-bceb-44eb-92c0-80b7460e7339"),
                       CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                       Name = "Soy sauce",
                       Quantity = 1,
                       UnitCost = 7,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,




                   });

                  this._context.Ingredients.Add(
                 new Infrastructures.Domain.Models.Ingredient()
                 {

                     Id = Guid.Parse("e1145858-0470-413d-99bc-a2507365f52f"),
                     CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                     Name = "Peppercorns",
                     Quantity = 1,
                     UnitCost = 5,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,




                 });

                  this._context.Ingredients.Add(
                  new Infrastructures.Domain.Models.Ingredient()
                  {

                      Id = Guid.Parse("8c63a87f-f380-48fb-860f-c77e82ee338c"),
                      CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                      Name = "Bay leaves",
                      Quantity = 4,
                      UnitCost = 3,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,




                  });


                  this._context.Ingredients.Add(
                  new Infrastructures.Domain.Models.Ingredient()
                  {

                      Id = Guid.Parse("646c08f6-fd0e-4eb2-8b97-21039f8f87eb"),
                      CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                      Name = "Green onion",
                      Quantity = 1,
                      UnitCost = 10,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,




                  });



            }
            #endregion


            #region Employees(15 Records)
            if (this._context.Instructions.Count() < 1)
            {
                //1
                //Adobong Baboy Ingredients List

                this._context.Instructions.Add(
                new Infrastructures.Domain.Models.Instruction()
                {

                    Id = Guid.Parse("e2152e67-b875-4a9d-a5ee-662b73ea6caf"),
                    CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                    Step = "1st step : Chop and clean the ingredients and wash it",
                    Time = "",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,




                });


                this._context.Instructions.Add(
               new Infrastructures.Domain.Models.Instruction()
               {

                   Id = Guid.Parse("8740c040-9f5e-4bd8-ae72-d2a6f634ab99"),
                   CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                   Step = "2nd step : Prepare the ingredients",
                   Time = "",
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,




               });

                this._context.Instructions.Add(
                new Infrastructures.Domain.Models.Instruction()
                {

                    Id = Guid.Parse("434ee824-29f6-4679-b43b-7f70e9f00f2a"),
                    CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                    Step = "3rd Step : Now the is ingredients is ready we proceed to cook the dish!",
                    Time = "",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,




                });

                this._context.Instructions.Add(
               new Infrastructures.Domain.Models.Instruction()
               {

                   Id = Guid.Parse("9f4c3bb7-1cf5-4cbe-9ebb-d83555f88426"),
                   CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                   Step = "4th Step : Light up the stove and  heat the pan just slight ",
                   Time = "",
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,




               });

                this._context.Instructions.Add(
            new Infrastructures.Domain.Models.Instruction()
            {

                Id = Guid.Parse("93466927-2a0b-4594-8f6a-76d4504e5b84"),
                CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                Step = "5th Step : Put the vegetable oil and heat it just slight and put the onions and garlic first.",
                Time = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,




            });

                        this._context.Instructions.Add(
                new Infrastructures.Domain.Models.Instruction()
                {

                    Id = Guid.Parse("65a015df-929d-4bda-bc7f-dbd78b3860b5"),
                    CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                    Step = "6th Step : When the onions and garlics are smells good or the color is brown then just put the chicken thights and cook it for 10mns to 15mns",
                    Time = "",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,




                });


                    this._context.Instructions.Add(
              new Infrastructures.Domain.Models.Instruction()
              {

                  Id = Guid.Parse("d8bca664-dafe-45e5-b234-724c80810dec"),
                  CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
                  Step = "7th Step : Add the soy sauce and vinegar then add peppercorns, bay leaves and green onion then add a half water of cup",
                  Time = "",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow,




              });


                this._context.Instructions.Add(
          new Infrastructures.Domain.Models.Instruction()
          {

              Id = Guid.Parse("63db5747-986e-4136-b81f-afa50230d24f"),
              CookingId = Guid.Parse("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"),
              Step = "8th Step : Wait for 10 to 15mns to cook the adobo and then check your dish if the dish is yummy else just add more soy sauce and salt base on the your taste of food and were done! Thank you for following our cooking recipe.",
              Time = "",
              CreatedAt = DateTime.UtcNow,
              UpdatedAt = DateTime.UtcNow,




          });



            }
            #endregion


            this._context.SaveChanges();
            return Ok("Ok");
        }
    }
}