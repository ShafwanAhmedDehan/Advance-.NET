using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSystem.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        [RegularExpression(@"^[a-zA-Z\s\.]+$", ErrorMessage = "Invaild Name")]
        [StringLength(100, ErrorMessage = "Size can not be more then 100")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Your Username")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Invaild Username [Avoid Space]")]
        [StringLength(15, ErrorMessage = "Size can not be more then 15")]
        public string Uname { get; set; }
        [Required (ErrorMessage ="Please Select Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Select Your Profession")]
        public string[] Prof { get; set; }
        [Required(ErrorMessage = "Please Enter Your Student ID")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "Invaild Student ID [example: XX-XXXXX-X(1-3) ]")]
        public string SID { get; set; }
        [Required(ErrorMessage = "Enter Email Address")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]@student\.aiub\.edu$", ErrorMessage = "Invaild Email [example: XX-XXXXX-X(1-3)@student.aiub.edu ]")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Select Your Date of Birth")]
        [DOBValidation(20, ErrorMessage ="Your age Should be more then 20")]
        public DateTime DOB { get; set; }
    } 
}