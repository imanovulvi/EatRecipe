using Domen.EatRecipe.Entitys.EntitysBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilacation.EatRecipe.Repostarys
{
    public interface IRepostary<T> where T : EntityBase
    {
        public DbSet<T> Table { get; }
    }
}
