using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys.EntitysBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.EatRecipe.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EatRecipe.Repostarys
{
    public class WriteRepostary<T> : IWriteRepostary<T> where T : EntityBase
    {
        private readonly EatRecipeContext _context;
        public WriteRepostary(EatRecipeContext context)
        {
            _context = context;

        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T item)
        {
            EntityEntry entityEntry = await Table.AddAsync(item);
            return entityEntry.State == EntityState.Added;

        }

        public bool Remove(T item)
        {
            EntityEntry entityEntry = Table.Remove(item);
            return entityEntry.State == EntityState.Added;
        }

        public bool RemoveRange(List<T> items)
        {
          Table.RemoveRange(items);
            return true;
        }

        public async Task SaveChangeAsync()
        =>  await _context.SaveChangesAsync();
  

        public bool Update(T item)
        {
            EntityEntry entityEntry = Table.Update(item);
            return entityEntry.State==EntityState.Modified;
        }

        public bool UpdateRange(List<T> items)
        {
            Table.UpdateRange(items);
            return true;
        }
    }
}
