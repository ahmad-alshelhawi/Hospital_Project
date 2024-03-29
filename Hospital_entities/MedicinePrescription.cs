using Hospital.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class MedicinePrescription
    {
        public int Id { get; set; }
        public Medicine Medicine { get; set; }
        public int MedicineId { get; set; }
        public Prescription Prescription { get; set; }
        public int PrescriptionId { get; set; }

    }
}
