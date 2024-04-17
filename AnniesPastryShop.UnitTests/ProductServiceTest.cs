using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Product;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class ProductServiceTest
    {
        private ApplicationDbContext context;
        private IProductService productService;

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            var category1 = new Category { Name = "Category 1" };
            var category2 = new Category { Name = "Category 2" };

            await context.Categories.AddRangeAsync(category1, category2);

            var product1 = new Product { Name = "Product 1", Price = 10.0m, CategoryId = 1 };
            var product2 = new Product { Name = "Product 2", Price = 20.0m, CategoryId = 2 };

            await context.Products.AddRangeAsync(product1, product2);

            await context.SaveChangesAsync();

            productService = new ProductService(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetAllCategoriesAsync_ShouldReturnAllCategories()
        {
            // Act
            var categories = await productService.GetAllCategoriesAsync();

            // Assert
            Assert.IsNotNull(categories);
            Assert.AreEqual(2, categories.Count());
        }

        [Test]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            // Act
            var products = await productService.GetAllProductsAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(2, products.Count());
        }

        [Test]
        public async Task GetProductByIdAsync_ShouldReturnProduct()
        {
            // Arrange
            int existingProductId = 1;

            // Act
            var product = await productService.GetProductByIdAsync(existingProductId);

            // Assert
            Assert.IsNotNull(product);
            Assert.AreEqual(existingProductId, product.Id);
        }

        [Test]
        public async Task GetProductByIdAsync_ShouldReturnNullForNonExistentProductId()
        {
            // Arrange
            int nonExistentProductId = 100;

            // Act
            var product = await productService.GetProductByIdAsync(nonExistentProductId);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public async Task GetProductsByCategoryAsync_ShouldReturnProductsForGivenCategory()
        {
            // Arrange
            int categoryId = 1;

            // Act
            var products = await productService.GetProductsByCategoryAsync(categoryId);

            // Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(1, products.Count());
        }

        [Test]
        public async Task GetProductsOrderedAlphabeticallyAsync_ShouldReturnProductsOrderedAlphabetically()
        {
            // Act
            var products = await productService.GetProductsOrderedAlphabeticallyAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Select(p => p.Name).SequenceEqual(products.OrderBy(p => p.Name).Select(p => p.Name)));
        }

        [Test]
        public async Task GetProductsOrderedByPriceAscendingAsync_ShouldReturnProductsOrderedByPriceAscending()
        {
            // Act
            var products = await productService.GetProductsOrderedByPriceAscendingAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Select(p => p.Price).SequenceEqual(products.OrderBy(p => p.Price).Select(p => p.Price)));
        }

        [Test]
        public async Task GetProductsOrderedByPriceDescendingAsync_ShouldReturnProductsOrderedByPriceDescending()
        {
            // Act
            var products = await productService.GetProductsOrderedByPriceDescendingAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Select(p => p.Price).SequenceEqual(products.OrderByDescending(p => p.Price).Select(p => p.Price)));
        }

        [Test]
        public async Task GetProductsOrderedByCreationDateDescendingAsync_ShouldReturnProductsOrderedByCreationDateDescending()
        {
            // Act
            var products = await productService.GetProductsOrderedByCreationDateDescendingAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Select(p => p.Id).SequenceEqual(products.OrderByDescending(p => p.Id).Select(p => p.Id)));
        }

        [Test]
        public async Task SearchProductsAsync_ShouldReturnMatchingProducts()
        {
            // Arrange
            string searchTerm = "Product";

            // Act
            var products = await productService.SearchProductsAsync(searchTerm);

            // Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(2, products.Count());
        }

        [Test]
        public async Task GetAllProductsAdminAsync_ShouldReturnAllProductsForAdmin()
        {
            // Act
            var products = await productService.GetAllProductsAdminAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.AreEqual(2, products.Count());
        }

        [Test]
        public async Task GetProductByIdAdminAsync_ShouldReturnProductForAdmin()
        {
            // Arrange
            int existingProductId = 1;

            // Act
            var product = await productService.GetProductByIdAdminAsync(existingProductId);

            // Assert
            Assert.IsNotNull(product);
            Assert.AreEqual(existingProductId, product.Id);
        }

        [Test]
        public async Task GetProductByIdAdminAsync_ShouldReturnNullForNonExistentProductIdForAdmin()
        {
            // Arrange
            int nonExistentProductId = 100;

            // Act
            var product = await productService.GetProductByIdAdminAsync(nonExistentProductId);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public async Task GetAllCategoriesAdminAsync_ShouldReturnAllCategoriesForAdmin()
        {
            // Act
            var categories = await productService.GetAllCategoriesAdminAsync();

            // Assert
            Assert.IsNotNull(categories);
            Assert.AreEqual(2, categories.Count());
        }

        [Test]
        public async Task CreateProductAsync_ShouldAddProduct()
        {
            // Arrange
            var model = new ProductAdminViewModel { Name = "New Product", Price = 15.0m, CategoryId = 1 };

            // Act
            await productService.CreateProductAsync(model);

            // Assert
            var products = await context.Products.ToListAsync();
            Assert.AreEqual(3, products.Count);
        }

        [Test]
        public async Task UpdateProductAsync_ShouldUpdateProduct()
        {
            // Arrange
            int existingProductId = 1;
            var model = new ProductAdminViewModel { Name = "Updated Product", Price = 25.0m, CategoryId = 2 };

            // Act
            await productService.UpdateProductAsync(existingProductId, model);

            // Assert
            var product = await context.Products.FindAsync(existingProductId);
            Assert.IsNotNull(product);
            Assert.AreEqual(model.Name, product.Name);
            Assert.AreEqual(model.Price, product.Price);
            Assert.AreEqual(model.CategoryId, product.CategoryId);
        }

        [Test]
        public async Task DeleteProductAsync_ShouldDeleteProduct()
        {
            // Arrange
            int existingProductId = 1;

            // Act
            await productService.DeleteProductAsync(existingProductId);

            // Assert
            var products = await context.Products.ToListAsync();
            Assert.AreEqual(1, products.Count);
        }

        [Test]
        public async Task DeleteProductAsync_ShouldThrowExceptionForNonExistentProduct()
        {
            // Arrange
            int nonExistentProductId = 100;

            // Act & Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await productService.DeleteProductAsync(nonExistentProductId));
        }

        [Test]
        public async Task SearchProductsAsync_ShouldReturnEmptyListForNonMatchingSearchTerm()
        {
            // Arrange
            string searchTerm = "Non-existent Product";

            // Act
            var products = await productService.SearchProductsAsync(searchTerm);

            // Assert
            Assert.IsNotNull(products);
            Assert.IsEmpty(products);
        }

        [Test]
        public async Task UpdateProductAsync_ShouldThrowExceptionForNonExistentProduct()
        {
            // Arrange
            int nonExistentProductId = 100;
            var model = new ProductAdminViewModel { Name = "Updated Product", Price = 25.0m, CategoryId = 2 };

            // Act & Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await productService.UpdateProductAsync(nonExistentProductId, model));
        }

        [Test]
        public async Task GetAllProductsAdminAsync_ShouldReturnEmptyListForNoProducts()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var products = await productService.GetAllProductsAdminAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsEmpty(products);
        }

        [Test]
        public async Task GetAllProductsAsync_ShouldReturnEmptyListForNoProducts()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var products = await productService.GetAllProductsAsync();

            // Assert
            Assert.IsNotNull(products);
            Assert.IsEmpty(products);
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnCategory()
        {
            // Arrange
            int existingCategoryId = 1;

            // Act
            var category = await productService.GetCategoryByIdAsync(existingCategoryId);

            // Assert
            Assert.IsNotNull(category);
            Assert.AreEqual(existingCategoryId, category.Id);
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnNullForNonExistentCategoryId()
        {
            // Arrange
            int nonExistentCategoryId = 100;

            // Act
            var category = await productService.GetCategoryByIdAsync(nonExistentCategoryId);

            // Assert
            Assert.IsNull(category);
        }

        [Test]
        public async Task GetAllCategoriesAsync_ShouldReturnEmptyListForNoCategories()
        {
            // Arrange
            await context.Categories.ForEachAsync(c => context.Categories.Remove(c));
            await context.SaveChangesAsync();

            // Act
            var categories = await productService.GetAllCategoriesAsync();

            // Assert
            Assert.IsNotNull(categories);
            Assert.IsEmpty(categories);
        }
    }
}
