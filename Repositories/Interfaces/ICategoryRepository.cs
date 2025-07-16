using DatabaseFirst.Models;

namespace DatabaseFirst.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(int id);

        IEnumerable<Category> GetCategories();

        void Add(Category category);

        void Update(Category category);

        void Delete(int categoryId);
    }
}