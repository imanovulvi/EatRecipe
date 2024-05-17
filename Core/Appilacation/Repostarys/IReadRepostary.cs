using Domen.EatRecipe.Entitys.EntitysBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appilacation.EatRecipe.Repostarys
{
    public interface IReadRepostary<T> : IRepostary<T> where T : EntityBase
    {
        IQueryable<T> GetAll(bool tracker=true);
        Task<T> GetByIdAsync(string id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracker = true);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expression, bool tracker = true);
    }
}
