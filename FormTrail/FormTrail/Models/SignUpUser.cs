using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormTrail.Models
{
    public class SignUpUser
    {
        [Required(ErrorMessage ="Please Provide Name")]
        [StringLength(20,ErrorMessage ="Size can not be more then 20")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide User Name")]
        [StringLength(10,ErrorMessage = "Size can not be more then 10")]
        public string Uname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Prof { get; set; }
        public string[] Hobbies { get; set; }
        [Required(ErrorMessage ="Please Select DOB")]
        public string DOB { get; set; }
    }
}