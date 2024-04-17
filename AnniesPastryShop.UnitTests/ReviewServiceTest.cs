using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Review;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class ReviewServiceTest
    {
        private ApplicationDbContext context;
        private IReviewService reviewService;

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            var customer1 = new Customer { FullName = "Customer 1", UserId = "user1" };
            var customer2 = new Customer { FullName = "Customer 2", UserId = "user2" };

            await context.Customers.AddRangeAsync(customer1, customer2);

            var product1 = new Product { Name = "Product 1", Price = 10.0m };
            var product2 = new Product { Name = "Product 2", Price = 20.0m };

            await context.Products.AddRangeAsync(product1, product2);

            var review1 = new Review { Rating = 4, Comment = "Good", CreatedOn = DateTime.Now.AddDays(-5), ProductId = 1, CustomerId = 1 };
            var review2 = new Review { Rating = 5, Comment = "Excellent", CreatedOn = DateTime.Now.AddDays(-3), ProductId = 1, CustomerId = 2 };
            var review3 = new Review { Rating = 3, Comment = "Average", CreatedOn = DateTime.Now.AddDays(-1), ProductId = 2, CustomerId = 1 };

            await context.Reviews.AddRangeAsync(review1, review2, review3);

            await context.SaveChangesAsync();

            reviewService = new ReviewService(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetAllReviewsAsync_ShouldReturnAllReviews()
        {
            // Act
            var reviews = await reviewService.GetAllReviewsAsync();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.AreEqual(3, reviews.Count());
        }

        [Test]
        public async Task GetReviewByIdAsync_ShouldReturnReviewById()
        {
            // Arrange
            int reviewId = 1;

            // Act
            var review = await reviewService.GetReviewByIdAsync(reviewId);

            // Assert
            Assert.IsNotNull(review);
            Assert.AreEqual(reviewId, review.Id);
        }

        [Test]
        public async Task GetReviewByIdAsync_ShouldReturnNullForNonExistentReviewId()
        {
            // Arrange
            int nonExistentReviewId = 100;

            // Act
            var review = await reviewService.GetReviewByIdAsync(nonExistentReviewId);

            // Assert
            Assert.IsNull(review);
        }

        [Test]
        public async Task UpdateReviewAsync_ShouldUpdateReview()
        {
            // Arrange
            int existingReviewId = 1;
            var updatedReview = new ReviewViewModel { Rating = 5, Comment = "Updated comment" };

            // Act
            await reviewService.UpdateReviewAsync(existingReviewId, updatedReview);

            // Assert
            var review = await context.Reviews.FindAsync(existingReviewId);
            Assert.IsNotNull(review);
            Assert.AreEqual(updatedReview.Rating, review.Rating);
            Assert.AreEqual(updatedReview.Comment, review.Comment);
        }

        [Test]
        public async Task DeleteReviewAsync_ShouldDeleteReview()
        {
            // Arrange
            int existingReviewId = 1;

            // Act
            await reviewService.DeleteReviewAsync(existingReviewId);

            // Assert
            var reviews = await context.Reviews.ToListAsync();
            Assert.AreEqual(2, reviews.Count);
            Assert.IsFalse(reviews.Any(r => r.Id == existingReviewId));
        }

        [Test]
        public async Task GetAllReviewsAsync_ShouldReturnEmptyListForNoReviews()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var reviews = await reviewService.GetAllReviewsAsync();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.IsEmpty(reviews);
        }

        [Test]
        public async Task GetReviewOrderByRatingAscending_ShouldReturnReviewsOrderedByRatingAscending()
        {
            // Act
            var reviews = await reviewService.GetReviewOrderByRatingAscending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.AreEqual(3, reviews.Count());
            Assert.IsTrue(reviews.Select(r => r.Rating).SequenceEqual(reviews.OrderBy(r => r.Rating).Select(r => r.Rating)));
        }

        [Test]
        public async Task GetReviewOrderByRatingDescending_ShouldReturnReviewsOrderedByRatingDescending()
        {
            // Act
            var reviews = await reviewService.GetReviewOrderByRatingDescending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.AreEqual(3, reviews.Count());
            Assert.IsTrue(reviews.Select(r => r.Rating).SequenceEqual(reviews.OrderByDescending(r => r.Rating).Select(r => r.Rating)));
        }

        [Test]
        public async Task GetReviewOrderByDateAscending_ShouldReturnReviewsOrderedByDateAscending()
        {
            // Act
            var reviews = await reviewService.GetReviewOrderByDateAscending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.AreEqual(3, reviews.Count());
            Assert.IsTrue(reviews.Select(r => r.CreatedAt).SequenceEqual(reviews.OrderBy(r => r.CreatedAt).Select(r => r.CreatedAt)));
        }

        [Test]
        public async Task GetReviewOrderByDateDescending_ShouldReturnReviewsOrderedByDateDescending()
        {
            // Act
            var reviews = await reviewService.GetReviewOrderByDateDescending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.AreEqual(3, reviews.Count());
            Assert.IsTrue(reviews.Select(r => r.CreatedAt).SequenceEqual(reviews.OrderByDescending(r => r.CreatedAt).Select(r => r.CreatedAt)));
        }

        [Test]
        public async Task GetReviewOrderByRatingAscending_ShouldReturnEmptyListForNoReviews()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var reviews = await reviewService.GetReviewOrderByRatingAscending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.IsEmpty(reviews);
        }

        [Test]
        public async Task GetReviewOrderByRatingDescending_ShouldReturnEmptyListForNoReviews()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var reviews = await reviewService.GetReviewOrderByRatingDescending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.IsEmpty(reviews);
        }

        [Test]
        public async Task GetReviewOrderByDateAscending_ShouldReturnEmptyListForNoReviews()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var reviews = await reviewService.GetReviewOrderByDateAscending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.IsEmpty(reviews);
        }

        [Test]
        public async Task GetReviewOrderByDateDescending_ShouldReturnEmptyListForNoReviews()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var reviews = await reviewService.GetReviewOrderByDateDescending();

            // Assert
            Assert.IsNotNull(reviews);
            Assert.IsEmpty(reviews);
        }

    }
}
