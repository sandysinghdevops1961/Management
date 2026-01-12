using ManagementEntity.Model;
using ManagementService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Management.Controllers
{
    [Route("Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //#region [Private Members]
        ///// <summary>
        ///// Customer Service instance of ICustomerService.
        ///// </summary>
        //private readonly ICustomerService _customerService;

        //#endregion [Private Members]

        #region [Constructor]
        ///// <summary>
        ///// Constructor of CustomerController.
        ///// </summary>
        ///// <param name="customerService"></param>
        //public CustomerController(ICustomerService customerService)
        //{
        //    _customerService = customerService;
        //}
        #endregion [Constructor]

        #region [Get Customer]
        [HttpGet]
        public string GetCustomer()
        {
            return "";
        }
        #endregion [Create Customer]

        #region [Create Customer]
        [HttpPost]
        public void CreateCustomer([FromBody] Customer customer)
        {
            //_customerService.CreateCustomer(customer);
        }
        #endregion [Create Customer]
    }
}
