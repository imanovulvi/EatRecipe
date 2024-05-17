using Domen.EatRecipe.Entitys.EntitysBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.EatRecipe.Entitys
{
    public  class Page:EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
