using ManagementEntity.Model;

namespace ManagementService
{
    #region [ICustomerService Interface]
    /// <summary>
    /// ICustomerService Business Service Interface.
    /// </summary>
    public interface ICustomerService
    {
        #region [Interface Methods]
        /// <summary>
        /// Get All Customers businesss method.
        /// </summary>
        /// <returns>returns in IEnumerable Customer object.</returns>
        IEnumerable<Customer> GetCustomers();

        /// <summary>
        /// Get Customer by Id business method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        Customer GetCustomer(int id);

        /// <summary>
        /// Create Customer business method.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        void CreateCustomer(Customer customer);
        #endregion [Interface Methods]
    }
    #endregion [ICustomerService Interface]
}
