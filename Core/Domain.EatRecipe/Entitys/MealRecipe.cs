using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys
{
    public class MealRecipe:EntityBase
    {
        public string MealName { get; set; }
        public string Recipe { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
