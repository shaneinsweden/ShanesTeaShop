using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tea> TeasOfTheWeek { get; set; }

    }
    
}
