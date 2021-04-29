using System;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class Instruction : BaseModel
    {
        public Guid? CookingId { get; set; }

        public virtual Cooking Cooking { get; set; }

        public string Step { get; set; }

        public int TotalStep { get; set; }

        public string Time { get; set; }


    }
}
