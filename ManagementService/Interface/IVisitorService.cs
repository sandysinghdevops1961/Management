using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [ICustomerVisitiorService Interface]
    /// <summary>
    /// IVisitiorService Business Service Interface.
    /// </summary>
    public interface IVisitorService
    {
        #region [Interface Methods]
        /// <summary>
        /// Get All Visitior businesss method.
        /// </summary>
        /// <returns>returns in IEnumerable Customer object.</returns>
        BusinessResult GetCustomers();

        /// <summary>
        /// Get Customer by Id business method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        BusinessResult GetCustomer(int id);

        /// <summary>
        /// Create visitior business method.
        /// </summary>
        /// <param name="visitior">pass visitior as Visitor object.</param>
        BusinessResult CreateVisitior(Visitor visitior);
        #endregion [Interface Methods]
    }
    #endregion [IVisitiorService Interface]
}
