using Mater.Data.Models;
using MaterCore.WebApi.Builders.Interfaces;
using MaterCore.WebApi.ResponseObj;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MaterCore.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    [AllowAnonymous]
    public class PatientController : ControllerBase
    {
        private readonly IPatientResponseBuilder _builder;

        public PatientController(IPatientResponseBuilder builder) => _builder = builder;
        
        [HttpPost]
        public JsonResult GetPatientSummary([FromBody] int patientID)
        {
            try
            {
                var patientsummary = _builder.GetPatientSummary(patientID);
                return new JsonResult(patientsummary);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return new JsonResult(new Error { Message = Constants.ERROR_INTERNAL_SERVER_ERROR });
            }
        }

        [HttpGet]
        public JsonResult GetPatients()
        {
            try
            {
                var patients = _builder.GetPatients();
                return new JsonResult(patients);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return new JsonResult(new Error { Message = Constants.ERROR_INTERNAL_SERVER_ERROR });
            }
        }

        [HttpPost]
        public JsonResult AdmitPatient([FromBody] Admit admit)
        {
            try
            {
                var commentResult = _builder.AdmitPatient(admit);
                return new JsonResult(commentResult);
            }
            catch (Exception)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return new JsonResult(new Error { Message = Constants.ERROR_INTERNAL_SERVER_ERROR });
            }
        }
    }
}
