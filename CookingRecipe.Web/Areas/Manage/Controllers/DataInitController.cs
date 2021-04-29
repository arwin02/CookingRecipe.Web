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