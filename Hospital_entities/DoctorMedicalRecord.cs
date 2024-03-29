using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class DoctorMedicalRecord
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public int MedicalRecordId { get; set; }

    }
}
