using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Product;
using AnniesPastryShop.Core.Models.Review;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class ProductService:IProductService
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext _context)
        {
            context =_context;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync()
        {
            var categories = await context.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
            return categories;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var products= await context.Products
                .AsNoTracking()
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public Task<CategoryViewModel?> GetCategoryByIdAsync(int id)
        {
            var category = context.Categories
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .FirstOrDefaultAsync();
            return category;
        }

        public async Task<ProductViewModel?> GetProductByIdAsync(int id)
        {
            var product = await context.Products
                .AsNoTracking()
                .Where(p => p.Id == id)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    Reviews = p.Reviews.Select(r => new ReviewViewModel
                    {
                        Id = r.Id,
                        Rating = r.Rating,
                        Comment = r.Comment,
                        CreatedAt = r.CreatedOn,
                        ProductName = r.Product.Name,
                        CustomerName = r.Customer.FullName
                    }).ToList(),
                })
                .FirstOrDefaultAsync();
            return product;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsByCategoryAsync(int categoryId)
        {
            var products=await context.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsOrderedAlphabeticallyAsync()
        {
            var products = await context.Products
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsOrderedByCreationDateDescendingAsync()
        {
            var products = await context.Products
                .AsNoTracking()
                .OrderByDescending(p => p.Id)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsOrderedByPriceAscendingAsync()
        {
            var products = await context.Products
                .AsNoTracking()
                .OrderBy(p => p.Price)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsOrderedByPriceDescendingAsync()
        {
            var products =await context.Products
                .AsNoTracking()
                .OrderByDescending(p => p.Price)
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<ProductViewModel?>> SearchProductsAsync(string searchTerm)
        {
            var products = await context.Products
                .AsNoTracking()
                .Where(p => p.Name.Contains(searchTerm))
                .Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
            return products;
        }
    }
}
