using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiThi2.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Không được để trống")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public double Salary { get; set; }
    }
}