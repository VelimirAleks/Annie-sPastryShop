﻿using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly IReviewService reviewService;

        public ProductController(IProductService _productService, IReviewService _reviewService)
        {
            productService = _productService;
            reviewService = _reviewService;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var products = await productService.GetAllProductsAsync();
            var categories = await productService.GetAllCategoriesAsync();

            ViewBag.Categories = categories;

            return View(products);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var products = await productService.SearchProductsAsync(searchTerm);

            var categories = await productService.GetAllCategoriesAsync();
            ViewBag.Categories = categories;

            return View("All",products);


        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Filter (string filterType)
        {
            IEnumerable<ProductViewModel> filteredProducts;

            switch (filterType)
            {
                case "priceAscending":
                    filteredProducts = await productService.GetProductsOrderedByPriceAscendingAsync();
                    break;
                case "priceDescending":
                    filteredProducts = await productService.GetProductsOrderedByPriceDescendingAsync();
                    break;
                case "creationDateDescending":
                    filteredProducts = await productService.GetProductsOrderedByCreationDateDescendingAsync();
                    break;
                case "alphabetical":
                    filteredProducts = await productService.GetProductsOrderedAlphabeticallyAsync();
                    break;
                default:
                    filteredProducts = await productService.GetAllProductsAsync();
                    break;
            }
            
            ViewBag.SelectedFilterType = filterType;

            var categories = await productService.GetAllCategoriesAsync();
            ViewBag.Categories = categories;

            return View("All", filteredProducts);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> FilterByCategory(int categoryId)
        {
            IEnumerable<ProductViewModel?> filteredProducts;

            if (categoryId != 0)
            {
                filteredProducts = await productService.GetProductsByCategoryAsync(categoryId);
            }
            else
            {
                filteredProducts = await productService.GetAllProductsAsync();
            }

            var categories = await productService.GetAllCategoriesAsync();
            ViewBag.Categories = categories;

            ViewBag.SelectedCategoryId = categoryId;
            ViewBag.SelectedCategoryName = categoryId != 0 ? categories.FirstOrDefault(c => c.Id == categoryId)?.Name : "All Categories";

            return View("All", filteredProducts);
        }
    }
}
