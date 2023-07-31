using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Enter Your Email/Phone")]
        public string EmailorPhn { get; set; }
        [Required(ErrorMessage ="Enter Your Password")]
        public string pass { get; set; }
    }
}