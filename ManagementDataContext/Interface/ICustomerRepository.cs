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
        IEnumerable<Customer> GetAll();

        /// <summary>
        /// GetById Customer Database Method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        Customer GetById(int id);

        /// <summary>
        /// Add Customer Database Method.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        Task AddAsync(Customer customer);
        #endregion [Database Methods]
    }
    #endregion [ICustomerRepository Interface]
}
