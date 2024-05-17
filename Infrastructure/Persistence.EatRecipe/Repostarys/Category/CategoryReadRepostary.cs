using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys;
using Persistence.EatRecipe.Context;

namespace Persistence.EatRecipe.Repostarys
{
    public class CategoryReadRepostary : ReadRepostary<Category>, ICategoryReadRepostary
    {
        public CategoryReadRepostary(EatRecipeContext context) : base(context)
        {
        }
    }
}
