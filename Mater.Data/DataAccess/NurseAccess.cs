using Mater.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data.DataAccess
{
    public class NurseAccess : DapperBaseCore
    {
        public NurseAccess(string connectionString) : base(connectionString)
        {

        }
        public List<Nurse> GetNurse()
        {
            object param = null;

            var result =
                ExecuteStoredProc<Nurse>("GetNurse", param).ToList();
            return result;
        }
    }
   
}
