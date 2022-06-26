using Mater.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.WebApi.Builders.Interfaces
{
    public interface IPatientResponseBuilder
    {
        Mater.Data.Models.PatientSummary GetPatientSummary(int patientId);
        bool AdmitPatient(Admit admit);
        List<Mater.Data.Models.Patient> GetPatients();
    }
}
