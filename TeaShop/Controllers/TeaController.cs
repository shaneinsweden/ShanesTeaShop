using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Models;
using TeaShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeaShop.Controllers
{
    public class TeaController : Controller
    {
        //// GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}


        private readonly ITeaRepository _teaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TeaController(ICategoryRepository categoryRepository, ITeaRepository teaRepository)
        {
            _teaRepository = teaRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Tea> teas;
            string currentyCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                teas = _teaRepository.Teas.OrderBy(t => t.TeaId);
                currentyCategory = "All Teas";
            }
            else
            {
                var tempCategory  = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category);
                teas = _teaRepository.Teas
                    .Where(t => t.Category.CategoryId == tempCategory.CategoryId)
                    .OrderBy(t => t.TeaId);
                
                currentyCategory = tempCategory.CategoryName;
            }

            return View(new TeasListViewModel
            {
                Teas = teas,
                CurrentCategory = currentyCategory
            });
            //ViewModels.TeasListViewModel teasListViewModel = new ViewModels.TeasListViewModel();
            //teasListViewModel.Teas = _teaRepository.Teas;
            //teasListViewModel.CurrentCategory = "Green Tea";

            //return View(teasListViewModel);
        }
    }
}
