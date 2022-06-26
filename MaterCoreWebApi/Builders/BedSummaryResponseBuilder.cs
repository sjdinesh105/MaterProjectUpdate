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
    public class BedSummaryResponseBuilder : IBedSummaryResponseBuilder
    {
        private readonly IConfiguration _configuration;
        public BedSummaryResponseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Summary GetBedSummary()
        {
            try
            {
                var result = new BedSummaryAccess(_configuration.GetConnectionString("MaterEntities")).GetBedSummary();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
