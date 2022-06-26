using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class CommentSummaryDTO
    {
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Nurse { get; set; }
        public string Comment { get; set; }
    }
}
