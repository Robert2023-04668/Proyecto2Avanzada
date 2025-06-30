using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        Supplier GetById(int id);
        public IEnumerable<Supplier> GetSuppliers();
        public void Add(Supplier supplier);
        public void Delete(int supplierId);
        public void Update(Supplier supplier);

    }
}
