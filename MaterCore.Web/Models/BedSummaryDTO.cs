using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class BedSummaryDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Status { get; set; }
        public string Patient { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? DOB { get; set; }
        public string PresentingIssue { get; set; }
        public string LastComment { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm:ss}")]
        public DateTime? LastUpdate { get; set; }
        public string Nurse { get; set; }
        public int BedInUseCount { get; set; }
        public int BedInFreeCount { get; set; }
        public int PatientsAdmitedToday { get; set; }
    }
}
