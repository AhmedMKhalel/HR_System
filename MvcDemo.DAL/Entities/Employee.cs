using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo.DAL.Entities
{
    public class Employee
    {
        public Employee()
        {
            DateOfCreation = DateTime.Now;
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Name is Required")]
        [MinLength(5, ErrorMessage = "Employee name must be 5 characters to 50")]
        [MaxLength(50, ErrorMessage = "Employee name must be 5 characters to 50")]

        public string Name { get; set; }

        public int? Age { get; set; }
        public String Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string ImageUrl { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }







    }
}
