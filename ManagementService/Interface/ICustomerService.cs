using ManagementEntity;
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
        BusinessContextResult GetCustomers();

        /// <summary>
        /// Get Customer by Id business method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        BusinessContextResult GetCustomer(int id);

        /// <summary>
        /// Create Customer business method.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        BusinessContextResult CreateCustomer(Customer customer);
        #endregion [Interface Methods]
    }
    #endregion [ICustomerService Interface]
}
