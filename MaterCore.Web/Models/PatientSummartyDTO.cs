using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class PatientSummaryDTO
    {
        public string Name { get; set; }
        public string URN { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime DOB { get; set; }
        public int BedNo { get; set; }
        public string Issue { get; set; }
        public PatientSummaryDTO()
        {
            CommentSummaryDetails = new List<CommentSummaryDTO>();
        }
        public List<CommentSummaryDTO> CommentSummaryDetails { get; set; }
    }
}
