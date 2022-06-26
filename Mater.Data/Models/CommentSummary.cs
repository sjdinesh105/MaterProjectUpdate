using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public class CommentSummary
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Nurse { get; set; }
        public string Comment { get; set; }
    }
}
