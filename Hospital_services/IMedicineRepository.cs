using Hospital.entities;
using Hospital.Models;

namespace Hospital.services
{
    public interface IMedicineRepository
    {
        Task<Medicine[]> GetAllMedicines();
        Task<Medicine> GetById(int id);
        Task<Medicine> Add(Medicine medicine);
        Task<bool> SaveChangesAsync();
        Task<bool> Delete(Medicine medicine);
        Task<Medicine[]> Search(string searchTerm, string sortBy);



    }
}
