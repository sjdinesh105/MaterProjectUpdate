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
    public class NurseResponseBuilder : INurseResponseBuilder
    {
        private readonly IConfiguration _configuration;
        public NurseResponseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Nurse> GetNurse()
        {
            try
            {
                var result = new NurseAccess(_configuration.GetConnectionString("MaterEntities")).GetNurse();
                return result;
            }
            catch (Exception ex)
            {
               
                throw;
            }
        }
    }
}
