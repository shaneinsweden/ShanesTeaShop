using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class Category
    {
        public Category()
        {

        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool CaffieneFree { get; set; }
        public virtual List<Tea> Teas { get; set; }
    }
}
