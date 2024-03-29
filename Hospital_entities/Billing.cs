using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Billing
    {
        public int Id { get; set; }

        public int PatientID { get; set; }

        public Patient Patient { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BillDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; }
    }

}
