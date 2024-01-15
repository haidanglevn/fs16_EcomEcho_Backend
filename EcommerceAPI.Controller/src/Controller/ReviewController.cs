using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/[controller]s")]
    public class ReviewController : ControllerBase
    {
        private IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost()]
        public ActionResult<ReviewReadDTO> CreateNewReview([FromBody] ReviewCreateDTO reviewCreateDTO)
        {
            try
            {
                var createdReview = _reviewService.CreateNewReview(reviewCreateDTO);
                return CreatedAtAction(nameof(CreateNewReview), createdReview);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating the review.");
            }
        }

        [HttpGet("by-userid/{userId}")]
        public ActionResult<ReviewReadDTO> GetReviewByUserId(Guid userId)
        {
            return Ok(_reviewService.GetAllReviewByUserId(userId));
        }

        [HttpGet("by-productid/{productId}")]
        public ActionResult<ReviewReadDTO> GetReviewByProductId(Guid productId)
        {
            return Ok(_reviewService.GetAllReviewByProductId(productId));
        }

        [HttpDelete("{reviewId}"), Authorize(Roles = "Admin")]
        public IActionResult DeleteReview(Guid reviewId)
        {
            var result = _reviewService.DeleteReview(reviewId);
            if (!result)
            {
                return NotFound($"Review with ID {reviewId} not found.");
            }
            return Ok($"[ADMIN] Review with ID {reviewId} is deleted successfully");
        }

        [HttpPatch("{reviewId}"), Authorize]
        public IActionResult UpdateReview(Guid reviewId, [FromBody] ReviewUpdateDTO reviewUpdateDTO)
        {
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userId))
            {
                return BadRequest("Invalid user ID in token.");
            }

            var existingReview = _reviewService.GetOneReview(reviewId);
            if (existingReview == null)
            {
                return NotFound($"Review with ID {reviewId} not found.");
            }

            if (existingReview.UserId != userId)
            {
                return Unauthorized("You do not have permission to edit this review.");
            }

            try
            {
                _reviewService.UpdateReview(reviewId, reviewUpdateDTO);
                return Ok($"Review with ID {reviewId} is updated successfully");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"An error occurred while updating the review: {e.Message}");
            }
        }

    }
}