using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly NorthwindContext _context;

        public OrdersRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Order GetById(int id) => _context.Orders.Find(id);

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders
                .Include(o => o.Employee)
                .Include(o => o.Customer)
                .Include(o => o.ShipViaNavigation)
                .AsNoTracking()
                .ToList();
        }

        public IEnumerable<OrderDetail> GetDetails()
        {
            return _context.OrderDetails
                .Include(od => od.Product)
                .AsNoTracking()
                .ToList();
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public void AddDetail(OrderDetail detail)
        {
            _context.OrderDetails.Add(detail);
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
        }

        public void UpdateDetail(OrderDetail detail)
        {
            _context.OrderDetails.Update(detail);
        }

        public void Delete(int orderId)
        {
            var existing = _context.Orders.Find(orderId);
            if (existing != null)
            {
                _context.Orders.Remove(existing);
            }
        }

        public void DeleteDetail(int orderDetailId)
        {
            var detail = _context.OrderDetails.Find(orderDetailId);
            if (detail != null)
            {
                _context.OrderDetails.Remove(detail);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}