using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories
{
    public class EmployeeRepository:IEmployee
    {
        NorthwindContext _context;
        public EmployeeRepository(NorthwindContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.AsNoTracking().ToList();
        }
        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
