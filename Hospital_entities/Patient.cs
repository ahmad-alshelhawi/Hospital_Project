using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Patient
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public List<Appointment> appointments { get; set; } = new List<Appointment>();
        public List<PatientOperation> patient_operations { get; set; } = new List<PatientOperation>();
        public List<MedicalRecord> medicalRecords { get; set; } = new List<MedicalRecord>();
        public List<Billing> billing { get; set; } = new List<Billing>();
        public List<Prescription> prescriptions { get; set; } = new List<Prescription>();
    }
}
