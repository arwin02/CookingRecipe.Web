using System.Collections.Generic;

namespace CookingRecipe.Web.Infrastructures.Domain.Helpers
{
    public class Page<T>
    {
        public List<T> Items { get; set; }

        public long QueryCount { get; set; }

        public long PageCount { get; set; }

        public long PageSize { get; set; }

        public long PageIndex { get; set; }

        public string Keyword { get; set; }
    }
}

