using System.ComponentModel.DataAnnotations;

namespace MvcDemo.PL.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Code is Required")]

        public string Code { get; set; }
        [Required(ErrorMessage = "Department Name is Required")]
        [MinLength(3, ErrorMessage = "Department name must be 3 characters or more")]
        public string Name { get; set; }
    }
}
