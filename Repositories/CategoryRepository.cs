using DatabaseFirst.Models;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NorthwindContext _context;

        public CategoryRepository(NorthwindContext context)
        {
            _context = context;
        }
         
        public Category GetById (int id) => _context.Categories.Find(id);

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.AsNoTracking().ToList();
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            var existing = _context.Categories.Find(category.CategoryId);
            if (existing != null)
            {
             existing.CategoryName = category.CategoryName;
                existing.Description = category.Description;
                existing.Picture = category.Picture;
                existing.Products = category.Products;
                _context.SaveChanges();
            }
        }

        public void Delete(int categoryId)
        {
            var existing = _context.Categories.Find(categoryId);
            if (existing != null)
            {
                _context.Categories.Remove(existing);
                _context.SaveChanges();
            }
            
        }
    }
}
