using Hospital.entities;
using Hospital.Models;
using Hospital_services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.services
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly HospitalDbContext _db;

        public MedicineRepository(HospitalDbContext db)
        {
            _db = db;
        }

        public async Task<Medicine[]> GetAllMedicines()
        {
            return await _db.Medicines.ToArrayAsync();
        }

        public async Task<Medicine> GetById(int id)
        {
            return await _db.Medicines.FindAsync(id);
        }

        public async Task<Medicine> Add(Medicine medicine)
        {
            _db.Medicines.Add(medicine);
            await _db.SaveChangesAsync();
            return medicine;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _db.SaveChangesAsync() > 0);
        }


        public async Task<bool> Delete(Medicine medicine)
        {

            _db.Medicines.Remove(medicine);
            return (await _db.SaveChangesAsync() > 0);

        }


        public async Task<Medicine[]> Search(string? searchTerm, string? sortBy)
        {
            IQueryable<Medicine> query = _db.Medicines.Include(p => p.Category);

            // Apply search 
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(m => m.Name.ToLower().Contains(searchTerm.ToLower()) || m.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            // Apply sorting
            switch (sortBy)
            {
                case "asc":
                    query = query.OrderBy(m => m.Name);
                    break;
                case "desc":
                    query = query.OrderByDescending(m => m.Name);
                    break;
                default:
                    query = query.OrderBy(m => m.Id);
                    break;
            }

            return await query.ToArrayAsync();
        }
    }
}
