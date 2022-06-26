using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public class Admit
    {
        public int BedId { get; set; }
        public int PatientId { get; set; }
        public string PresentingIssue { get; set; }
        public string LastComment { get; set; }
        public int NurseId { get; set; }

    }
}
