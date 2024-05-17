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
    public class MenuWriteRepostary : WriteRepostary<Menu>, IMenuWriteRepostary
    {
        public MenuWriteRepostary(EatRecipeContext context) : base(context)
        {
        }
    }
}
