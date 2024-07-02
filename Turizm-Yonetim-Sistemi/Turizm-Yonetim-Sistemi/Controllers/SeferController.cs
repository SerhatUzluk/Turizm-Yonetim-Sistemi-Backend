using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeferController : ControllerBase
    {
        private readonly ISeferService _seferService;

        public SeferController(ISeferService seferService)
        {
            _seferService = seferService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var seferler = _seferService.TGetAll();
            return Ok(seferler);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var sefer = _seferService.TGet(s => s.SeferID == id);
            if (sefer == null)
            {
                return NotFound();
            }
            return Ok(sefer);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Sefer sefer) 
        {
            if (sefer == null) 
            {
                return BadRequest(); 
            }
            _seferService.TAdd(sefer);
            return CreatedAtAction(nameof(GetById), new {id = sefer.SeferID}, sefer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Sefer sefer)
        {
            if(sefer == null || sefer.SeferID != id)
            {
                return BadRequest();
            }
            var existingSefer = _seferService.TGet(s => s.SeferID == id);
            if(existingSefer == null)
            {
                return BadRequest();
            }
            _seferService.TUpdate(sefer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var sefer = _seferService.TGet(s => s.SeferID == id);
            if (sefer == null)
            {
                return NotFound();
            }
            _seferService.TDelete(sefer);
            return NoContent();
        }
    }
}
