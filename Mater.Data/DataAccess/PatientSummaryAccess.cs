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
    public class PatientSummaryAccess : DapperBaseCore
    {
        public PatientSummaryAccess(string connectionString) : base(connectionString)
        {

        }

        public PatientSummary GetPatientSummary(int patientId)
        {
            object param = new
            {
                PatientId= patientId
            };
            var result = new PatientSummary();
            using (var connection = new SqlConnection(ConnectionString))
            {
                var multiple = connection.QueryMultiple("GetPatientSummary", param,
                    commandType: CommandType.StoredProcedure);
                result.Name = multiple.ReadFirst<string>();
                result.URN = multiple.ReadFirst<string>();
                result.DOB = multiple.ReadFirst<DateTime>();
                result.BedNo = multiple.ReadFirst<int>();
                result.Issue = multiple.ReadFirst<string>();
                result.CommentSummaryDetails = multiple.Read<Models.CommentSummary>().ToList();
            }
            return result;
        }

        public List<Patient> GetPatients()
        {
            object param = null;
             var result = ExecuteStoredProc<Patient>("Get_Patient", param).ToList();
             return result;
        }


        public bool AddComment(Admit admit)
        {
            object param = new
            {
                admit.BedId,
                admit.PatientId,
                admit.PresentingIssue,
                admit.LastComment,
                admit.NurseId
            };
            var result = ExecuteStoredProcFirstOrDefault<bool>("Admit_Patient", param);
            return result;

        }
    }
}
