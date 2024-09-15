using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _firmaService;

        public FirmaController(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var firmalar = _firmaService.TGetAll();
            return Ok(firmalar);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var firma = _firmaService.TGet(f => f.FirmaID == id);
            if (firma == null)
            {
                return NotFound();
            }
            return Ok(firma);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Firma firma)
        {
            if (firma == null)
            {
                return BadRequest();
            }
            _firmaService.TAdd(firma);
            return CreatedAtAction(nameof(GetById), new { id = firma.FirmaID }, firma);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Firma firma)
        {
            if(firma == null)
            {
                return BadRequest();
            }
            var existingFirma = _firmaService.TGet(f => f.FirmaID == id);
            if(existingFirma == null)
            {
                return NotFound();
            }
            _firmaService.TUpdate(existingFirma);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var firma = _firmaService.TGet(f => f.FirmaID == id);
            if(firma == null)
            {
                return NotFound();
            }
            _firmaService.TDelete(firma);
            return NoContent();
        }
    }
}
