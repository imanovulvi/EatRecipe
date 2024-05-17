using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys
{
    public  class Comment:EntityBase
    {
        public string MealComment { get; set; }

        public Guid MealRecipeId { get; set; }
        public MealRecipe MealRecipe { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
