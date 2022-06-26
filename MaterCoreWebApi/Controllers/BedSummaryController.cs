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
    public class BedSummaryController : ControllerBase
    {
        private readonly IBedSummaryResponseBuilder _builder;

        public BedSummaryController(IBedSummaryResponseBuilder builder) => _builder = builder;
        
        [HttpGet]
        public JsonResult GetBedSummary()
        {
            try
            {
                var colourPrefs = _builder.GetBedSummary();
                return new JsonResult(colourPrefs);
            }
            catch (Exception)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return new JsonResult(new Error { Message = Constants.ERROR_INTERNAL_SERVER_ERROR });
            }
        }
    }
}
