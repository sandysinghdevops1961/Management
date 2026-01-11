using Dapper;
using ManagementDataContext;
using System.Data;

namespace ManagementDataContext
{
    #region [GenericDatabase Implementation]
    public class GenericRepositiory : IGenericRepositiory
    {
        private readonly IUnitOfWork _uow;

        #region [Constructor]
        /// <summary>
        /// Generic Repository Constructor.
        /// </summary>
        public GenericRepositiory(IUnitOfWork uow)
        {
            _uow = uow;
        }
        #endregion [Constructor]

        #region [Methods]
        /// <summary>
        /// ExecuteAsync a stored procedure.
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> ExecuteAsync(string procedureName, object? param = null)
        {
            return await _uow.Connection.ExecuteAsync(procedureName,param, _uow.Transaction, commandType: CommandType.StoredProcedure);

        }

        /// <summary>
        /// QuerySingleAsync a stored procedure.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> QuerySingleAsync<T>(string procedureName, object? param = null)
        {
            return await _uow.Connection.QuerySingleAsync<T>(procedureName, param, _uow.Transaction, commandType: CommandType.StoredProcedure);

        }

        /// <summary>
        /// QueryAsync a stored procedure.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="procedureName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<T>> QueryAsync<T>(string procedureName, object? param = null)
        {
            return await _uow.Connection.QueryAsync<T>(
            procedureName,
            param,
            _uow.Transaction,
            commandType: CommandType.StoredProcedure
        );
        }
        #endregion [Methods]
    }
    #endregion [GenericDatabase Implementation]
}
