using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [ICustomerVisitiorService Interface]
    /// <summary>
    /// IVisitorService Business Service Interface.
    /// </summary>
    public interface IVisitorService
    {
        #region [Interface Methods]
        /// <summary>
        /// Get All Visitor businesss method.
        /// </summary>
        /// <returns>returns in IEnumerable Visitor object.</returns>
        BusinessResult GetVisitors();

        /// <summary>
        /// Get Visitor by Id business method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Visitor object.</returns>
        BusinessResult GetVisitor(int id);

        /// <summary>
        /// Create Visitor business method.
        /// </summary>
        /// <param name="visitior">pass visitor as Visitor object.</param>
        BusinessResult CreateVisitior(Visitor visitior);
        #endregion [Interface Methods]
    }
    #endregion [IVisitiorService Interface]
}
