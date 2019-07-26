using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlocAppAPI.Models
{
    public class Bloc
    {
        public int ID { get; set; }

        [Required]
        public DateTime AcheivedDate { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int NumberDone { get; set; }

        public int NumberFlashed { get; set; }

        // Foreign Key
        [Required]
        public int IDCotation { get; set; }

        // Navigation property
        public Cotation Cotation { get; set; }

    }
}
