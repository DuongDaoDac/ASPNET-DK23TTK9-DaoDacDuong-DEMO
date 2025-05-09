using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Suanha3.Models
{
    public class Pricing
    {
        public int Id { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public string Price { get; set; }
        public int UnitPrice { get; internal set; }
        
        
    }
}