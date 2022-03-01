using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeHrmsApi.Domain
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadListByProcedure<T, U>(string storedProcedure, U parameters, string connectionId = "PrimeHrms");
        Task<T> LoadDataByProcedure<T, U>(string storedProcedure, U parameters, string connectionId = "PrimeHrms");
        Task<IEnumerable<T>> LoadListByQuery<T>(string Query,  string connectionId = "PrimeHrms");
        Task<T> LoadDataByQuery<T>(string Query,  string connectionId = "PrimeHrms");
    }
}