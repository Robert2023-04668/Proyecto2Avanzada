using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class SupplierRepository:ISupplierRepository
    {
        NorthwindContext _context = new NorthwindContext();
        public SupplierRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Supplier GetById(int id) => _context.Suppliers.Find(id);

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _context.Suppliers.AsNoTracking().ToList();
        }
        public void Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
        }

        public void Delete(int supplierId)
        {
            var existing = _context.Suppliers.Find(supplierId);
            if (existing != null)
            {
                _context.Suppliers.Remove(existing);
                _context.SaveChanges();
            }
        }
        public void Update(Supplier supplier)
        {
            var existing = _context.Suppliers.Find(supplier.SupplierId);
            if (existing != null)
            {
                existing.Address = supplier.Address;
                existing.City = supplier.City;
                existing.Country = supplier.Country;
                existing.CompanyName = supplier.CompanyName;
                existing.Phone = supplier.Phone;
                existing.PostalCode = supplier.PostalCode;
                existing.Region = supplier.Region;
                existing.ContactTitle = supplier.ContactTitle;
                existing.ContactName = supplier.ContactName;
                existing.HomePage = supplier.HomePage;
                _context.SaveChanges();
            }
        }
    }
}
