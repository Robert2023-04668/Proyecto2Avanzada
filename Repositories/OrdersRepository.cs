using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        public NorthwindContext _context = new NorthwindContext();

        public OrdersRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Order GetById(int id) => _context.Orders.Find(id);

        public IEnumerable<Order> GetOrders()
        {
            return
                _context.Orders.Include(_o => _o.Employee).Include(o => o.Customer).Include(o => o.ShipViaNavigation).AsNoTracking().ToList();
        }

        public IEnumerable<OrderDetail> GetDetails() => _context.OrderDetails.Include(_od => _od.Product).AsNoTracking().ToList();

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
            var existing = _context.Orders.Find(order.OrderId);

            if (existing != null)
            {
            }
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
                _context.SaveChanges();
            }
        }

        public void DeleteDetail(int orderId)
        {
        }
    }
}