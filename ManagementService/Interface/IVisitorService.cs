using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [IVisitiorService Interface]
    /// <summary>
    /// IVisitorService Business Service Interface.
    /// </summary>
    public interface IVisitorService
    {
        #region [Interface Methods]
        /// <summary>
        /// Get All Visitors businesss method.
        /// </summary>
        /// <returns>returns in BusinessResult object.</returns>
        Task<BusinessResult> GetVisitors();

        /// <summary>
        /// Get Visitor by Id business method.
        /// </summary>
        /// <param name="id">pass visitorId as integer.</param>
        /// <returns>return single Visitor object.</returns>
        Task<BusinessResult> GetVisitor(int id);

        /// <summary>
        /// Create Visitor business method.
        /// </summary>
        /// <param name="visitior">pass visitor as Visitor object.</param>
        Task<BusinessResult> CreateVisitior(Visitor visitior);
        #endregion [Interface Methods]
    }
    #endregion [IVisitiorService Interface]
}
