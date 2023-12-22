using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
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
            return CreatedAtAction(nameof(CreateNewReview), _reviewService.CreateNewReview(reviewCreateDTO));
        }

        [HttpGet("by-userid/{userId}")]
        public ActionResult<ReviewReadDTO> GetReviewByUserId(Guid userId)
        {
            return Ok(_reviewService.GetAllReviewByUserId(userId));
        }
    }
}