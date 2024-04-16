using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await productService.GetAllProductsAdminAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id )
        {
            var product = await productService.GetProductByIdAdminAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var product = new ProductAdminViewModel();
            var categories = await productService.GetAllCategoriesAdminAsync();
            product.Categories = categories.ToList();
            return View(product);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(ProductAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateProductAsync(model);
                return RedirectToAction(nameof(All));
            }
            var categories = await productService.GetAllCategoriesAdminAsync();
            model.Categories = categories.ToList();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await productService.GetProductByIdAdminAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var categories = await productService.GetAllCategoriesAdminAsync();
            product.Categories = categories.ToList();
            return View(product);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task <IActionResult> Edit (int id, ProductAdminViewModel model)
        {
            if (id!=model.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                await productService.UpdateProductAsync(id, model);
                return RedirectToAction(nameof(All));
            }
            var categories = await productService.GetAllCategoriesAdminAsync();
            model.Categories = categories.ToList();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await productService.GetProductByIdAdminAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }
                await productService.DeleteProductAsync(id);
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
