using AnniesPastryShop.Core.Models.Review;
using AnniesPastryShop.Infrastructure.Data.Models;

namespace AnniesPastryShop.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewViewModel>> GetAllReviewsAsync();
        Task<ReviewViewModel?> GetReviewByIdAsync(int id);
        Task<IEnumerable<ReviewViewModel?>> GetReviewsForProductAsync(int productId);
        Task CreateReviewAsync(ReviewViewModel review, string userId);
        Task UpdateReviewAsync(int id, ReviewViewModel review);
        Task DeleteReviewAsync(int id);
        Task<IEnumerable<ReviewViewModel>> GetReviewOrderByRatingAscending();
        Task<IEnumerable<ReviewViewModel>> GetReviewOrderByRatingDescending();
        Task<IEnumerable<ReviewViewModel>> GetReviewOrderByDateAscending();
        Task<IEnumerable<ReviewViewModel>> GetReviewOrderByDateDescending();
    }
}
