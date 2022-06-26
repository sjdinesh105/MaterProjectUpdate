using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public  class Summary
    {
        public int BedInUseCount { get; set; }
        public int BedInFreeCount { get; set; }
        public int PatientsAdmitedToday { get; set; }
        public Summary()
        {
            BedSummaryDetails = new List<BedSummary>();
        }

        public List<BedSummary> BedSummaryDetails { get; set; }
    }
}
