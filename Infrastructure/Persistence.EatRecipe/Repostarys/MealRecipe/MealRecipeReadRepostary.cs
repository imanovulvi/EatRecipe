using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
using Persistence.EatRecipe.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EatRecipe.Repostarys
{
    public class MealRecipeReadRepostary : ReadRepostary<MealRecipe>, IMealRecipeReadRepostary
    {
        public MealRecipeReadRepostary(EatRecipeContext context) : base(context)
        {
        }
    }
}
