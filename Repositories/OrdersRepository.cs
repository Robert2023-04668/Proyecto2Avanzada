using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class OrdersRepository: IOrdersRepository
    {
        public NorthwindContext _context = new NorthwindContext();

        public OrdersRepository(NorthwindContext context)
        {
            _context = context;
        }


        public Order GetById(int id) => _context.Orders.Find(id);

        public IEnumerable<Order> GetOrders() => _context.Orders.AsNoTracking().ToList();

        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }
        public void Update(Order order)
        {
            var existing = _context.Orders.Find(order.OrderId);

            if (existing != null)
            {

            }
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
    }
}
