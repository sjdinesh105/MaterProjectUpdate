using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public class PatientSummary
    {
        public string Name { get; set; }
        public string URN { get; set; }
        public DateTime DOB { get; set; }
        public int BedNo { get; set; }
        public string Issue { get; set; }
        public PatientSummary()
        {
            CommentSummaryDetails = new List<CommentSummary>();
        }
        public List<CommentSummary> CommentSummaryDetails { get; set; }
    }
}
