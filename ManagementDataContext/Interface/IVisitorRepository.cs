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
        /// <returns>returns in IEnumerable Customer object.</returns>
        DatabaseResult GetAll();

        /// <summary>
        /// GetById Customer Database Method.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return single Customer object.</returns>
        DatabaseResult GetById(int id);

        /// <summary>
        /// Add Customer Database Method.
        /// </summary>
        /// <param name="customer">pass customer as Customer object.</param>
        DatabaseResult Add(Visitor customer);
        #endregion [Database Methods]
    }
    #endregion [IVisitorRepository  Interface]
}
