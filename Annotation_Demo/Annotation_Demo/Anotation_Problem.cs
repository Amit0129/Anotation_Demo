using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Demo
{
    public class Anotation_Problem
    {
        //Data Annotations is called an attribute.
        //It help us to understand what is hppening in a text after we have read it.
        //It comes Under System.ComponetModel.DataAnotations.
        //It is used for data validation.
        public void Display()
        {
            Employee employee = new Employee();
            employee.Name = "Amit";
            employee.Age = 30;
            employee.PhoneNumber = "9090247978";
            employee.Email = "amit@gmail.com";
            ValidationContext context = new ValidationContext(employee);
            List<ValidationResult> validationResult = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, validationResult,true);
            if (!valid)
            {
                foreach (ValidationResult result in validationResult)
                {
                    Console.WriteLine(result.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine(result.ErrorMessage,Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
