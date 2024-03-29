using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Prescription
    {
        public int Id { get; set; }

        public int PatientID { get; set; }

        public Patient Patient { get; set; }

        public int DoctorID { get; set; }

        public Doctor Doctor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PrescriptionDate { get; set; }

        [StringLength(500)]
        public string Medication { get; set; }

        [StringLength(50)]
        public string Dosage { get; set; }

        [StringLength(50)]
        public string Frequency { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }
        public List<MedicinePrescription> medicinePrescriptions { get; set; }

    }

}
