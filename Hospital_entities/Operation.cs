using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Operation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Operation name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Operation name must be between 3 and 50 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Doctor Doctor { get; set; }
        public Department Department { get; set; }
        public List<PatientOperation> PatientOperations { get; set; } = new List<PatientOperation>();



    }
}
