using ManagementEntity;
using ManagementEntity.Model;
using ManagementService;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Management.Controllers
{
    [ApiController]
    [Route("Visitor")]
    
    public class VisitorController : ControllerBase
    {
        #region [Private Members]
        /// <summary>
        /// Visitor Service instance of IVisitorService.
        /// </summary>
        private readonly IVisitorService _visitorService;

        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of VisitorController.
        /// </summary>
        /// <param name="visitorService"></param>
        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        #endregion [Constructor]

        #region [Create Visitior]
        /// <summary>
        /// Create Visitior.
        /// </summary>
        /// <param name="visitior"></param>
        [HttpPost]
        public async Task<IActionResult> CreateVisitor([FromBody] Visitor visitior)
        {
            APIResult result = new APIResult();
            try
            {
                result.APIRequest = visitior;
                if (ModelState.IsValid)
                {
                    BusinessResult businessResult=await _visitorService.CreateVisitior(visitior);
                    result.APIResponse =(ResultSet?) businessResult.BusinessResponse;
                }
                else if(!ModelState.IsValid)
                {
                   result.APIResponse=new ResultSet();
                   result.APIResponse.Message = Message.ModelValidationError;
                   result.APIResponse.MessageCode = MessageCode.ModelValidationError;
                   result.APIResponse.MethodName = MethodBase.GetCurrentMethod()?.Name; 
                }
            }
            catch (Exception ex)
            {
                result.APIResponse = new ResultSet();
                result.APIResponse.Message=ex.Message;
                result.APIResponse.MessageCode = MessageCode.APIError;
                result.APIResponse.Message = MethodBase.GetCurrentMethod()?.Name;
            }
            return Ok(result);
        }
        #endregion [Create Visitior]
    }
}
