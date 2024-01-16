using System.Transactions;
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
            using var scope = new TransactionScope();
            try
            {
                _orders.Add(order);
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    _orderItems.Add(orderItem);
                }
                _database.SaveChanges();

                scope.Complete();
                return order;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                Exception? inner = e.InnerException;
                while (inner != null)
                {
                    throw new Exception("Inner exception: " + inner.Message);
                }
                throw new Exception("Error creating new order: " + e.Message);
            }
        }

        public bool DeleteOrder(Guid orderId)
        {
            var order = _orders.Find(orderId);
            if (order != null)
            {
                order.IsDeleted = true;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Order> GetAllOrders(GetAllParams options)
        {
            return _orders.Include(o => o.OrderItems)
                            .Skip(options.Offset)
                            .Take(options.Limit);
        }

        public Order? GetOneOrder(Guid orderId)
        {
            return _orders.Include(o => o.OrderItems)
                        .FirstOrDefault(o => o.Id == orderId);
        }

        public bool UpdateOrderStatus(Guid orderId, Order order)
        {
            var existingOrder = _orders.Find(orderId);
            if (existingOrder != null)
            {
                existingOrder.Status = order.Status;
                existingOrder.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }
    }
}