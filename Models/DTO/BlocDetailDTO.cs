using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlocService.Models
{
    public class BlocDetailDTO
    {
        public int Id { get; set; }
        public DateTime AcheivedDate { get; set; }
        public string Location { get; set; }
        public int NumberDone { get; set; }
        public int NumberFlashed { get; set; }
        public string CotationVermin { get; set; }
        public string CotationFrancais { get; set; }
    }
}