using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.Models
{
    public class RequestGenerationDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Food Type")]
        public string Foodtype { get; set; }
        [Required(ErrorMessage = "Enter Preservation Hour")]
        public int Preservationtime { get; set; }
        [Required(ErrorMessage = "Enter Number of Packet")]
        public int Packetcount { get; set; }

        public int RID { get; set; }

    }
}