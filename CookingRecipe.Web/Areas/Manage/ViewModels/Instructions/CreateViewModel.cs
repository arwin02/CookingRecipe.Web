using System;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Instructions
{
    public class CreateViewModel
    {
        public Guid? CookingId { get; set; }

        public string Step { get; set; }

        public int TotalStep { get; set; }

        public DateTime Time { get; set; }

    }
}
