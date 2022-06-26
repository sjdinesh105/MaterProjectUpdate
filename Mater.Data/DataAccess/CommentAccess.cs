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
    public class CommentAccess : DapperBaseCore
    {
        public CommentAccess(string connectionString) : base(connectionString)
        {

        }
        public bool AddComment(Comment comment)
        {
            object param = new
            {   comment.BedId,
                comment.Comments,
                comment.NurseId,
                comment.IsDischarge
            };
            var result = ExecuteStoredProcFirstOrDefault<bool>("Add_Comments", param);
            return result;

        }
    }
}
