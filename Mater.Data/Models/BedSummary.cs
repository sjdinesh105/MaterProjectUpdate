using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public class BedSummary
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Status { get; set; }
        public string Patient { get; set; }
        public DateTime? DOB { get; set; }
        public string PresentingIssue { get; set; }
        public string LastComment { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Nurse { get; set; }

       
    }
}
