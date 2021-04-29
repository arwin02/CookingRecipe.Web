using System;
using System.Collections.Generic;

namespace CookingRecipe.Web.Infrastructures.Domain.Models
{
    public class Cooking : BaseModel
    {
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Instruction> Instructions { get; set; }

        public Guid? InstructionId { get; set; }

        public Guid? IngredientId { get; set; }
    }
}
