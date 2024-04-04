using AnniesPastryShop.Core.Models.Product;

namespace AnniesPastryShop.Core.Models.Gallery
{
    public class GalleryViewModel
    {
        public IEnumerable<GalleryItemViewModel> Images { get; set; } = null!;
        public PaginationViewModel Pagination { get; set; }=null!;
    }
}
