using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Appointment
    {
        public int Id { get; set; }

        public int PatientID { get; set; }

        public Patient Patient { get; set; }

        public int DoctorID { get; set; }

        public Doctor Doctor { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDateTime { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
