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
    public class CommentResponseBuilder: ICommentResponseBuilder
    {
        private readonly IConfiguration _configuration;
        public CommentResponseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AddComment(Comment comment)
        {
            try
            {
                var result = new CommentAccess(_configuration.GetConnectionString("MaterEntities")).AddComment(comment);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
