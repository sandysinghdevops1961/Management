using ManagementDataContext;
using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [CustomerService Business Service Implementation]
    /// <summary>
    /// CustomerService Business Service Implementation.
    /// </summary>
    public class VisitiorService : IVisitorService
    {
        #region [Private Members]
        private readonly IVisitorRepository _customerRepo;
        private BusinessResult businessResult;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of VisitiorService Business Service.
        /// </summary>
        public VisitiorService(IVisitorRepository customerRepo)
        {
            _customerRepo = customerRepo;
            businessResult = new BusinessResult();
        }
        #endregion [Constructor]

        #region [Business Service Methods Implementation]
        /// <summary>
        /// Create Customer of Business method implentation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public BusinessResult CreateVisitior(Visitor customer)
        {
            try
            {
                businessResult.BusinessRequest = customer;
                _customerRepo.Add(customer);
            }
            catch (Exception ex)
            {

            }
            return businessResult;
        }

        /// <summary>
        /// Get Customer by Id of Business method implentation.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return Customer object.</returns>
        public BusinessResult GetCustomer(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return new BusinessResult();
        }

        /// <summary>
        /// Get Customers of Business method implentationLogic.
        /// </summary>
        /// <returns>return IEnumerable of Customer object.</returns>
        public BusinessResult GetCustomers()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            return new BusinessResult();
        }
        #endregion [Business Logic Implementation]
    }
    #endregion [CustomerService Business Service Implementation]
}
