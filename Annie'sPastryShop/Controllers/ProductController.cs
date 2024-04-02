using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Product;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
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
            //tdo: add cart
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
            IEnumerable<ProductViewModel> filteredProducts;

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

            // Set the selected category ID and name
            ViewBag.SelectedCategoryId = categoryId;
            ViewBag.SelectedCategoryName = categoryId != 0 ? categories.FirstOrDefault(c => c.Id == categoryId)?.Name : "All Categories";

            return View("All", filteredProducts);
        }
    }
}
