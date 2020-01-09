using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Binding.Models
{
    public class Person
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
    }
}