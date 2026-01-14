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
        /// <returns>returns in IEnumerable DatabaseResult object.</returns>
        DatabaseResult GetAllVisitors();

        /// <summary>
        /// GetById Customer Database Method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        DatabaseResult GetByIdVisitor(int id);

        /// <summary>
        /// Add Customer Database Method.
        /// </summary>
        /// <param name="visitor">pass visitor as Visitor object.</param>
        DatabaseResult Add(Visitor visitor);
        #endregion [Database Methods]
    }
    #endregion [IVisitorRepository  Interface]
}
