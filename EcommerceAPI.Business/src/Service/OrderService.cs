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
            if (orderCreateDTO.OrderItems.Count == 0)
            {
                throw new Exception("OrderItems are missing, cannot create order without any order items.");
            }
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
            var isUserExist = _userRepo.CheckUserExist(orderCreateDTO.UserId);
            var user = _userRepo.GetOneUser(orderCreateDTO.UserId);
            if (!isUserExist)
            {
                throw new Exception("Invalid User Id, please check again.");
            }
            else if (user is not null && user.Addresses.Any(a => a.Id == orderCreateDTO.AddressId))
            {
                var result = _orderRepo.CreateNewOrder(_mapper.Map<OrderCreateDTO, Order>(orderCreateDTO));
                return _mapper.Map<Order, OrderReadDTO>(result);
            }
            else
            {
                throw new Exception("Address does not match the provided User, please check again.");
            }
        }

        public bool DeleteOrder(Guid orderId)
        {
            return _orderRepo.DeleteOrder(orderId);
        }

        public IEnumerable<OrderReadDTO> GetAllOrders(GetAllParams options)
        {
            return _orderRepo.GetAllOrders(options)
            .Select(o => _mapper.Map<Order, OrderReadDTO>(o));
        }

        public OrderReadDTO? GetOneOrder(Guid orderId)
        {
            var order = _orderRepo.GetOneOrder(orderId);
            if (order is not null)
            {
                return _mapper.Map<Order, OrderReadDTO>(order);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateOrderStatus(Guid orderId, OrderUpdateDTO orderUpdateDTO)
        {
            var order = _mapper.Map<Order>(orderUpdateDTO);
            return _orderRepo.UpdateOrderStatus(orderId, order);
        }
    }
}