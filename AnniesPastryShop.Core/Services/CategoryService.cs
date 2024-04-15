using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Category;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext context;

        public CategoryService(ApplicationDbContext _context)
        { 
            context = _context;
        }
        public async  Task CreateCategoryAsync(CategoryAdminViewModel model)
        {
            var category = new Category
            {
                Name = model.Name
            };
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null)
            {
                throw new InvalidOperationException("Category not found.");
            }
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryAdminViewModel>> GetAllCategoriesAsync()
        {
            var categories = await context.Categories
                .AsNoTracking()
                .Select(c => new CategoryAdminViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
            return categories;
        }

        public async Task<CategoryAdminViewModel?> GetCategoryByIdAsync(int id)
        {
            var category = await context.Categories
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => new CategoryAdminViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .FirstOrDefaultAsync();
            return category;
        }
    }
}
