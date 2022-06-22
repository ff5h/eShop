using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogController : Controller
    {
        [HttpGet]
        [Route("items")]
        public IActionResult ItemsAsync()
        {
            return Ok("test");
        }
    }
}
