using ManagementDataContext;
using ManagementEntity;
using ManagementEntity.Model;
using System.Reflection;

namespace ManagementService
{
    #region [VisitiorService Business Service Implementation]
    /// <summary>
    /// VisitiorService Business Service Implementation.
    /// </summary>
    public class VisitiorService : IVisitorService
    {
        #region [Private Members]
        /// <summary>
        /// Declare IVisitorRepository variable.
        /// </summary>
        private readonly IVisitorRepository _visitorRepo;

        /// <summary>
        /// Declare BusinessResult variable.
        /// </summary>
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
        /// <param name="visitor">pass visitor as Visitor object.</param>
        public async Task<BusinessResult> CreateVisitior(Visitor visitor)
        {
            try
            {
                businessResult.BusinessRequest = visitor;
                DatabaseResult responseDBContext= await _visitorRepo.AddAsync(visitor);
                businessResult.BusinessResponse = responseDBContext;
                businessResult.Success = responseDBContext.Success;
                businessResult.Message = responseDBContext.Message;
                businessResult.MessageCode = responseDBContext.MessageCode;
                businessResult.MethodName = MethodBase.GetCurrentMethod()?.Name;
            }
            catch (Exception ex)
            {
                businessResult.Message = ex.Message;
                businessResult.MessageCode = MessageCode.RuntimeBusinessException;
                businessResult.MethodName = MethodBase.GetCurrentMethod()?.Name;
            }
            return businessResult;
        }

        /// <summary>
        /// Get Visitor by Id of Business method implentation.
        /// </summary>
        /// <param name="id">pass id as integer.</param>
        /// <returns>return Visitor object.</returns>
        public async Task<BusinessResult> GetVisitor(int id)
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
        public async Task<BusinessResult> GetVisitors()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new BusinessResult();
        }
        #endregion [Business Logic Implementation]
    }
    #endregion [VisitorService Business Service Implementation]
}
