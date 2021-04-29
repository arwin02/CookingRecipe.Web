using System;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class Ingredient : BaseModel
    {
        public Guid? CookingId { get; set; }

        public virtual Cooking Cooking { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }

    }
}