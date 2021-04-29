using CookingRecipe.Web.Areas.Manage.ViewModels.Instructions;
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
    public class InstructionsController : Controller
    {
        private readonly DefaultDbContext _context;
        public InstructionsController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("/manage/instructions/index")]
        [HttpGet, Route("/manage/instructions")]
        public IActionResult Index(int pageSize = 10, int pageIndex = 1, string keyword = "")
        {
            Page<Instruction> result = new Page<Instruction>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Instruction> instrucQuery = (IQueryable<Instruction>)this._context.Instructions.Include(c => c.Cooking).OrderBy(c => c.CreatedAt);
            if (string.IsNullOrEmpty(keyword) == false)
            {
                instrucQuery = instrucQuery.Where(p => p.Step.Contains(keyword)
                                            );
            }


            long queryCount = instrucQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Instruction> instructions = instrucQuery.ToList();

            result.Items = instructions.Skip(skip).Take((int)pageSize).ToList();
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
                Instructions = result
            });
        }


        [HttpPost, Route("/manage/instructions/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var cooking = this._context.Cookings.FirstOrDefault(c => c.Id == model.CookingId);

            if (cooking != null)
            {

                var instruc = new Instruction
                {
                    Id = Guid.NewGuid(),
                    CookingId = model.CookingId,
                    Step = model.Step,
                    Time = model.Time.ToString(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                instruc.TotalStep = TotalStep(instruc.Id);
                _context.Instructions.Add(instruc);

                cooking.InstructionId = instruc.Id;
                _context.Cookings.Update(cooking);

                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        public int TotalStep(Guid? instructionId)
        {
            var instruction = this._context.Instructions.Where(i => i.Id == instructionId).Select(i => i.Step).ToList();

            var total = instruction.Count();

            return total;
        }

        [HttpGet, Route("/manage/instructions/details/{Id}")]
        public IActionResult Detail(Guid? Id)
        {
            var instruction = this._context.Instructions.Include(i => i.Cooking).FirstOrDefault(i => i.Id == Id);
            if (instruction == null)
            {
                return RedirectPermanent("Index");
            }

            return View(instruction);

        }


        [HttpGet, Route("/manage/instructions/delete/{Id}")]
        public IActionResult Delete(Guid? Id)
        {
            var instruction = this._context.Instructions.FirstOrDefault(c => c.Id == Id);

            if (instruction != null)
            {
                this._context.Instructions.Remove(instruction);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet, Route("/manage/instructions/edit/{Id}")]
        public IActionResult Edit(Guid? Id)
        {
            var instruction = this._context.Instructions.FirstOrDefault(c => c.Id == Id);
            if (instruction == null)
            {
                return RedirectToAction("Index");
            }

            if (instruction != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = instruction.Id,
                        Step = instruction.Step,
                        Time = Convert.ToDateTime(instruction.Time),

                    }
                );
            }

            return View();
        }

        [HttpPost, Route("/manage/instructions/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var instruction = this._context.Instructions.FirstOrDefault(c => c.Id == model.Id);

            if (instruction != null)
            {

                instruction.Step = model.Step;
                instruction.Time = model.Time.ToString();

                this._context.Instructions.Update(instruction);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}