using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using CookingRecipe.Web.Infrastructures.Domain.Models;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients
{
    public class IndexViewModel
    {
        public Page<Ingredient> Ingredients { get; set; }
    }
}
