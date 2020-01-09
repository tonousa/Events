﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Binding
{
    public class CustomChecks
    {
        public static ValidationResult CheckZip(string zipCode)
        {
            return zipCode != null && zipCode.ToLower().StartsWith("ny") ?
                ValidationResult.Success : new ValidationResult("Enter a NY zip code");
        }
    }
}