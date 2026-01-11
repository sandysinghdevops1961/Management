using ManagementEntity.Model;

namespace ManagementService
{
    #region [CustomerService Business Service Implementation]
    /// <summary>
    /// CustomerService Business Service Implementation.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerService Business Service.
        /// </summary>
        public CustomerService()
        {
            // to do implement
        }
        #endregion [Constructor]

        #region [Business Service Methods Implementation]
        /// <summary>
        /// Create Customer of Business method implentation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public void CreateCustomer(Customer customer)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Get Customer by Id of Business method implentation.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return Customer object.</returns>
        public Customer GetCustomer(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return new Customer();
        }

        /// <summary>
        /// Get Customers of Business method implentationLogic.
        /// </summary>
        /// <returns>return IEnumerable of Customer object.</returns>
        public IEnumerable<Customer> GetCustomers()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            return new List<Customer>();
        }
        #endregion [Business Logic Implementation]
    }
    #endregion [CustomerService Business Service Implementation]
}
