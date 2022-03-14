using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DataValidationMVC.Models
{
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int EmpId { get; set; }

        [Required(ErrorMessage ="Enter Name")]
        [DisplayName("Employee Name")]
        [StringLength(20,MinimumLength =3)]
        public string  Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email Address")]
       // [RegularExpression(@"^[a - z0 - 9][-a - z0 - 9._] +@([-a - z0 - 9] +.) +[a - z]{2, 5}$]",ErrorMessage ="Enter valid Email")]
        public string Email { get; set; }

        [Required]
        [Range(20000,500000,ErrorMessage ="saalry b/w 20k  to 5L")]
        public int Salary { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PostalCode,ErrorMessage ="Enter valid postal/zip code")]
        public int PostalCode { get; set; }
        [DataType(DataType.Url,ErrorMessage ="Enter a valid URL")]
        public string url { get; set; }
    }
}