using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagmentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomersServices _customersServices;

        public CustomerController(ICustomersServices customersServices)
        {
            _customersServices = customersServices;
        }

        //CRUD

        //[HttpGet("AllCustomer")]
        //public async Task<IActionResult> GetAllCustomers()
        //{
        //    return Ok( await _customersServices.    ());

        //}

        //[HttpPost("CreateCustomer")]
        //public async Task<IActionResult> CreateCustomer(CustomerDto dtoObject)
        //{
        //    _customersServices.Create(dtoObject);

        //    return Created() 
        //}
    }
}
