using DatabaseFirst.Models;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);

        IEnumerable<Product> GetProducts();

        void Add(Product product);

        void Update(Product product);

        void Delete(int productId);
    }
}