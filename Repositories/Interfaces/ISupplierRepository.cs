using DatabaseFirst.Models;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        Supplier GetById(int id);

        IEnumerable<Supplier> GetSuppliers();

        void Add(Supplier supplier);

        void Delete(int supplierId);

        void Update(Supplier supplier);
    }
}