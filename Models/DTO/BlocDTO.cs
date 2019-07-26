using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlocService.Models
{
    public class BlocDTO
    {
        public int Id { get; set; }
        public int NumberDone { get; set; }
        public string CotationVermin { get; set; }
        public string Location { get; set; }
    }
}