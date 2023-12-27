using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepo _orderRepo;
        private IUserRepo _userRepo;
        private IProductRepo _productRepo;
        private IMapper _mapper;
        public OrderService(IOrderRepo orderRepo, IMapper mapper, IUserRepo userRepo, IProductRepo productRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
            _userRepo = userRepo;
            _productRepo = productRepo;
        }
        public OrderReadDTO CreateNewOrder(OrderCreateDTO orderCreateDTO)
        {
            var isUserExist = _userRepo.CheckUserExist(orderCreateDTO.UserId);
            foreach (OrderItemCreateDTO item in orderCreateDTO.OrderItems)
            {
                // Need to check for variantId as well when that is ready
                var isProductIdValid = _productRepo.CheckProductExist(item.ProductId);
                if (!isProductIdValid)
                {
                    throw new Exception("Invalid ProductId in OrderItem, please check again");
                }
                if (item.Quantity <= 0)
                {
                    throw new Exception("Invalid quantity in OrderItem, please check again");
                }
            }
            if (!isUserExist)
            {
                throw new Exception("Invalid User Id, please check again.");
            }
            if (orderCreateDTO.OrderItems.Count == 0)
            {
                throw new Exception("OrderItems are missing, cannot create order without any order items.");
            }

            var result = _orderRepo.CreateNewOrder(_mapper.Map<OrderCreateDTO, Order>(orderCreateDTO));
            return _mapper.Map<Order, OrderReadDTO>(result);
        }

        public bool DeleteOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderReadDTO> GetAllOrders(GetAllParams options)
        {
            throw new NotImplementedException();
        }

        public OrderReadDTO? GetOneOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Guid orderId, OrderUpdateDTO orderUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}