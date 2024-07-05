using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class MusteriController : ControllerBase
    {
        private readonly IMusteriService _musteriService;

        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var musteriler = _musteriService.TGetAll();
            return Ok(musteriler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var musteri = _musteriService.TGet(m => m.KullaniciID == id);
            if (musteri == null)
            {
                return NotFound();
            }
            return Ok(musteri);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Musteri musteri)
        {
            if (musteri == null)
            {
                return BadRequest();
            }
            _musteriService.TAdd(musteri);
            return CreatedAtAction(nameof(GetById), new { id = musteri.KullaniciID }, musteri);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Musteri musteri)
        {
            if (musteri == null || musteri.KullaniciID != id)
            {
                return BadRequest();
            }
            var existingMusteri = _musteriService.TGet(m => m.KullaniciID == id);
            if ( existingMusteri == null)
            {
                return NotFound();
            }
            _musteriService.TUpdate(musteri);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musteri = _musteriService.TGet(m => m.KullaniciID == id);
            if (musteri == null)
            {
                return NotFound();
            }
            _musteriService.TDelete(musteri);
            return NoContent();
        }
    }
}
