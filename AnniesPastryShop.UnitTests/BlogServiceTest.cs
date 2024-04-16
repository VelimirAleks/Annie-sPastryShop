using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Blog;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class BlogServiceTest
    {
        private ApplicationDbContext context;
        private IBlogService blogService;
        private IEnumerable<Blog> blogs;

        private Blog NewStoreOpen;
        private Blog SweetCake;
        private Blog HolidaySpecial;

        [SetUp]
        public async Task Setup()
        {

            NewStoreOpen = new Blog
            {
                Id = 1,
                Title = "New Store Open",
                Content = "We are excited to announce the opening of our new store in the heart of the city.",
                ImageUrl = "https://www.dropbox.com/scl/fi/dwi4j1ek5sey5sdt2zieu/FOTOBODEN-INDIVIDUELL-BEDRUCKBARER-VINYLBODEN.jpg?rlkey=flbp0ko4cym1v9fhg9sf0x9nc&dl=1",
                CreatedAt = DateTime.Now
            };

            SweetCake = new Blog
            {
                Id = 2,
                Title = "Sweet Cake",
                Content = "Our cakes are made with love and care. Try our sweet cake today!",
                ImageUrl = "https://www.dropbox.com/scl/fi/lxo1tjn4re7ht3anh58d7/If-you-are-anywhere-in-the-city-center-of-Le-Mans.jpg?rlkey=yp6wjxl8lbb2h3zoolgsrb90h&dl=1",
                CreatedAt = DateTime.Now
            };

            HolidaySpecial = new Blog
            {
                Id = 3,
                Title = "Holiday Special",
                Content = "Celebrate the holidays with our special cakes and pastries.",
                ImageUrl = "https://www.dropbox.com/scl/fi/d9g8ibm0235gdf8z2ndw9/Chocolate-Strawberry-Cake.jpg?rlkey=mdx8hl5kt7exhol04bz686kfo&dl=1",
                CreatedAt = DateTime.Now
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemmoryDb" + Guid.NewGuid().ToString())
               .Options;

            context = new ApplicationDbContext(options);

            context.Blogs.AddRange(NewStoreOpen, SweetCake, HolidaySpecial);
            await context.SaveChangesAsync();

            blogService = new BlogService(context);

        }

        [TearDown]
        public async Task TearDown()
        {
           await this.context.Database.EnsureDeletedAsync();
           await this.context.DisposeAsync();
        }
        [Test]
        public async Task AddBlogAsync_ShouldAddBlogToDatabase()
        {
            // Arrange
            var blogModel = new BlogViewModel
            {
                Title = "Test Blog",
                Content = "This is a test blog",
                ImageUrl = "https://example.com/test-image.jpg",
                CreatedAt = DateTime.Now
            };

            // Act
            await blogService.AddBlogAsync(blogModel);

            // Assert
            var addedBlog = await context.Blogs.FirstOrDefaultAsync(b => b.Title == "Test Blog");
            Assert.IsNotNull(addedBlog);
        }

        [Test]
        public async Task DeleteBlogAsync_ShouldDeleteBlogFromDatabase()
        {
            // Arrange
            int blogIdToDelete = 1; 

            // Act
            await blogService.DeleteBlogAsync(blogIdToDelete);

            // Assert
            var deletedBlog = await context.Blogs.FindAsync(blogIdToDelete);
            Assert.IsNull(deletedBlog);
        }

        [Test]
        public async Task GetAllBlogsAsync_ShouldReturnAllBlogs()
        {
            // Arrange

            // Act
            var result = await blogService.GetAllBlogsAsync();

            // Assert
            Assert.AreEqual(3, result.Count()); 
        }

        [Test]
        public async Task GetBlogByIdAsync_ShouldReturnCorrectBlog()
        {
            // Arrange
            int blogIdToRetrieve = 1;

            // Act
            var result = await blogService.GetBlogByIdAsync(blogIdToRetrieve);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(blogIdToRetrieve, result.Id);
        }

        [Test]
        public async Task GetBlogByIdAsync_ShouldReturnNullIfBlogNotFound()
        {
            // Arrange
            int nonExistentBlogId = 100; 

            // Act
            var result = await blogService.GetBlogByIdAsync(nonExistentBlogId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task UpdateBlogAsync_ShouldUpdateExistingBlog()
        {
            // Arrange
            int blogIdToUpdate = 1; 
            var updatedBlogModel = new BlogViewModel
            {
                Id = blogIdToUpdate,
                Title = "Updated Title",
                Content = "Updated Content",
                ImageUrl = "https://example.com/updated-image.jpg",
                CreatedAt = DateTime.Now
            };

            // Act
            await blogService.UpdateBlogAsync(updatedBlogModel);

            // Assert
            var updatedBlog = await context.Blogs.FindAsync(blogIdToUpdate);
            Assert.IsNotNull(updatedBlog);
            Assert.AreEqual("Updated Title", updatedBlog.Title);
            Assert.AreEqual("Updated Content", updatedBlog.Content);
            Assert.AreEqual("https://example.com/updated-image.jpg", updatedBlog.ImageUrl);
        }

        [Test]
        public async Task DeleteBlogAsync_ShouldThrowExceptionForNonExistentId()
        {
            // Arrange
            int nonExistentId = 100;

            // Act and Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await blogService.DeleteBlogAsync(nonExistentId));
        }

        [Test]
        public async Task GetAllBlogsAsync_ShouldReturnEmptyListIfNoBlogs()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync(); 

            // Act
            var result = await blogService.GetAllBlogsAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task UpdateBlogAsync_ShouldThrowExceptionForInvalidModel()
        {
            // Arrange
            BlogViewModel invalidModel = new BlogViewModel(); 

            // Act and Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await blogService.UpdateBlogAsync(invalidModel));
        }

        [Test]
        public async Task UpdateBlogAsync_ShouldThrowExceptionForNonExistentBlog()
        {
            // Arrange
            var nonExistentBlogId = 100;
            var updatedModel = new BlogViewModel { Id = nonExistentBlogId, Title = "Updated Title" };

            // Act and Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await blogService.UpdateBlogAsync(updatedModel));
        }
    }
}
