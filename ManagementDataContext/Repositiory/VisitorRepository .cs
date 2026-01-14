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
        public DatabaseResult Add(Visitor visitor)
        {
            try
            {
                databaseResult.DatabaseRequest = visitor;
                using (var connection = dbContext.CreateConnection())
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@VisitorName", visitor.VisitorName);
                    parameters.Add("@VisitorMobileNo", visitor.VisitorMobileNo);
                    parameters.Add("@VisitorComingFrom", visitor.VisitorComingFrom);
                    parameters.Add("@WhomToSee", visitor.WhomToSee);
                    parameters.Add("@Purpose", visitor.Purpose);

                  var ContextResponse= connection.ExecuteAsync("usp_InsertVisitor", parameters, commandType:CommandType.StoredProcedure);
                  databaseResult.DatabaseResponse = ContextResponse.Result;
                  databaseResult.ResponseIsSuccess = true; // todo implement ternary operator
                  databaseResult.ErrorMessage=string.Empty;
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
        /// GetAll Visitor Database Method Implementation.
        /// </summary>
        /// <returns></returns>
        public DatabaseResult GetAllVisitors()
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
        public DatabaseResult GetByIdVisitor(int id)
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
