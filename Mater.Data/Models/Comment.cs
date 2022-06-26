using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.Models
{
    public class Comment
    {
        public int BedId { get; set; }
        public string Comments { get; set; }
        public int NurseId { get; set; }
        public bool IsDischarge { get; set; }
    }
}
