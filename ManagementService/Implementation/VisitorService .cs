using ManagementDataContext;
using ManagementEntity;
using ManagementEntity.Model;

namespace ManagementService
{
    #region [VisitiorService Business Service Implementation]
    /// <summary>
    /// VisitiorService Business Service Implementation.
    /// </summary>
    public class VisitiorService : IVisitorService
    {
        #region [Private Members]
        private readonly IVisitorRepository _visitorRepo;
        private BusinessResult businessResult;
        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of VisitiorService Business Service.
        /// </summary>
        public VisitiorService(IVisitorRepository visitorRepo)
        {
            _visitorRepo = visitorRepo;
            businessResult = new BusinessResult();
        }
        #endregion [Constructor]

        #region [Business Service Methods Implementation]
        /// <summary>
        /// Create Visitor of Business method implentation.
        /// </summary>
        /// <param name="customer">pass visitor as Visitor object.</param>
        public BusinessResult CreateVisitior(Visitor visitor)
        {
            try
            {
                businessResult.BusinessRequest = visitor;
                DatabaseResult responseDBContext=_visitorRepo.Add(visitor);
                businessResult.BusinessResponse = responseDBContext;
            }
            catch (Exception ex)
            {
                businessResult.ErrorCode = ErrorCode.DatabaseError;
                businessResult.ErrorMessage = ex.Message;
            }
            return businessResult;
        }

        /// <summary>
        /// Get Visitor by Id of Business method implentation.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return Visitor object.</returns>
        public BusinessResult GetVisitor(int id)
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
        /// Get Visitors of Business method implentationLogic.
        /// </summary>
        /// <returns>return IEnumerable of Visitor object.</returns>
        public BusinessResult GetVisitors()
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
    #endregion [VisitorService Business Service Implementation]
}
