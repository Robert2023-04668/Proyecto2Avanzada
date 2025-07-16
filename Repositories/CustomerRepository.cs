using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class CustomerRepository
    {
        private readonly NorthwindContext _context;

        public CustomerRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Customer GetById(int customerid) => _context.Customers.Find(customerid);

        public IEnumerable<Customer> GetCustomers() => _context.Customers.AsNoTracking().ToList();
    }
}