using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalPt1.Models
{
    public class NumbersViewModel
    {
        [Required]
        [Range(1,1000)]
        public int A { get; set; }
        [Required]
        [Range(1,1000)]
        public int B { get; set; }
        public int Sum { get; set; }
    }
}