namespace WarehouseManagmentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrdersController : BaseController
    {
        private readonly IOrdersServices _IOrderServices;

        public OrdersController( IOrdersServices IOrderServices)
        {
            _IOrderServices = IOrderServices;
        }

        //CRUD

        [HttpGet("invoices")]
        public async Task<IActionResult> GetAllInvoices()
        {
            return Ok(_IOrderServices.GetAllASync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            _IOrderServices.DeleteAsync(id);

            return NoContent();
        }

        [HttpPost("CreateInvoice")]
        public async Task<IActionResult> CreateInvoice(OrderDto orderDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            _IOrderServices.CreateAsync(orderDto);

            return Created("~/invoices", orderDto);

        }

        [HttpPut("{id}")]
        [Route("/UdpateInvoice")]
        public async Task<IActionResult> UpdateInvoice(OrderDto orderDto,Guid id)
        {

            if (id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var invoice = _IOrderServices.GetByIdAsync(id);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(_IOrderServices.UpdateByIdAsync(orderDto,id));

        }



    }
}