using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class ReviewRepo : IReviewRepo
    {
        private DbSet<Review> _reviews;
        private DatabaseContext _database;
        public ReviewRepo(DatabaseContext database)
        {
            _database = database;
            _reviews = database.Reviews;
        }
        public Review CreateNewReview(Review review)
        {

            _reviews.Add(review);
            _database.SaveChanges();
            return review;
        }

        public bool DeleteReview(Guid reviewId)
        {
            var review = _reviews.Find(reviewId);
            if (review != null)
            {
                _reviews.Remove(review);
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public Review? GetOneReview(Guid reviewId)
        {
            return _reviews.Find(reviewId);
        }

        public IEnumerable<Review> GetAllReviewByProductId(Guid productId)
        {
            return _reviews.AsNoTracking().Where(r => r.ProductId == productId);
        }

        public IEnumerable<Review> GetAllReviewByUserId(Guid userId)
        {
            return _reviews.AsNoTracking().Where(r => r.UserId == userId);
        }

        public bool UpdateReview(Guid reviewId, Review review)
        {
            var existingReview = _reviews.Find(reviewId);
            if (existingReview != null)
            {
                UpdateEntityFields(existingReview, review);
                existingReview.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        private void UpdateEntityFields(Review existingReview, Review review)
        {
            var dtoProperties = review.GetType().GetProperties();
            foreach (var dtoProp in dtoProperties)
            {
                if (dtoProp.Name == "UserId" || (dtoProp.Name == "ProductId") || (dtoProp.Name == "Id") || (dtoProp.Name == "CreatedAt"))
                {
                    continue;
                }
                var value = dtoProp.GetValue(review);
                if (value != null)
                {
                    var entityProp = existingReview.GetType().GetProperty(dtoProp.Name);
                    if (entityProp != null && entityProp.CanWrite)
                    {
                        entityProp.SetValue(existingReview, value);
                    }
                }
            }
        }
    }
}