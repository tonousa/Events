using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Binding.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "Enter name")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="3-20 chars")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage ="only alpha chars")]
        public string Name { get; set; }

        [Required(ErrorMessage ="enter age")]
        [Range(5,100, ErrorMessage ="only 5-100")]
        public int Age { get; set; }

        public string Cell { get; set; }

        [CustomValidation(typeof(Binding.CustomChecks), "CheckZip")]
        public string Zip { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext
            validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Name == "Bob" && Age < 20)
            {
                errors.Add(
                    new ValidationResult("Bob under 20, not allowed"));
            }
            return errors;
        }
    }
}