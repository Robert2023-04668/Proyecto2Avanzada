using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface IEmployee
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetEmployees();
    }
}
