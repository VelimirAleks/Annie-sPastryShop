using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Gallery;
using AnniesPastryShop.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    public class GalleryController : AdminBaseController
    {
        private readonly IGalleryService galleryService;

        public GalleryController(IGalleryService _galleryService)
        {
            galleryService = _galleryService;
        }

        [HttpGet]
        public async Task <IActionResult> All()
        {
            var images = await galleryService.GetAllImagesAsync();
            return View(images);
        }

        [HttpGet]
        public async Task <IActionResult> Details(int id)
        {
            var image = await galleryService.GetImageByIdAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            return View(image);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new GalleryAdminViewModel();
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(GalleryAdminViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await galleryService.AddImageAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }

                await galleryService.DeleteImageAsync(id);
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
