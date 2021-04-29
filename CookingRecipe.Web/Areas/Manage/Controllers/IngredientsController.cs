using CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients;
using CookingRecipe.Web.Infrastructures.Domain.Data;
using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using CookingRecipe.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingRecipe.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class IngredientsController : Controller
    {
        private readonly DefaultDbContext _context;
        public IngredientsController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("/manage/ingredients/index")]
        [HttpGet, Route("/manage/ingredients")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "")
        {
            Page<Ingredient> result = new Page<Ingredient>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Ingredient> ingreQuery = (IQueryable<Ingredient>)this._context.Ingredients.Include(c => c.Cooking);
            if (string.IsNullOrEmpty(keyword) == false)
            {
                ingreQuery = ingreQuery.Where(p => p.Name.Contains(keyword)
                                            );
            }


            long queryCount = ingreQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Ingredient> ingredients = ingreQuery.ToList();

            result.Items = ingredients.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            return View(new IndexViewModel
            {

                Ingredients = result
            });
        }


        [HttpPost, Route("/manage/ingredients/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var cooking = this._context.Cookings.FirstOrDefault(c => c.Id == model.CookingId);

            if (cooking != null)
            {

                var ingre = new Ingredient
                {
                    Id = Guid.NewGuid(),
                    CookingId = model.CookingId,
                    Name = model.Name,
                    Quantity = model.Quantity,
                    UnitCost = model.UnitCost,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                _context.Ingredients.Add(ingre);

                cooking.IngredientId = ingre.Id;
                _context.Cookings.Update(cooking);

                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpGet, Route("/manage/ingredients/details/{Id}")]
        public IActionResult Detail(Guid? Id)
        {

            var ingredient = this._context.Ingredients.Include(i => i.Cooking).FirstOrDefault(i => i.Id == Id);
            if (ingredient == null)
            {
                return RedirectPermanent("Index");
            }

            return View(ingredient);
        }


        [HttpGet, Route("/manage/ingredients/delete/{Id}")]
        public IActionResult Delete(Guid? Id)
        {
            var ingredient = this._context.Ingredients.FirstOrDefault(c => c.Id == Id);

            if (ingredient != null)
            {
                this._context.Ingredients.Remove(ingredient);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("/manage/ingredients/edit/{Id}")]
        public IActionResult Edit(Guid? Id)
        {
            var ingredient = this._context.Ingredients.FirstOrDefault(c => c.Id == Id);
            if (ingredient == null)
            {
                return RedirectToAction("Index");
            }
            if (ingredient != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = ingredient.Id,
                        Name = ingredient.Name,
                        Quantity = ingredient.Quantity,
                        UnitCost = ingredient.UnitCost,
                    }
                );
            }

            return View();
        }

        [HttpPost, Route("/manage/ingredients/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var ingredient = this._context.Ingredients.FirstOrDefault(c => c.Id == model.Id);

            if (ingredient != null)
            {

                ingredient.Name = model.Name;
                ingredient.Quantity = model.Quantity;
                ingredient.UnitCost = model.UnitCost;

                this._context.Ingredients.Update(ingredient);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }

    }
}