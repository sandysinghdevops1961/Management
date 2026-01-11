using ManagementEntity.Model;
using System.Net.Http.Headers;

namespace ManagementDataService.Repositiory
{
    #region [CustomerRepository DataContext Implementation]

    /// <summary>
    /// CustomerRepository DataContext Implementation.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerRepository.
        /// </summary>
        public CustomerRepository()
        {
            // to do implement
        }
        #endregion [Constructor]

        #region [DataContext Methods Implementation]

        /// <summary>
        /// Add Customer Database Method Implementation.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        public void Add(Customer customer)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// GetAll Customer Database Method Implementation.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAll()
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
        public Customer GetById(int id)
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
