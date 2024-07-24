using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        [RegularExpression(@"^\+?\d{0}\-?\d{10}$", ErrorMessage = "Invalid Phone Number.")]
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [Required(ErrorMessage = "Please select a date.")]
        [Display(Name = "Selected Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }
        public string projectName { get; set; }
        public string RoleName { get; set; }
        public string DepartmentName { get; set; }
    }
}