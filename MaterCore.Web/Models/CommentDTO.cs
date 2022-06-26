using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class CommentDTO
    {
        public int BedId { get; set; }
        public string Comments { get; set; }
        public int NurseId { get; set; }
        public bool IsDischarge { get; set; }
    }
}
