using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class Tea
    {
        public int TeaId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsTeaOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public bool InTeaBags { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
