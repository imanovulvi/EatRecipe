using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.EatRecipe.Entitys;
using Domen.EatRecipe.Entitys.EntitysBase;

namespace Domen.EatRecipe.Entitys
{
    public class MenuDownUp: EntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Row { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
