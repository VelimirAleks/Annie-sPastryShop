using AnniesPastryShop.Core.Models.AdminModels.Gallery;
using AnniesPastryShop.Core.Models.Gallery;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IGalleryService
    {
        // For pagination
        Task<IEnumerable<GalleryItemViewModel>> GetImagesAsync(int page,int pageSize);
        Task<int> GetTotalImageCountAsync();

        //Admin methods
        Task<IEnumerable<GalleryAdminViewModel>> GetAllImagesAsync();
        Task<GalleryAdminViewModel?> GetImageByIdAsync(int id);
        Task AddImageAsync(GalleryAdminViewModel model);
        Task DeleteImageAsync(int id);
    }
}
