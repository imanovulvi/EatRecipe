using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public class PageMapping:EntityBaseMapping<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(15);
            base.Configure(builder);
        }
    }
}
