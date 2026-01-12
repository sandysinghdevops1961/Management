using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementDataService
{
    #region [ICustomerRepository Interface]
    /// <summary>
    /// ICustomerRepository Interface
    /// </summary>
    public interface ICustomerRepository
    {
        #region [Database Methods]
        /// <summary>
        /// GetAll Database Method.
        /// </summary>
        /// <returns>returns in IEnumerable Customer object.</returns>
        DataContextResult GetAll();

        /// <summary>
        /// GetById Customer Database Method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        DataContextResult GetById(int id);

        /// <summary>
        /// Add Customer Database Method.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        DataContextResult AddAsync(Customer customer);
        #endregion [Database Methods]
    }
    #endregion [ICustomerRepository Interface]
}
