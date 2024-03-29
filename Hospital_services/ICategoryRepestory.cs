
using Hospital.entities;

namespace Hospital.services
{
    public interface ICategoryRepestory
    {
        Task<Category[]> getAllCategories();
        Task<Category> getById(int id);
        Task<Category> createCategory(Category category);
        Task<bool> saveChanges();
        Task<bool> deleteCategory(Category category);
    }
}
