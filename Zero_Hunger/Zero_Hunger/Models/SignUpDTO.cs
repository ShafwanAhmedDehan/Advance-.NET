using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{
    public class SignUpDTO
    {
        public int ID { get; set; }

        public int SerialNo { get; set; }

        [Required(ErrorMessage ="Enter your Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your Phone Number")]
        [RegularExpression(@"^01[3-9]\d{8}$", ErrorMessage = "Invalid Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter Your Password")]
        public string pass { get; set; }

        [Required(ErrorMessage = "Enter Restaurant Name")]
        [StringLength(100, ErrorMessage = "Name can not Exceed 100 Characters")]
        public string RestaurantName { get; set; }

        [Required(ErrorMessage = "Enter Restuarant Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Owner Name")]
        [StringLength(100, ErrorMessage ="Name can not Exceed 100 Characters")]
        [RegularExpression(@"^[A-Za-z\s.]+$" , ErrorMessage ="Name Only Content Letter, Space and Dot") ]
        public string OwnerName { get; set; }

        public int AcType { get; set; }
    }
}