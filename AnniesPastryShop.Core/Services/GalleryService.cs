using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Gallery;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly ApplicationDbContext context;

        public GalleryService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<GalleryItemViewModel>> GetImagesAsync(int page, int pageSize)
        {
            return await context.Pictures
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new GalleryItemViewModel
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    ProductId = p.ProductId,
                })
                .ToListAsync();
        }
        public async Task<int> GetTotalImageCountAsync()
        {
            return await context.Pictures.CountAsync();
        }
    }
}
