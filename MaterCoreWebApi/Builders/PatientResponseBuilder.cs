using Mater.Data.DataAccess;
using Mater.Data.Models;

using MaterCore.WebApi.Builders.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.WebApi.Builders
{
    public class PatientResponseBuilder : IPatientResponseBuilder
    {
        private readonly IConfiguration _configuration;
        public PatientResponseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public PatientSummary GetPatientSummary(int patientId)
        {
            try
            {
                var result = new PatientSummaryAccess(_configuration.GetConnectionString("MaterEntities")).GetPatientSummary(patientId);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Patient> GetPatients()
        {
            try
            {
                var result = new PatientSummaryAccess(_configuration.GetConnectionString("MaterEntities")).GetPatients();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool AdmitPatient(Admit admit)
        {
            try
            {
                var result = new PatientSummaryAccess(_configuration.GetConnectionString("MaterEntities")).AddComment(admit);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
