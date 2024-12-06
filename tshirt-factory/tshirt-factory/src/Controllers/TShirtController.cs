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


        [HttpGet("{id}")]
        public IActionResult GetTShirt(int id)
        {
            var tShirt = _service.GetTShirt(id);
            if (tShirt == null) return NotFound();
            return Ok(tShirt);
        }

        [HttpGet]
        public IActionResult GetAllTShirts()
        {
            var tShirts = _service.GetAllTShirts();
            return Ok(tShirts);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTShirt(int id, string name, string variationType, string customData)
        {
            _service.UpdateTShirt(id, name, variationType, customData);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTShirt(int id)
        {
            _service.DeleteTShirt(id);
            return NoContent();
        }
    }
}
