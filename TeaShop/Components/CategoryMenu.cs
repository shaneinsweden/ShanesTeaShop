using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(c => c.CategoryName);

            return View(categories);
        }
    }
}
