using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Specialization { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }
        public List<Appointment> appointments { get; set; } = new List<Appointment>();
        public List<DoctorMedicalRecord> doctorMedicalRecord { get; set; } = new List<DoctorMedicalRecord>();
        public List<Prescription> prescriptions { get; set; } = new List<Prescription>();
    }
}
