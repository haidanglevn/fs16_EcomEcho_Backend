using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;

namespace EcommerceAPI.Business.src.Service
{
    public class ReviewService : IReviewService
    {
        private IReviewRepo _reviewRepo;
        private IMapper _mapper;
        private IUserRepo _userRepo;
        private IProductRepo _productRepo;
        public ReviewService(IMapper mapper, IReviewRepo reviewRepo, IUserRepo userRepo, IProductRepo productRepo)
        {
            _reviewRepo = reviewRepo;
            _mapper = mapper;
            _productRepo = productRepo;
            _userRepo = userRepo;
        }
        public ReviewReadDTO CreateNewReview(ReviewCreateDTO reviewCreateDTO)
        {
            var isUserExist = _userRepo.CheckUserExist(reviewCreateDTO.UserId);
            var isProductExist = _productRepo.CheckProductExist(reviewCreateDTO.ProductId);
            if (isProductExist && isUserExist)
            {
                var result = _reviewRepo.CreateNewReview(_mapper.Map<ReviewCreateDTO, Review>(reviewCreateDTO));
                return _mapper.Map<Review, ReviewReadDTO>(result);
            }
            else
            {
                throw new Exception("Invalid User or Product Id, please check again.");
            }
        }

        public bool DeleteReview(Guid reviewId)
        {
            return _reviewRepo.DeleteReview(reviewId);
        }

        public IEnumerable<ReviewReadDTO> GetAllReviewByProductId(Guid reviewId)
        {
            return _reviewRepo.GetAllReviewByProductId(reviewId).Select(r => _mapper.Map<Review, ReviewReadDTO>(r));
        }

        public IEnumerable<ReviewReadDTO> GetAllReviewByUserId(Guid reviewId)
        {
            return _reviewRepo.GetAllReviewByUserId(reviewId).Select(r => _mapper.Map<Review, ReviewReadDTO>(r));
        }

        public ReviewReadDTO? GetOneReview(Guid reviewId)
        {
            var result = _reviewRepo.GetOneReview(reviewId);
            if (result is not null)
            {
                return _mapper.Map<Review, ReviewReadDTO>(result);
            }
            else
            {
                return null;
            }
        }


        public bool UpdateReview(Guid reviewId, ReviewUpdateDTO reviewUpdateDTO)
        {
            var review = _mapper.Map<ReviewUpdateDTO, Review>(reviewUpdateDTO);
            return _reviewRepo.UpdateReview(reviewId, review);
        }
    }
}