using ManagementEntity;
using ManagementEntity.Model;
using ManagementService;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CustomerController : ControllerBase
    {
        #region [Private Members]
        /// <summary>
        /// Customer Service instance of ICustomerService.
        /// </summary>
        private readonly ICustomerService _customerService;

        #endregion [Private Members]

        #region [Constructor]
        /// <summary>
        /// Constructor of CustomerController.
        /// </summary>
        /// <param name="customerService"></param>
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion [Constructor]

        #region [Create Customer]
        /// <summary>
        /// Create Customer.
        /// </summary>
        /// <param name="customer"></param>
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public APIResult CreateCustomer([FromBody] Customer customer)
        {
            APIResult result = new APIResult();
            try
            {
                result.APIRequest = customer;
                if (ModelState.IsValid)
                {
                    _customerService.CreateCustomer(customer);
                }
                else
                {
                    result.MessageResult = new ResultSet();
                    result.MessageResult.ErrorMessage = "ModelState is not valid.";
                    result.MessageResult.ResponseIsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                result.MessageResult = new ResultSet();
                result.MessageResult.ErrorMessage=ex.Message;
                result.MessageResult.ResponseIsSuccess = false;
            }
            return result;
        }
        #endregion [Create Customer]
    }
}
