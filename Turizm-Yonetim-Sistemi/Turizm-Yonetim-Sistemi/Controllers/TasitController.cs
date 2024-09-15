using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class TasitController : Controller
    {
        private readonly ITasitService _tasitService;

        public TasitController(ITasitService tasitService)
        {
            _tasitService = tasitService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var tasitlar = _tasitService.TGetAll();
            return Ok(tasitlar);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tasit = _tasitService.TGet(t => t.TasitID == id);
            if(tasit == null)
            {
                return NotFound();
            }
            return Ok(tasit);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Tasit tasit)
        {
            if(tasit == null)
            {
                return BadRequest();
            }
            _tasitService.TAdd(tasit);
            return CreatedAtAction(nameof(GetById), new { id = tasit.TasitID}, tasit);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Tasit tasit)
        {
            if(tasit == null || tasit.TasitID != id)
            {
                return BadRequest();
            }
            var existingVehicle = _tasitService.TGet(t => t.TasitID == id);
            if(existingVehicle == null)
            {
                return NotFound();
            }
            _tasitService.TUpdate(tasit);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tasit = _tasitService.TGet(t => t.TasitID == id);
            if(tasit == null)
            {
                return NotFound();
            }
            _tasitService.TDelete(tasit);
            return NoContent();
        }
    }
}
