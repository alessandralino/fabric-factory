using Microsoft.AspNetCore.Mvc;
using tshirt_factory.src.Services;

namespace tshirt_factory.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TShirtController : Controller
    {
        private readonly ITShirtService _service;

        public TShirtController(ITShirtService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CreateTShirt(string name, string variationType, string customData)
        {
            var tShirt = _service.CreateTShirt(name, variationType, customData);
            return Ok(tShirt); 
        } 
    }
}
