using ManagementDataService;
using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [CustomerService Business Service Implementation]
    /// <summary>
    /// CustomerService Business Service Implementation.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        #region [Private Members]
        private readonly ICustomerRepository _customerRepo;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerService Business Service.
        /// </summary>
        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }
        #endregion [Constructor]

        #region [Business Service Methods Implementation]
        /// <summary>
        /// Create Customer of Business method implentation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public BusinessContextResult CreateCustomer(Customer customer)
        {
            try
            {
                _customerRepo.AddAsync(customer);
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
        public BusinessContextResult GetCustomer(int id)
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
        public BusinessContextResult GetCustomers()
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
