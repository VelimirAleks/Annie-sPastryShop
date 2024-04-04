using AnniesPastryShop.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync();
        Task<BlogViewModel> GetBlogByIdAsync(int id);
        Task AddBlogAsync(BlogViewModel model);
        Task UpdateBlogAsync(BlogViewModel model);
        Task DeleteBlogAsync(int id);
    }
}
