using Hospital.entities;

using Hospital_services;
using Microsoft.EntityFrameworkCore;

namespace Hospital.services
{
    public class CategoryRepestory : ICategoryRepestory
    {
        public readonly HospitalDbContext _db;
        public CategoryRepestory(HospitalDbContext db)
        {
            _db = db;
        }

        public async Task<Category[]> getAllCategories()
        {
            IQueryable<Category> query = _db.Categories;
            return await query.ToArrayAsync();
        }

        public async Task<Category> getById(int id)
        {
            IQueryable<Category> query = _db.Categories;
            query = query.Where(c => c.Id == id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Category> createCategory(Category category)
        {
            _db.Add(category);
            await _db.SaveChangesAsync();
            return category;

        }

        public async Task<bool> saveChanges()
        {
            return (await _db.SaveChangesAsync() > 0);
        }

        public async Task<bool> deleteCategory(Category category)
        {

            _db.Categories.Remove(category);
            return (await _db.SaveChangesAsync() > 0);

        }





    }
}
