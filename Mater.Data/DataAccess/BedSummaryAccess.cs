using Dapper;
using Mater.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.DataAccess
{
    public class BedSummaryAccess : DapperBaseCore
    {
        public BedSummaryAccess(string connectionString) : base(connectionString)
        {

        }
        public Summary GetBedSummary()
        {
            object param = null;
            var result = new Summary();
            using (var connection = new SqlConnection(ConnectionString))
            {
                var multiple = connection.QueryMultiple("GetBedSummary", param,
                    commandType: CommandType.StoredProcedure);
                result.BedInUseCount = multiple.ReadFirst<int>();
                result.BedInFreeCount = multiple.ReadFirst<int>();
                result.PatientsAdmitedToday= multiple.ReadFirst<int>();
                result.BedSummaryDetails = multiple.Read<Models.BedSummary>().ToList();
                  
            }

            //var result =
            //    ExecuteStoredProc<BedSummary>("GetBedSummary", param).ToList();
            return result;
        }
    }
}
