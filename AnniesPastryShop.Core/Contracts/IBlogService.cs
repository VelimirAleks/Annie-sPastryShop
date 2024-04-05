using AnniesPastryShop.Core.Models.Blog;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogViewModel>> GetAllBlogsAsync();
        Task<BlogViewModel?> GetBlogByIdAsync(int id);
        Task AddBlogAsync(BlogViewModel model);
        Task UpdateBlogAsync(BlogViewModel model);
        Task DeleteBlogAsync(int id);
    }
}
