using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagmentSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "Login")]
        public IActionResult Login Get() {
            return Ok(new { message = "test" }); 
        }
        
    }
}