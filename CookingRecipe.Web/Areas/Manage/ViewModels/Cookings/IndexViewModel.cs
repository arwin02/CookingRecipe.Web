using CookingRecipe.Web.Infrastructures.Domain.Helpers;
using CookingRecipe.Web.Infrastructures.Domain.Models;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Cookings
{
    public class IndexViewModel
    {
        public Page<Cooking> Cookings { get; set; }
    }
}
