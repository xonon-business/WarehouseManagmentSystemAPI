using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagmentSystemAPI.Dtos;

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
        public IActionResult GetAllProducts()
        {
            return Ok(IprodcutServices.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return Ok(await IprodcutServices.GetById(id));
        }

        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            if (IprodcutServices.GetByName(name) == null)
            {
                return NotFound("The searched item not found!");
            }

            return Ok(IprodcutServices.GetByName(name));
        }




        //[HttpGet("GetProductsWithPrices")]
        //public async Task<IActionResult> GetProductsWithPrices()
        //{
        //    var productsList = await _ProductRepository.GetAllAsync();

        //    var ProductsName = string.Empty;
        //    var ProductsPrices = string.Empty;

        //    foreach(var productName in productsList)
        //    {
        //        ProductsName = productName.ProductName;

        //        foreach(var productPrice in productsList)
        //        {
        //            ProductsPrices = Convert.ToString(productPrice.ProductSalePrice);
        //        }

        //    }

        //    return Ok(ProductsName+ProductsPrices);


        //}



        [HttpPost]
        public async Task<IActionResult> CreateOrUpdateProduct(Guid? id, ProductsDto productDto)
        {
            if (id == null)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Check your input!");
                }

                IprodcutServices.CreateAndUpdateProduct(productDto, null);

                return Ok(productDto);

            }

            if (id.HasValue)
            {
                var product = IprodcutServices.GetById(id);

                if (product == null)
                {
                    return NotFound();
                }
                else
                {
                    IprodcutServices.CreateAndUpdateProduct(productDto, id);
                }
            }

            return BadRequest("Something Went Wrong");

        }



        //?GET All by Category

        //GET All products with low in stock
        //Get products with quantity
        //Validation for input


    }
}
