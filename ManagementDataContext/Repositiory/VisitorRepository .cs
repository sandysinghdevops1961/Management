using Dapper;
using ManagementEntity;
using ManagementEntity.Model;
using ManagementUtility;
using System.Data;
using System.Threading.Tasks;

namespace ManagementDataContext
{
    #region [VisitorRepository DataContext Implementation]

    /// <summary>
    /// VisitorRepository  DataContext Implementation.
    /// </summary>
    public class VisitorRepository : IVisitorRepository
    {
        #region [Private Members]
        private readonly IDbContext dbContext;
        private DatabaseResult databaseResult;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerRepository.
        /// </summary>
        public VisitorRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
            databaseResult = new DatabaseResult();  
        }
        #endregion [Constructor]

        #region [DataContext Methods Implementation]

        /// <summary>
        /// Add Customer Database Method Implementation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public DatabaseResult Add(Visitor customer)
        {
            try
            {
                databaseResult.DatabaseRequest = customer;
                using (var connection = dbContext.CreateConnection())
                {
                  var ContextResponse= connection.ExecuteAsync("sp_customer",customer,commandType:CommandType.StoredProcedure);
                  databaseResult.DatabaseResponse = ContextResponse;
                  databaseResult.ResponseIsSuccess = true; // todo implement ternary operator
                }
            }
            catch (Exception ex)
            {
                databaseResult.ErrorMessage = ex.Message;
                databaseResult.ResponseIsSuccess = false;
            }
            return databaseResult;
        }

        /// <summary>
        /// GetAll Customer Database Method Implementation.
        /// </summary>
        /// <returns></returns>
        public DatabaseResult GetAll()
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
        /// GetById Customer Database Method Implementation.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DatabaseResult GetById(int id)
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
