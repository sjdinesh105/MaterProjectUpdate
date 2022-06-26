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
    public class CommentController : ControllerBase
    {
        private readonly ICommentResponseBuilder _builder;

        public CommentController(ICommentResponseBuilder builder) => _builder = builder;
        
        [HttpPost]
        public JsonResult AddComment([FromBody] Comment comment)
        {
            try
            {
                var commentResult = _builder.AddComment(comment);
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
