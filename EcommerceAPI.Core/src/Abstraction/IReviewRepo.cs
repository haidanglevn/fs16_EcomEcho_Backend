using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IReviewRepo
    {
        IEnumerable<Review> GetAllReviewByProductId(Guid reviewId);
        IEnumerable<Review> GetAllReviewByUserId(Guid reviewId);
        Review CreateNewReview(Review review);
        bool UpdateReview(Guid reviewId, Review review);
        bool DeleteReview(Guid reviewId);
    }
}