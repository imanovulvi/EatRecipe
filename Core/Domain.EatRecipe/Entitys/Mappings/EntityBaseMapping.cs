using Domen.EatRecipe.Entitys.EntitysBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.Mappings
{
    public abstract class EntityBaseMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("newid()");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired(true);
            builder.Property(x=>x.CreateDate).HasDefaultValueSql("getdate()").IsRequired(true);
            builder.Property(x => x.Aktiv).HasDefaultValue(true).IsRequired(true);

        }
    }
}
