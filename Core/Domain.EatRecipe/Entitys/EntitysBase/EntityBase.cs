using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys.EntitysBase
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Aktiv { get; set; }
        public bool IsDeleted { get; set; }
    }
}
