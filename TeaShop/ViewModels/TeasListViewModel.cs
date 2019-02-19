using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.ViewModels
{
    public class TeasListViewModel
    {
        public IEnumerable<Tea> Teas { get; set; }

        public string CurrentCategory { get; set; }
    }
}
