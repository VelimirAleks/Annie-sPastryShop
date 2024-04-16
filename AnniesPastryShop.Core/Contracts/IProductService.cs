using AnniesPastryShop.Core.Models.AdminModels.Category;
using AnniesPastryShop.Core.Models.AdminModels.Product;
using AnniesPastryShop.Core.Models.Product;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel?> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductViewModel?>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<CategoryViewModel>> GetAllCategoriesAsync();
        Task<CategoryViewModel?> GetCategoryByIdAsync(int id);
        Task<IEnumerable<ProductViewModel?>> SearchProductsAsync(string searchTerm);
        Task<IEnumerable<ProductViewModel>> GetProductsOrderedByPriceAscendingAsync();
        Task<IEnumerable<ProductViewModel>> GetProductsOrderedByPriceDescendingAsync();
        Task<IEnumerable<ProductViewModel>> GetProductsOrderedByCreationDateDescendingAsync();
        Task<IEnumerable<ProductViewModel>> GetProductsOrderedAlphabeticallyAsync();

        // Admin methods
        Task<IEnumerable<ProductAdminViewModel>> GetAllProductsAdminAsync();
        Task<ProductAdminViewModel?> GetProductByIdAdminAsync(int id);
        Task<IEnumerable<CategoryAdminViewModel>> GetAllCategoriesAdminAsync();
        Task CreateProductAsync(ProductAdminViewModel model);
        Task UpdateProductAsync(int id,ProductAdminViewModel model);
        Task DeleteProductAsync(int id);
    }
}
