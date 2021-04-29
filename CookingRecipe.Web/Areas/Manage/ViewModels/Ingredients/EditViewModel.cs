using System;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Ingredients
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }

    }
}

