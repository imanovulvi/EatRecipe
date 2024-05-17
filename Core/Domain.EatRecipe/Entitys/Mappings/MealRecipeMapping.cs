using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public class MealRecipeMapping:EntityBaseMapping<MealRecipe>
    {
        public override void Configure(EntityTypeBuilder<MealRecipe> builder)
        {
            builder.Property(x => x.MealName).HasMaxLength(15);
            base.Configure(builder);
        }
    }
}
