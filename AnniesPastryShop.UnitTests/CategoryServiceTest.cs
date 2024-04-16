using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Category;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class CategoryServiceTest
    {
        private ApplicationDbContext context;
        private ICategoryService categoryService;

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);
            await context.Database.EnsureCreatedAsync();

            categoryService = new CategoryService(context);

            await context.Categories.AddRangeAsync(new List<Category>
            {
                new Category { Name = "Category 1" },
                new Category { Name = "Category 2" },
                new Category { Name = "Category 3" }
            });
            await context.SaveChangesAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateCategoryAsync_ShouldCreateCategory()
        {
            // Arrange
            var categoryModel = new CategoryAdminViewModel
            {
                Name = "New Category"
            };

            // Act
            await categoryService.CreateCategoryAsync(categoryModel);

            // Assert
            var addedCategory = await context.Categories.FirstOrDefaultAsync(c => c.Name == "New Category");
            Assert.IsNotNull(addedCategory);
        }

        [Test]
        public async Task GetAllCategoriesAsync_ShouldReturnAllCategories()
        {
            // Act
            var categories = await categoryService.GetAllCategoriesAsync();

            // Assert
            Assert.AreEqual(6, categories.Count());
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnCategoryWithGivenId()
        {
            // Arrange
            int categoryIdToRetrieve = 1;

            // Act
            var category = await categoryService.GetCategoryByIdAsync(categoryIdToRetrieve);

            // Assert
            Assert.IsNotNull(category);
            Assert.AreEqual(categoryIdToRetrieve, category.Id);
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnNullIfCategoryNotFound()
        {
            // Arrange
            int nonExistentCategoryId = 100;

            // Act
            var category = await categoryService.GetCategoryByIdAsync(nonExistentCategoryId);

            // Assert
            Assert.IsNull(category);
        }

        [Test]
        public async Task DeleteCategoryAsync_ShouldDeleteCategoryWithGivenId()
        {
            // Arrange
            int categoryIdToDelete = 1;

            // Act
            await categoryService.DeleteCategoryAsync(categoryIdToDelete);

            // Assert
            var deletedCategory = await context.Categories.FindAsync(categoryIdToDelete);
            Assert.IsNull(deletedCategory);
        }

        [Test]
        public async Task DeleteCategoryAsync_ShouldThrowExceptionForNonExistentId()
        {
            // Arrange
            int nonExistentCategoryId = 100;

            // Act and Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await categoryService.DeleteCategoryAsync(nonExistentCategoryId));
        }

        [Test]
        public async Task GetAllCategoriesAsync_ShouldReturnEmptyListIfNoCategoriesExist()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();

            // Act
            var categories = await categoryService.GetAllCategoriesAsync();

            // Assert
            Assert.IsEmpty(categories);
        }

        [Test]
        public async Task GetCategoryByIdAsync_ShouldReturnNullForNonExistentId()
        {
            // Arrange
            int nonExistentCategoryId = 100; // Assuming this ID does not exist

            // Act
            var result = await categoryService.GetCategoryByIdAsync(nonExistentCategoryId);

            // Assert
            Assert.IsNull(result);
        }
    }
}

