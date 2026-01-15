using Dapper;
using ManagementEntity;
using ManagementEntity.Model;
using ManagementUtility;
using System.Data;
using System.Reflection;
using System.Transactions;

namespace ManagementDataContext
{
    #region [VisitorRepository DataContext Implementation]

    /// <summary>
    /// VisitorRepository  DataContext Implementation.
    /// </summary>
    public class VisitorRepository : IVisitorRepository
    {
        #region [Private Members]
        /// <summary>
        /// Declare IDbContext variable.
        /// </summary>
        private readonly IDbContext dbContext;

        /// <summary>
        /// Declare DatabaseResult variable.
        /// </summary>
        private DatabaseResult databaseResult;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of VisitorRepository.
        /// </summary>
        public VisitorRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
            databaseResult = new DatabaseResult();
        }
         #endregion [Constructor]

        #region [DataContext Methods Implementation]

        /// <summary>
        /// Add Visitor Database Method Implementation.
        /// </summary>
        /// <param name="visitor">pass visitor as Visitor object.</param>
        public async Task<DatabaseResult> AddAsync(Visitor visitor)
        {
            databaseResult.DatabaseRequest = visitor;
            using var connection = dbContext.CreateConnection();
            using var transaction = connection.BeginTransaction();
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@VisitorName", visitor.VisitorName);
                parameters.Add("@VisitorMobileNo", visitor.VisitorMobileNo);
                parameters.Add("@VisitorComingFrom", visitor.VisitorComingFrom);
                parameters.Add("@WhomToSee", visitor.WhomToSee);
                parameters.Add("@Purpose", visitor.Purpose);
                await connection.ExecuteAsync("usp_InsertVisitor",parameters,transaction: transaction,commandType: CommandType.StoredProcedure);
                transaction.Commit();
                databaseResult.Success = true;
                databaseResult.Message = "Success";
                databaseResult.MessageCode = MessageCode.Success;
                databaseResult.MethodName = MethodBase.GetCurrentMethod()?.Name;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                databaseResult.Success = false;
                databaseResult.Message = ex.Message;
                databaseResult.MessageCode = MessageCode.RuntimeDatabaseException;
                databaseResult.MethodName = MethodBase.GetCurrentMethod()?.Name;
                throw;
            }

            return databaseResult;
        }


        /// <summary>
        /// GetAll Visitor Database Method Implementation.
        /// </summary>
        /// <returns></returns>
        public async Task<DatabaseResult> GetAllVisitors()
        {
            try
            {
                // to do implement database logic for all customer.
            }
            catch (Exception)
            {

            }
            return databaseResult;
        }

        /// <summary>
        /// GetById Visitor Database Method Implementation.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DatabaseResult> GetByIdVisitor(int id)
        {
            try
            {
                // to do implement database logic for get customer by id.
            }
            catch (Exception)
            {

            }
            return databaseResult;
        }
        #endregion [DataContext Methods Implementation]
    }
    #endregion [VisitorRepository DataContext Implementation]
}
