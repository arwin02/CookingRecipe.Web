using System;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients
{
    public class CreateViewModel
    {
        public Guid? CookingId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }

    }
}
