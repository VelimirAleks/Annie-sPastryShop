using AnniesPastryShop.Core.Contracts;
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
            return View("All",products);
        }
    }
}
