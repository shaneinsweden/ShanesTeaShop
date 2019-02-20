using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaShop.Models;
using TeaShop.ViewModels;

namespace TeaShop.Controllers
{
    public class HomeController: Controller
    {
        private readonly ITeaRepository _teaRepository;

        public HomeController(ITeaRepository teaRepository)
        {
            _teaRepository = teaRepository;
        }


        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TeasOfTheWeek = _teaRepository.TeasOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
