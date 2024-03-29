using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        public int PatientID { get; set; }

        public Patient Patient { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RecordDate { get; set; }

        [StringLength(500)]
        public string Diagnosis { get; set; }

        [StringLength(1000)]
        public string Treatment { get; set; }
        public List<DoctorMedicalRecord> DoctorMedicalRecords { get; set; }
    }
}
