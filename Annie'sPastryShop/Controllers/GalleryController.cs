using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Gallery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryService galleryService;

        public GalleryController(IGalleryService _galleryService, IProductService _productService)
        {
            galleryService = _galleryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Images(int page = 1, int pageSize = 12)
        {
            var images = await galleryService.GetImagesAsync(page, pageSize);
            var totalImageCount = await galleryService.GetTotalImageCountAsync();
            var pagination = new PaginationViewModel(totalImageCount, pageSize, page);

            var viewModel = new GalleryViewModel
            {
                Images = images,
                Pagination = pagination
            };

            return View(viewModel);
        }
    }
}
