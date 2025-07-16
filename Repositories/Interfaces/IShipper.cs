using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface IShipper
    {
        Shipper GetById(int id);
        IEnumerable<Shipper> GetShipers();
    }
}
