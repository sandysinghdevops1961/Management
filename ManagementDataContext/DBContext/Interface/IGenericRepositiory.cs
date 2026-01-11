using Dapper;
using System.Data;

namespace ManagementDataContext
{
    #region [GenericDatabase Repository Interface]
    /// <summary>
    /// Generic Repository Interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepositiory
    {
        #region [Methods]
        /// <summary>
        /// ExecuteAsync a stored procedure.
        /// </summary>
        /// <param name="procedureName">pass procedure name as string.</param>
        /// <param name="param">pass parameter as object.</param>
        /// <returns></returns>
        Task<int> ExecuteAsync(string procedureName, object? param = null);

        /// <summary>
        /// QuerySingleAsync a stored procedure.
        /// </summary>
        /// <param name="procedureName">pass procedureName as string.</param>
        /// <param name="param">pass param as object.</param>
        /// <returns></returns>
        Task<T> QuerySingleAsync<T>(string procedureName, object? param = null);

        /// <summary>
        /// QueryAsync a stored procedure.
        /// </summary>
        /// <param name="procedureName">pass procedureName as string.</param>
        /// <param name="param">pass param as object.</param>
        /// <returns></returns>
        Task<IEnumerable<T>> QueryAsync<T>(string procedureName, object? param = null);
        #endregion [Methods]
    }
    #endregion [GenericDatabase Repository Interface]
}
