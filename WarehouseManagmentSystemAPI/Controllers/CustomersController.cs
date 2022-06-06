using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagmentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController
    {
        private readonly ICustomersServices _customersServices;

        public CustomersController(ICustomersServices customersServices)
        {
            _customersServices = customersServices;
        }


        [HttpGet("AllCustomer")]
        public async Task<IActionResult> GetAllCustomers()
        {
           return Ok( await _customersServices.GetAllASync());

        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(CustomerDto dtoObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            
           var customer = await _customersServices.CreateAsync(dtoObject);

           return Created("~/api/Products/AllCustomer",customer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            _customersServices.DeleteAsync(id);

            return NoContent();
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerbyId(Guid id, CustomerDto dto)
        {
            if(id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = await _customersServices.GetByIdAsync(id);

            if(customer == null)
            {
                return NotFound();
            }

            await _customersServices.UpdateCustomerByIdAsync(dto,id);

            return Ok();

        }

    }
}
