using CookingRecipe.Web.Areas.Manage.ViewModels.Cookings;
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
    public class CookingsController : Controller
    {
        private readonly DefaultDbContext _context;
        public CookingsController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("/manage/cookings/index")]
        [HttpGet, Route("/manage/cookings")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "")
        {
            Page<Cooking> result = new Page<Cooking>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Cooking> cookQuery = (IQueryable<Cooking>)this._context.Cookings.Include(c => c.Ingredients).Include(c => c.Ingredients);
            if (string.IsNullOrEmpty(keyword) == false)
            {
                cookQuery = cookQuery.Where(p => p.Name.Contains(keyword)
                                            );
            }


            long queryCount = cookQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Cooking> pricings = cookQuery.ToList();

            result.Items = pricings.Skip(skip).Take((int)pageSize).ToList();
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

                Cookings = result
            });
        }

        [HttpGet, Route("/manage/cookings/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("/manage/cookings/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var cook = this._context.Cookings.FirstOrDefault(c => c.Name == model.Name);
            if (cook == null)
            {
                var cooking = new Cooking
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,

                };

                this._context.Cookings.Add(cooking);
                this._context.SaveChanges();

            }
            else
            {
                ModelState.AddModelError("", "Name has already used");
                return View(model);
            }


            return RedirectPermanent("Index");
        }

        [HttpGet, Route("/manage/cookings/details/{Id}")]
        public IActionResult Detail(Guid? Id)
        {

            if (Id == null)
            {
                return NotFound();
            }
            var cook = this._context.Cookings.Include(c => c.Ingredients).Include(c => c.Instructions).FirstOrDefault(c => c.Id == Id);

            if (cook == null)
            {
                return NotFound();
            }

            return View(cook);
        }


        [HttpGet, Route("/manage/cookings/delete/{Id}")]
        public IActionResult Delete(Guid? Id)
        {
            var cook = this._context.Cookings.FirstOrDefault(c => c.Id == Id);

            if (cook != null)
            {
                this._context.Cookings.Remove(cook);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("/manage/cookings/edit/{Id}")]
        public IActionResult Edit(Guid? Id)
        {


            var cook = this._context.Cookings.FirstOrDefault(c => c.Id == Id);
            if (cook == null)
            {
                return RedirectToAction("Index");
            }
            if (cook != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = cook.Id,
                        Name = cook.Name,

                    }
                );
            }

            return View();


        }

        [HttpPost, Route("/manage/cookings/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var cook = this._context.Cookings.FirstOrDefault(c => c.Id == model.Id);

            if (cook != null)
            {

                cook.Name = model.Name;

                this._context.Cookings.Update(cook);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }

    }
}