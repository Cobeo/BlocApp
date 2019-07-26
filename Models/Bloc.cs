using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlocService.Models
{
    public class Bloc
    {
        public int Id { get; set; }
        [Required]
        public DateTime AcheivedDate { get; set; }
        public string Location { get; set; }
        public int NumberDone { get; set; }
        public int NumberFlashed { get; set; }

        // Foreign Key
        public int CotationId { get; set; }
        // Navigation property
        public Cotation Cotation { get; set; }
    }
}