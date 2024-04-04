using AnniesPastryShop.Core.Models.Gallery;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IGalleryService
    {
        Task<IEnumerable<GalleryItemViewModel>> GetImagesAsync(int page,int pageSize);
        Task<int> GetTotalImageCountAsync();
    }
}
