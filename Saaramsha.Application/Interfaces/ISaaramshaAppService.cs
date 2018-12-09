using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Saaramsha.Application.Models;


namespace Saaramsha.Application.Interfaces
{
    public interface ISaaramshaAppService
    {

        Task<T> QueryOne<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<IList<T>> QueryList<T>(DynamicParameters parameterModel, DBConnection connection) where T : new();

        Task<int> Execute(DynamicParameters parameterModel, DBConnection connection);
    }
}
