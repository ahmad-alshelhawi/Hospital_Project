using Hospital_entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_services
{
    /*public class ManufacturerRepository
    {
        private readonly HospitalDbContext _db;

        public ManufacturerRepository(HospitalDbContext db)
        {
            _db = db;
        }   

        public async Task<Manufacturer[]> GetAllManufacturers()
        {
            return await _db.Manufacturers.ToArrayAsync();
        }

        public async Task<Manufacturer> GetManufacturerById()
        {
            return await _db.Manufacturers.FirstAsync();
        }
        public async Task<Manufacturer> AddManufacturer( Manufacturer manufacturer)
        {
            _db.Manufacturers.Add(manufacturer);
            _db.SaveChangesAsync();
            return manufacturer;
        }
        public async Task<Manufacturer> UpdateManudacturer(int id,UpdateManudacturerMapper updateManudacturerMapper)
        {
            var existingManufacturer = _db.Manufacturers.FindAsync(id);
            if(existingManufacturer == null)
            {
                throw new ArgumentException($"Medicine with ID {id} not found");

            }
        }
    }*/
}
