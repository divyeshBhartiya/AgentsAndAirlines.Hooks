﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.Web.Models
{
    public class FlightDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FlightCode { get; set; }
        [Column(TypeName = "decimal(6,2")]
        [Required]
        public decimal Price { get; set; }
    }
}
