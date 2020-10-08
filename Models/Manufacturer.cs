﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturerApp.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
      
        [Required]
        public string Name { get; set; }

        [Required]
        public string ManufacturerCode { get; set; }

        public string Comment { get; set; }
    }
}
