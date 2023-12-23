using EcommerceAPI.Business.src.DTO;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IReviewService
    {
        IEnumerable<ReviewReadDTO> GetAllReviewByProductId(Guid reviewId);
        IEnumerable<ReviewReadDTO> GetAllReviewByUserId(Guid reviewId);
        ReviewReadDTO CreateNewReview(ReviewCreateDTO reviewCreateDTO);
        bool UpdateReview(Guid reviewId, ReviewUpdateDTO reviewUpdateDTO);
        bool DeleteReview(Guid reviewId);
        ReviewReadDTO? GetOneReview(Guid reviewId);
    }
}