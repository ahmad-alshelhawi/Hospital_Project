using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_entities
{
    public class Staff
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
        public string Number { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        [StringLength(50)]
        public string Role { get; set; }
    }
}
