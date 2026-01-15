using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementDataContext
{
    #region [IVisitorRepository  Interface]
    /// <summary>
    /// VisitorRepository  Interface
    /// </summary>
    public interface IVisitorRepository
    {
        #region [Database Methods]
        /// <summary>
        /// GetAll Database Method.
        /// </summary>
        /// <returns>returns in DatabaseResult object.</returns>
        Task<DatabaseResult> GetAllVisitors();

        /// <summary>
        /// GetByIdVisitor Visitor Database Method.
        /// </summary>
        /// <param name="id">pass visitor id as integer.</param>
        /// <returns>return in DatabaseResult object.</returns>
        Task<DatabaseResult> GetByIdVisitor(int id);

        /// <summary>
        /// Add Visitor Database Method.
        /// </summary>
        /// <param name="visitor">pass visitor as Visitor object.</param>
        Task<DatabaseResult> AddAsync(Visitor visitor);
        #endregion [Database Methods]
    }
    #endregion [IVisitorRepository  Interface]
}
