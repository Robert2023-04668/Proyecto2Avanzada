using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public Order GetById(int id);
        public IEnumerable<Order> GetOrders();

        public void Add(Order order);   
        public void Update(Order order);
        public void Delete(int orderId);

    }
}
