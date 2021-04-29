using System;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = DateTime.UtcNow;

        }

        public Guid? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }



    }
}
