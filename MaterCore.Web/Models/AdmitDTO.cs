using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.Web.Models
{
    public class AdmitDTO
    {
        public int BedId { get; set; }

        public int PatientId { get; set; }
        public  List<SelectListItem> Patients { get; set; }
        public string PresentingIssue { get; set; }
        public string LastComment { get; set; }
        public int NurseId { get; set; }
       
    }
}
