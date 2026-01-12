using Dapper;
using ManagementEntity;
using ManagementEntity.Model;
using ManagementUtility;

namespace ManagementDataService
{
    #region [CustomerRepository DataContext Implementation]

    /// <summary>
    /// CustomerRepository DataContext Implementation.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        #region [Private Members]
        private readonly IDbContext dbContext;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerRepository.
        /// </summary>
        public CustomerRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        #endregion [Constructor]

        #region [DataContext Methods Implementation]

        /// <summary>
        /// Add Customer Database Method Implementation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public async DataContextResult AddAsync(Customer customer)
        {
            try
            {
                using (var connection = dbContext.CreateConnection())
                {
                    await connection.ExecuteAsync("",customer,commandType:System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// GetAll Customer Database Method Implementation.
        /// </summary>
        /// <returns></returns>
        public DataContextResult GetAll()
        {
            try
            {

            }
            catch (Exception)
            {
                
            }
            return new List<Customer>();
        }

        /// <summary>
        /// GetById Customer Database Method Implementation.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataContextResult GetById(int id)
        {
            try
            {

            }
            catch (Exception)
            {

            }
            return new Customer();
        }
        #endregion [DataContext Methods Implementation]
    }
    #endregion [CustomerRepository DataContext Implementation]
}
