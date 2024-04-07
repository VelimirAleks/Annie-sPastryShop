using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class ReviewController:BaseController
    {
        private readonly IReviewService reviewService;
        private readonly ICustomerService customerService;
        private readonly IProductService productService;

        public ReviewController(IReviewService _reviewService, ICustomerService _customerService, IProductService _productService)
        {
            reviewService = _reviewService;
            customerService = _customerService;
            productService = _productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var reviews = await reviewService.GetAllReviewsAsync();
            return View(reviews);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task <IActionResult> Details(int id)
        {
            var review = await reviewService.GetReviewByIdAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Sort(string sortType)
        {
            IEnumerable<ReviewViewModel> sortedReviews;

            switch (sortType)
            {
                case "dateAscending":
                    sortedReviews = await reviewService.GetReviewOrderByDateAscending();
                    break;
                case "dateDescending":
                    sortedReviews = await reviewService.GetReviewOrderByDateDescending();
                    break;
                case "ratingAscending":
                    sortedReviews = await reviewService.GetReviewOrderByRatingAscending();
                    break;
                case "ratingDescending":
                    sortedReviews = await reviewService.GetReviewOrderByRatingDescending();
                    break;
                default:
                    sortedReviews = await reviewService.GetAllReviewsAsync();
                    break;
            }

            ViewBag.SelectedSortType = sortType;

            return View("All", sortedReviews);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var review = new ReviewViewModel();
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id,ReviewViewModel review)
        {
            bool isCustomer = await IsCustomerAsync(customerService);
            if (!isCustomer)
            {
                return Unauthorized();
            }
            string userId = GetUserId();
            review.ProductId = id;

            var product = await productService.GetProductByIdAsync(review.ProductId);
            if (product==null)
            {
                ModelState.AddModelError(string.Empty, "Product not found.");
                return View(review);
            }
            await reviewService.CreateReviewAsync(review,userId);
            return RedirectToAction(nameof(All));
        }
    }
}
