using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public class MenuMapping:EntityBaseMapping<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(15);
            builder.Property(x => x.Url).HasMaxLength(30);
            base.Configure(builder);  
           // builder.Property(x => x.DownMenu).IsRequired(false);
        }
    }
}
