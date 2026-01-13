using ManagementEntity;
using ManagementEntity.Model;
using ManagementService;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class VisitorController : ControllerBase
    {
        #region [Private Members]
        /// <summary>
        /// Customer Service instance of ICustomerService.
        /// </summary>
        private readonly IVisitorService _customerService;

        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerController.
        /// </summary>
        /// <param name="customerService"></param>
        public VisitorController(IVisitorService customerService)
        {
            _customerService = customerService;
        }
        #endregion [Constructor]

        #region [Create Visitior]
        /// <summary>
        /// Create Visitior.
        /// </summary>
        /// <param name="visitior"></param>
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public APIResult CreateVisitior([FromBody] Visitor visitior)
        {
            APIResult result = new APIResult();
            result.MessageResult = new ResultSet();
            try
            {
                result.APIRequest = visitior;
                if (ModelState.IsValid)
                {
                    _customerService.CreateVisitior(visitior);
                    result.MessageResult.ResponseIsSuccess = true;
                }
                else if(!ModelState.IsValid)
                {
                    result.MessageResult.ErrorMessage = ErrorMessage.ValidationError;
                    result.MessageResult.ResponseIsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                result.MessageResult.ErrorMessage=ex.Message;
                result.MessageResult.ResponseIsSuccess = false;
            }
            return result;
        }
        #endregion [Create Visitior]
    }
}
