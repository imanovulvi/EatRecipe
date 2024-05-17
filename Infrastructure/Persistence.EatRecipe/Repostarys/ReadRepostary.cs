using Appilacation.EatRecipe.Repostarys;
using Domen.EatRecipe.Entitys.EntitysBase;
using Microsoft.EntityFrameworkCore;
using Persistence.EatRecipe.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EatRecipe.Repostarys
{
    public class ReadRepostary<T> : IReadRepostary<T> where T : EntityBase
    {
        private readonly EatRecipeContext _context;
        public ReadRepostary(EatRecipeContext context)
        {
            _context = context;
            
        }


        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracker = true)
        {
            if (!tracker)
                return Table.AsNoTracking();
            return Table;
        }

        public  async Task<T> GetByIdAsync(string id)
        => await Table.FindAsync(Guid.Parse(id));


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracker = true)
        {
            if (!tracker)
                return await Table.AsTracking().SingleOrDefaultAsync(expression);

            return await Table.SingleOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracker = true)
        {
            if (!tracker)
                return  Table.AsNoTracking().Where(expression);

            return Table.AsNoTracking().Where(expression);
        }
    }
}
