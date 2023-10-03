using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MvcDemo.DAL.Entities;

namespace MvcDemo.PL.Models
{
    public class EmployeeViewModel
    {
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
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentViewModel Department { get; set; }



    }
}
