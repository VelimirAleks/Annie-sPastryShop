using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Category;
using AnniesPastryShop.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpGet]
        public async Task <IActionResult> All()
        {
            var categories = await categoryService.GetAllCategoriesAsync();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CategoryAdminViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await categoryService.CreateCategoryAsync(model);
            return RedirectToAction(nameof(All));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }

                await categoryService.DeleteCategoryAsync(id);
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
