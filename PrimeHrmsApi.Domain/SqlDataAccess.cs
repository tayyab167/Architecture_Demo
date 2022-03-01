using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PrimeHrmsApi.Domain
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadListByProcedure<T, U>(
            string storedProcedure,
            U parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<T> LoadDataByProcedure<T, U>(
                  string storedProcedure,
                  U parameters,
                  string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return (await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure)).FirstOrDefault();
        }
        public async Task<T> LoadDataByQuery<T>(
                   string storedProcedure,
                   string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return (await connection.QueryAsync<T>(storedProcedure)).FirstOrDefault();
        }

        public async Task<IEnumerable<T>> LoadListByQuery<T>(
                string storedProcedure,
                string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(storedProcedure);
        }


       
    }
}