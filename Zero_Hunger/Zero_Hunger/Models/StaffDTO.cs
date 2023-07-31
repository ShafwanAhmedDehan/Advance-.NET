using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{
    public class StaffDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Staff Name")]
        [StringLength(200, ErrorMessage = "Name can not Exceed 200 Characters")]
        [RegularExpression(@"^[A-Za-z\s.]+$", ErrorMessage = "Name Only Content Letter, Space and Dot")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        [RegularExpression(@"^01[3-9]\d{8}$", ErrorMessage = "Invalid Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter Passowrd")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Select Gender")]
        public string Gender { get; set; }

        public int AcType { get; set; }



    }
}