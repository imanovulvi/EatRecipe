using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilacation.EatRecipe.Repostarys
{
    public interface IWriteRepostary<T>:IRepostary<T> where T : EntityBase
    {
        Task<bool> AddAsync(T item);
        bool Remove(T item);
        bool RemoveRange(List<T> items);
        bool Update(T item);
        bool UpdateRange(List<T> items);
        Task SaveChangeAsync();
    }
}
