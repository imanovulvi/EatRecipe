using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public class CommentMapping :EntityBaseMapping<Comment>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Comment> builder)
        {

            builder.Property(x => x.MealComment).HasMaxLength(150);

            base.Configure(builder);
        }
    }
}
