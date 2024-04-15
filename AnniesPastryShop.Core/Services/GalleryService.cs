using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Gallery;
using AnniesPastryShop.Core.Models.Gallery;
using AnniesPastryShop.Infrastructure.Data.Models;
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

        public async Task AddImageAsync(GalleryAdminViewModel model)
        {
            var image = new Picture
            {
                ImageUrl = model.ImageUrl,
                ProductId = model.ProductId,
            };
            context.Pictures.Add(image);
            await context.SaveChangesAsync();
        }

        public async  Task DeleteImageAsync(int id)
        {
            var image = await context.Pictures.FindAsync(id);
            if (image == null)
            {
                throw new InvalidOperationException("Image not found.");
            }
            context.Pictures.Remove(image);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GalleryAdminViewModel>> GetAllImagesAsync()
        {
            var images = await context.Pictures
                .AsNoTracking()
                .Select(p => new GalleryAdminViewModel
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    ProductId = p.ProductId,
                })
                .ToListAsync();
            return images;
        }

        public async Task<GalleryAdminViewModel?> GetImageByIdAsync(int id)
        {
            var image = await context.Pictures
                .AsNoTracking()
                .Where(p => p.Id == id)
                .Select(p => new GalleryAdminViewModel
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    ProductId = p.ProductId,
                })
                .FirstOrDefaultAsync();
            return image;
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
