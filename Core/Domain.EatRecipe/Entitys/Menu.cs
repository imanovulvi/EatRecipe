using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys
{
    public class Menu:EntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Row { get; set; }
        public int? DownMenu { get; set; }

    }
}
