using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.Core.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext context;

        public BlogService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public Task AddBlogAsync(BlogViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogViewModel> GetBlogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogAsync(BlogViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
