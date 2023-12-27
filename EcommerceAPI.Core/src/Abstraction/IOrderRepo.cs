using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;

namespace EcommerceAPI.Core.src.Abstraction
{
    public interface IOrderRepo
    {
        Order CreateNewOrder(Order order);
        IEnumerable<Order> GetAllOrders(GetAllParams options);
        Order? GetOneOrder(Guid orderId);
        bool UpdateOrder(Guid orderId, Order order);
        bool DeleteOrder(Guid orderId);
    }
}