using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class PatientOperation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public Operation Operation { get; set; }
        public int OperationId { get; set; }

    }
}
