using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Demo
{
    public class Employee
    {
        //Attribute will accept data type of text only
        [Required(ErrorMessage = " Employee {0} is Requred")]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="name should be minimum and maximum 100")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18,90,ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
