using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlocService.Models
{
    public class Cotation
    {
        public int Id { get; set; }
        [Required]
        public string Vermin { get; set; }
        public string Francais { get; set; }
    }
}