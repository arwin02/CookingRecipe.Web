using System;

namespace CookingRecipe.Web.Areas.Manage.ViewModels.Instructions
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string Step { get; set; }

        public DateTime Time { get; set; }
    }
}

