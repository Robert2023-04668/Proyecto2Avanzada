using DatabaseFirst.Models;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        Order GetById(int id);

        IEnumerable<Order> GetOrders();

        void Add(Order order);

        void Update(Order order);

        void Delete(int orderId);

        IEnumerable<OrderDetail> GetDetails();

        void AddDetail (OrderDetail detail);
        void UpdateDetail (OrderDetail detail);
        void DeleteDetail (int orderId);
        void Save();
    }

    
}