using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormSystem.Models
{
    public class DOBValidationAttribute : ValidationAttribute
    {
        private int Age { get; set; }

        public DOBValidationAttribute(int Age)
        {
            this.Age = Age;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age = 0;
            age = DateTime.Now.Year - Convert.ToDateTime(value).Year;
            if (age >= Age)
            {
                return ValidationResult.Success;
            }
               
            else
            {
                return new ValidationResult($"You must be at least {Age} years old.");
            }
        }
    }
}