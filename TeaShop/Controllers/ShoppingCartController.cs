using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TeaShop.Models;
using TeaShop.ViewModels;

namespace TeaShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITeaRepository _teaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITeaRepository teaRepository, ShoppingCart shoppingCart)
        {
            _teaRepository = teaRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int teaId)
        {
            var selectedTea = _teaRepository.Teas.FirstOrDefault(p => p.TeaId == teaId);

            if (selectedTea != null)
            {
                _shoppingCart.AddToCart(selectedTea, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int teaId)
        {
            var selectedTea = _teaRepository.Teas.FirstOrDefault(p => p.TeaId == teaId);

            if (selectedTea != null)
            {
                _shoppingCart.RemoveFromCart(selectedTea);
            }
            return RedirectToAction("Index");
        }
    }
}