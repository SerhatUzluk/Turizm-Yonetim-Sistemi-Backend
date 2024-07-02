using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class RotaBilgisiController : ControllerBase
    {
        private readonly IRotaBilgisiService _rotaBilgisiService;

        public RotaBilgisiController(IRotaBilgisiService rotaBilgisiService)
        {
            _rotaBilgisiService = rotaBilgisiService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var rotaBilgileri = _rotaBilgisiService.TGetAll();
            return Ok(rotaBilgileri);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var rotaBilgisi = _rotaBilgisiService.TGet(r => r.RotaID == id);
            if (rotaBilgisi == null)
            {
                return NotFound();
            }
            return Ok(rotaBilgisi);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RotaBilgisi rotaBilgisi)
        {
            if (rotaBilgisi == null)
            {
                return BadRequest();
            }
            _rotaBilgisiService.TAdd(rotaBilgisi);
            return CreatedAtAction(nameof(GetById), new { id = rotaBilgisi.RotaID }, rotaBilgisi);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RotaBilgisi rotaBilgisi) 
        {
            if (rotaBilgisi == null || rotaBilgisi.RotaID != id)
            {
                return BadRequest();
            }
            var existingRotaBilgisi = _rotaBilgisiService.TGet(r => rotaBilgisi.RotaID == id);
            if (existingRotaBilgisi == null)
            {
                return NotFound();
            }
            _rotaBilgisiService.TUpdate(rotaBilgisi);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var rotaBilgisi = _rotaBilgisiService.TGet(r => r.RotaID == id);
            if (rotaBilgisi == null)
            {
                return NotFound();
            }
            _rotaBilgisiService.TDelete(rotaBilgisi);
            return NoContent();
        }
    }
}
