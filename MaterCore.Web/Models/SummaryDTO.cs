using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class SummaryDTO
    {
        public int BedInUseCount { get; set; }
        public int BedInFreeCount { get; set; }
        public int PatientsAdmitedToday { get; set; }
        public SummaryDTO()
        {
            BedSummaryDetails = new List<BedSummaryDTO>();
        }
        public List<BedSummaryDTO> BedSummaryDetails { get; set; }
    }
}
