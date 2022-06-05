

namespace WarehouseManagmentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsServices IprodcutServices;
        public ProductsController(IProductsServices _IprodcutServices)
        {
            IprodcutServices = _IprodcutServices;
        }

        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await IprodcutServices.GetAllProductsAsync());
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetProductByIdAsync(Guid id)
        {
            return Ok(await IprodcutServices.GetByIdAsync(id));
        }

        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByNameAsync(string name)
        {
            return Ok(await IprodcutServices.GetProductByNameAsync(name));

        }

        [HttpGet("GetProductsWithPrices")]
        public async Task<IActionResult> GetProductsWithPrices()
        {

            var productsPricsList = await IprodcutServices.GetProductsPricesList();

            return Ok(productsPricsList);

        }

        [HttpPost]
        [Route("/CreateProductAsync")]

        public async Task<IActionResult> CreateProductAsync(ProductDto dtoObject)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product =  IprodcutServices.Create(dtoObject);

            return Created("~api/api/Products/GetAllProducts", product);


        }

        [HttpPut]
        [Route("/UpdateProductAsync")]

        public async Task<IActionResult> UpdateProductAsync(Guid id, ProductDto dtoObject)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await IprodcutServices.UpdateProductById(dtoObject, id);

            return Ok();

        }

        [HttpDelete]
        [Route("/DeleteProductAsync")]

        public async Task<IActionResult> DeleteProductAsync(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound(id);
            }

            IprodcutServices.Delete(id);

            return NoContent();

        }

        //?GET All by Category
        //GET All products with low in stock
        //Get products with quantity
        //Validation for input
        //Show inventory filiters by a selection from the front end


    }
}
