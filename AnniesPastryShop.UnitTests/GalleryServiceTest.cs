using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.AdminModels.Gallery;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class GalleryServiceTest
    {
        private ApplicationDbContext context;
        private IGalleryService galleryService;

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            var picture1 = new Picture { ImageUrl = "image1.jpg", ProductId = 1 };
            var picture2 = new Picture { ImageUrl = "image2.jpg", ProductId = 2 };

            context.Pictures.AddRange(picture1, picture2);
            await context.SaveChangesAsync();

            galleryService = new GalleryService(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetAllImagesAsync_ShouldReturnAllImages()
        {
            // Act
            var images = await galleryService.GetAllImagesAsync();

            // Assert
            Assert.IsNotNull(images);
            Assert.AreEqual(2, images.Count());
        }

        [Test]
        public async Task GetImageByIdAsync_ShouldReturnImage()
        {
            // Arrange
            int existingImageId = 1;

            // Act
            var image = await galleryService.GetImageByIdAsync(existingImageId);

            // Assert
            Assert.IsNotNull(image);
            Assert.AreEqual(existingImageId, image.Id);
        }

        [Test]
        public async Task GetImageByIdAsync_ShouldReturnNullForNonExistentImageId()
        {
            // Arrange
            int nonExistentImageId = 100;

            // Act
            var image = await galleryService.GetImageByIdAsync(nonExistentImageId);

            // Assert
            Assert.IsNull(image);
        }

        [Test]
        public async Task GetImagesAsync_ShouldReturnImagesWithPagination()
        {
            // Arrange
            int page = 1;
            int pageSize = 1;

            // Act
            var images = await galleryService.GetImagesAsync(page, pageSize);

            // Assert
            Assert.IsNotNull(images);
            Assert.AreEqual(pageSize, images.Count());
        }

        [Test]
        public async Task GetTotalImageCountAsync_ShouldReturnTotalImageCount()
        {
            // Act
            var totalCount = await galleryService.GetTotalImageCountAsync();

            // Assert
            Assert.AreEqual(2, totalCount);
        }

        [Test]
        public async Task AddImageAsync_ShouldAddImage()
        {
            // Arrange
            var model = new GalleryAdminViewModel { ImageUrl = "image3.jpg", ProductId = 3 };

            // Act
            await galleryService.AddImageAsync(model);

            // Assert
            var images = await context.Pictures.ToListAsync();
            Assert.AreEqual(3, images.Count);
        }

        [Test]
        public async Task DeleteImageAsync_ShouldDeleteImage()
        {
            // Arrange
            int existingImageId = 1;

            // Act
            await galleryService.DeleteImageAsync(existingImageId);

            // Assert
            var images = await context.Pictures.ToListAsync();
            Assert.AreEqual(1, images.Count);
        }

        [Test]
        public async Task DeleteImageAsync_ShouldThrowExceptionForNonExistentImage()
        {
            // Arrange
            int nonExistentImageId = 100;

            // Act & Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await galleryService.DeleteImageAsync(nonExistentImageId));
        }

        [Test]
        public async Task GetAllImagesAsync_ShouldReturnEmptyListForNoImages()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();

            // Act
            var images = await galleryService.GetAllImagesAsync();

            // Assert
            Assert.IsEmpty(images);
        }

        [Test]
        public async Task GetImagesAsync_ShouldReturnEmptyListForInvalidPageSize()
        {
            // Arrange
            int page = 1;
            int invalidPageSize = -10;

            // Act
            var images = await galleryService.GetImagesAsync(page, invalidPageSize);

            // Assert
            Assert.IsEmpty(images);
        }

        [Test]
        public async Task GetImageByIdAsync_ShouldReturnNullForNegativeId()
        {
            // Arrange
            int negativeImageId = -1;

            // Act
            var image = await galleryService.GetImageByIdAsync(negativeImageId);

            // Assert
            Assert.IsNull(image);
        }

        [Test]
        public async Task GetImageByIdAsync_ShouldReturnNullForZeroId()
        {
            // Arrange
            int zeroImageId = 0;

            // Act
            var image = await galleryService.GetImageByIdAsync(zeroImageId);

            // Assert
            Assert.IsNull(image);
        }

        [Test]
        public async Task GetImagesAsync_ShouldReturnEmptyListForZeroPageSize()
        {
            // Arrange
            int page = 1;
            int zeroPageSize = 0;

            // Act
            var images = await galleryService.GetImagesAsync(page, zeroPageSize);

            // Assert
            Assert.IsEmpty(images);
        }

    }

}
