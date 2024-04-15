using AnniesPastryShop.Core.Models.AdminModels.Category;

namespace AnniesPastryShop.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryAdminViewModel>> GetAllCategoriesAsync();
        Task <CategoryAdminViewModel?> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CategoryAdminViewModel model);
        Task DeleteCategoryAsync(int id);
    }
}
