using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public List<Staff> staff { get; set; } = new List<Staff>();
        public List<Doctor> doctors { get; set; } = new List<Doctor>();
        public List<Operation> operations { get; set; } = new List<Operation> { };

    }
}
