using Hospital_entities;
using System.ComponentModel.DataAnnotations;

namespace Hospital.entities
{
    public class Medicine
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Medicine name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int CategoryId { get; set; } // Foreign key
        public Category Category { get; set; } // Navigation property

        [StringLength(50)]
        [Required(ErrorMessage = "ManufacturerId is required")]
        public int ManufacturerId { get; set; } // Foreign key
        public Manufacturer Manufacturer { get; set; } // Navigation property
        public List<MedicinePrescription> medicinePrescriptions { get; set; }

    }
}

