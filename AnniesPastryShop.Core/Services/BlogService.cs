using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Blog;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext context;

        public BlogService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task AddBlogAsync(BlogViewModel model)
        {
            var blog = new Blog
            {
                Title = model.Title,
                Content = model.Content,
                ImageUrl = model.ImageUrl,
                CreatedAt = model.CreatedAt
            };
            context.Blogs.Add(blog);
            await context.SaveChangesAsync();
        }

        public async Task DeleteBlogAsync(int id)
        {
            var blog = await context.Blogs.FindAsync(id);

            if (blog == null)
            {
                throw new InvalidOperationException("Blog not found");
            }
            context.Blogs.Remove(blog);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync()
        {
            var blogs=await context.Blogs
                .AsNoTracking()
                .OrderByDescending(b=>b.CreatedAt)
                .Select(b=>new BlogViewModel
                {
                    Id=b.Id,
                    Title=b.Title,
                    Content=b.Content,
                    ImageUrl=b.ImageUrl,
                    CreatedAt=b.CreatedAt
                })
                .ToListAsync();
            return blogs;
        }

        public async Task<BlogViewModel?> GetBlogByIdAsync(int id)
        {
            var blog = await context.Blogs
                .Where(b => b.Id == id)
                .Select(b => new BlogViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Content = b.Content,
                    ImageUrl = b.ImageUrl,
                    CreatedAt = b.CreatedAt
                })
                .FirstOrDefaultAsync();
            return blog;
        }

        public async Task UpdateBlogAsync(BlogViewModel model)
        {
            var blog = await context.Blogs.FindAsync(model.Id);

            if (blog == null)
            {
                throw new InvalidOperationException("Blog not found");
            }

            blog.Title = model.Title;
            blog.Content = model.Content;
            blog.ImageUrl = model.ImageUrl;
            blog.CreatedAt = model.CreatedAt;

            await context.SaveChangesAsync();
        }
    }
}
