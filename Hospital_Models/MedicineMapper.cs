
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class MedicineMapper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
    }
    public class MedicineAddMapper
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }

        public int ManufacturerId { get; set; }

    }
    public class MedicineUpdateMapper
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
    }
    public class MedicineSearchMapper
    {
        public string Name { get; set; }
        public string SortBy { get; set; }

    }

    public class MedicineSearchMapperOut
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}
