using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        public IEnumerable<Category> GetCategories();
        public void Add (Category category);
        public void Update (Category category);
        public void Delete (int categoryId);
    }
}
