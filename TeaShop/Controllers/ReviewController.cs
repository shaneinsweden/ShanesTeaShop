using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeaShop.Data;
using TeaShop.Models;
using TeaShop.ViewModels;

namespace TeaShop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(UserManager<IdentityUser> userManager, IReviewRepository reviewRepository)
        {
            _userManager = userManager;
            _reviewRepository = reviewRepository;
        }
        public IActionResult AddReview(int teaId)
        {
            return View(new AddReviewViewModel
            {
                TeaId = teaId,
                ReviewedBy = User.Identity.Name
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewViewModel addReviewModel)
        {
            if (!ModelState.IsValid)
                return View(addReviewModel);

            var user = await _userManager.FindByNameAsync(addReviewModel.ReviewedBy);

            if (user != null)
            {
                TeaReview review = new TeaReview
                {
                    ReviewedBy = addReviewModel.ReviewedBy,
                    TeaId = addReviewModel.TeaId,
                    ReviewedOn = DateTime.Now,
                    ReviewTitle = addReviewModel.ReviewTitle,
                    ReviewText = addReviewModel.ReviewText
                };
                var result = _reviewRepository.AddReview(review);

                if (result)
                {
                        return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "User not found can't create review");
            return View(addReviewModel);
        }
    }
}