using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Review;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class ReviewService:IReviewService
    {
        private readonly ApplicationDbContext context;

        public ReviewService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task CreateReviewAsync(ReviewViewModel review, string userId)
        {
            var product = await context.Products.FindAsync(review.ProductId);
            if (product == null)
            {
                throw new InvalidOperationException("Product not found.");
            }

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == userId);
            if (customer == null)
            {
                throw new InvalidOperationException("Customer not found.");
            }

            var newReview = new Review
            {
                Rating = review.Rating,
                Comment = review.Comment,
                CreatedOn = review.CreatedAt,
                ProductId = product.Id,
                CustomerId = customer.Id
            };
            context.Reviews.Add(newReview);
            await context.SaveChangesAsync(); 
        }

        public async Task DeleteReviewAsync(int id)
        {
            var review = await context.Reviews.FindAsync(id);
            if (review == null)
            {
                throw new InvalidOperationException("Review not found");
            }
            context.Reviews.Remove(review);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ReviewViewModel>> GetAllReviewsAsync()
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .Select(r=> new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment= r.Comment,
                    CreatedAt =r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName =r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task<ReviewViewModel?> GetReviewByIdAsync(int id)
        {
            var reviewViewModel = await context.Reviews
                 .Where(r => r.Id == id)
                 .Select(r => new ReviewViewModel
                 {
                     Id = r.Id,
                     Rating = r.Rating,
                     Comment = r.Comment,
                     CreatedAt = r.CreatedOn,
                     ProductName = r.Product.Name,
                     ProductId = r.ProductId,
                     CustomerName = r.Customer.FullName
                 })
                .FirstOrDefaultAsync();

            return reviewViewModel;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewOrderByDateAscending()
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .OrderBy(r => r.CreatedOn)
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName = r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewOrderByDateDescending()
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .OrderByDescending(r => r.CreatedOn)
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName = r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewOrderByRatingAscending()
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .OrderBy(r => r.Rating)
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName = r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task<IEnumerable<ReviewViewModel>> GetReviewOrderByRatingDescending()
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .OrderByDescending(r => r.Rating)
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName = r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task<IEnumerable<ReviewViewModel?>> GetReviewsForProductAsync(int productId)
        {
            var reviews = await context.Reviews
                .AsNoTracking()
                .Where(r => r.ProductId == productId)
                .Select(r => new ReviewViewModel
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedOn,
                    ProductName = r.Product.Name,
                    CustomerName = r.Customer.FullName
                })
                .ToListAsync();
            return reviews;
        }

        public async Task UpdateReviewAsync(int id, ReviewViewModel review)
        {
            var existingReview  =await context.Reviews.FindAsync(id);
            if (existingReview == null)
            {
                throw new InvalidOperationException("Review not found");
            }
            existingReview.Rating = review.Rating;
            existingReview.Comment = review.Comment;

            await context.SaveChangesAsync();
        }
    }
}
