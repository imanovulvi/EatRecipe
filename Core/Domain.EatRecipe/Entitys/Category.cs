using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys
{
    public class Category:EntityBase
    {
        public string Name { get; set; }
       
        public List<MealRecipe> MealRecipes { get; set; }
    }
}
