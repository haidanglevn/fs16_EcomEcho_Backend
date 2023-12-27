using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Business.src.Abstraction
{
    public interface IOrderService
    {
        OrderReadDTO CreateNewOrder(OrderCreateDTO orderCreateDTO);
        IEnumerable<OrderReadDTO> GetAllOrders(GetAllParams options);
        OrderReadDTO? GetOneOrder(Guid orderId);
        bool UpdateOrder(Guid orderId, OrderUpdateDTO orderUpdateDTO);
        bool DeleteOrder(Guid orderId);
    }
}