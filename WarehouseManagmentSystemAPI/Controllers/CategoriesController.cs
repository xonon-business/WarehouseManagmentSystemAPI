using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagmentSystemAPI.Controllers
{
    public class CategoriesController :BaseController
    {
        private readonly ICategoriesServices _categoriesServices;

        public CategoriesController(ICategoriesServices categoriesServices)
        {
            _categoriesServices = categoriesServices;
        }


        [HttpGet("AllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoriesServices.GetAllASync());

        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCategory(CategoryDto dtoObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            var category = await _categoriesServices.CreateAsync(dtoObject);

            return Created("~/api/Products/AllCategories", category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            _categoriesServices.DeleteAsync(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategorybyId(Guid id, CategoryDto dto)
        {
            if (id == null || id == Guid.Empty)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = await _categoriesServices.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            await _categoriesServices.UpdateByIdAsync(dto, id);

            return Ok();

        }
    }
}
