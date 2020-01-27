using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ClientDev.Models
{
    [Serializable]
    [JsonObject]
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(20, MinimumLength =5)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}