using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using CookingRecipe.Web.Infrastructures.Domain.Models;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Instructions
{
    public class IndexViewModel
    {
        public Page<Instruction> Instructions { get; set; }

    }
}

