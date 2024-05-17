using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public class UserMapping:EntityBaseMapping<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x=>x.Name).HasMaxLength(15);
            builder.Property(x => x.Surname).HasMaxLength(15);
            builder.Property(x => x.Mail).HasMaxLength(15);
            builder.Property(x => x.Password).HasMaxLength(15);
            builder.Property(x => x.Phone).HasMaxLength(15);
            base.Configure(builder);
        }
    }
}
