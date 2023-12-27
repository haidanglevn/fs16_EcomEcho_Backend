using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private DbSet<Order> _orders;
        private DbSet<OrderItem> _orderItems;
        private DatabaseContext _database;
        public OrderRepo(DatabaseContext database)
        {
            _database = database;
            _orders = database.Orders;
            _orderItems = database.OrderItems;
        }
        public Order CreateNewOrder(Order order)
        {
            try
            {
                _orders.Add(order);
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    _orderItems.Add(orderItem);
                }
                _database.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating new order: " + e.Message.ToString());
            }
            return order;
        }

        public bool DeleteOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders(GetAllParams options)
        {
            throw new NotImplementedException();
        }

        public Order? GetOneOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Guid orderId, Order order)
        {
            throw new NotImplementedException();
        }
    }
}