using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mater.Data
{
    public class DapperBaseCore
    {
        protected string ConnectionString { get; set; }


        public DapperBaseCore(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected dynamic ToExpandoObject(object value)
        {
            var dapperRowProperties = value as IDictionary<string, object>;

            IDictionary<string, object> expando = new ExpandoObject();

            if (dapperRowProperties == null) return (ExpandoObject)expando;

            foreach (var property in dapperRowProperties)
            {
                if (property.Value == null) continue;
                expando.Add(property.Key, property.Value);
            }

            return (ExpandoObject)expando;
        }

        protected dynamic ToExpandoObjectWithNulls(object value)
        {
            var dapperRowProperties = value as IDictionary<string, object>;

            IDictionary<string, object> expando = new ExpandoObject();

            if (dapperRowProperties == null) return (ExpandoObject)expando;

            foreach (var property in dapperRowProperties) expando.Add(property.Key, property.Value ?? string.Empty);

            return (ExpandoObject)expando;
        }

        protected dynamic TypeToExpandoObjectWithNulls(object value, Type t, string propertiesToExclude = "")
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (var property in t.GetProperties())
                if (!propertiesToExclude.Contains(property.Name))
                    expando.Add(property.Name,
                        value.GetType().GetProperty(property.Name)?.GetValue(value) ?? string.Empty);

            return (ExpandoObject)expando;
        }

        protected List<ExpandoObject> ExecuteStoredProcExpando(string storedProc, object param)
        {
            List<dynamic> result;
            using (IDbConnection dataContext = new SqlConnection(ConnectionString))
            {
                dataContext.Open();
                result = dataContext.Query<dynamic>(storedProc, param, commandType: CommandType.StoredProcedure,
                    commandTimeout: 600).ToList();
                dataContext.Close();
            }

            return result.Select(row => ToExpandoObject(row)).Select(dummy => (ExpandoObject)dummy).ToList();
        }

        protected List<ExpandoObject> ExecuteStoredProcExpandoWithNulls(string storedProc, object param)
        {
            List<dynamic> result;
            using (IDbConnection dataContext = new SqlConnection(ConnectionString))
            {
                dataContext.Open();
                result = dataContext.Query<dynamic>(storedProc, param, commandType: CommandType.StoredProcedure,
                    commandTimeout: 600).ToList();
                dataContext.Close();
            }

            return result.Select(row => ToExpandoObjectWithNulls(row)).Select(dummy => (ExpandoObject)dummy).ToList();
        }

        protected List<T> ExecuteStoredProc<T>(string storedProc, object param, int timeout = 30)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var result = dataContext.Query<T>(storedProc, param, commandType: CommandType.StoredProcedure,
                commandTimeout: timeout).ToList();
            dataContext.Close();

            return result;
        }

        protected async Task<List<T>> ExecuteStoredProcAsync<T>(string storedProc, object param, int timeout = 30)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var temp = await dataContext.QueryAsync<T>(storedProc, param, commandType: CommandType.StoredProcedure,
                commandTimeout: timeout);
            var result = temp.ToList();
            dataContext.Close();

            return result;
        }

        protected T ExecuteStoredProcFirstOrDefault<T>(string storedProc, object param)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var result = dataContext.QueryFirstOrDefault<T>(storedProc, param,
                commandType: CommandType.StoredProcedure);
            dataContext.Close();

            return result;
        }

        protected async Task<T> ExecuteStoredProcFirstOrDefaultAsync<T>(string storedProc, object param, int timeout = 30)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var result = await dataContext.QueryFirstOrDefaultAsync<T>(storedProc, param,
                commandType: CommandType.StoredProcedure, commandTimeout: timeout);
            dataContext.Close();

            return result;
        }

        protected List<T> ExecuteQuery<T>(string sql, object param)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var result = dataContext.Query<T>(sql, param).ToList();
            dataContext.Close();

            return result;
        }

        protected async Task<List<T>> ExecuteQueryAsync<T>(string sql, object param)
        {
            using IDbConnection dataContext = new SqlConnection(ConnectionString);
            dataContext.Open();
            var temp = await dataContext.QueryAsync<T>(sql, param);
            var result = temp.ToList();
            dataContext.Close();

            return result;
        }

       
    }
}

