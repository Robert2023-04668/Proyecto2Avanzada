using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class ShipperRepository : IShipper
    {
        private NorthwindContext _context = new NorthwindContext();

        public ShipperRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Shipper GetById(int id) => _context.Shippers.Find(id);

        public IEnumerable<Shipper> GetShipers() => _context.Shippers.AsNoTracking().ToList();
    }
}