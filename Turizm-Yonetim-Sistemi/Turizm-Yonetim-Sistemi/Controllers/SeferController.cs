using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeferController : ControllerBase
    {
        private readonly ISeferService _seferService;
        private readonly ITasitService _tasitService;
        private readonly IRotaBilgisiService _rotaBilgisiService;
        private readonly IFirmaService _firmaService;

        public SeferController(ISeferService seferService, ITasitService tasitService, IRotaBilgisiService rotaBilgisiService, IFirmaService firmaService)
        {
            _seferService = seferService;
            _tasitService = tasitService;
            _firmaService = firmaService;
            _rotaBilgisiService = rotaBilgisiService;

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
        public IActionResult Create([FromBody]SeferDTO seferDTO) 
        {
            if (seferDTO == null) 
            {
                return BadRequest(); 
            }
            var tasit = _tasitService.TGet(t => t.TasitID == seferDTO.TasitID);
            if (tasit == null)
            {
                return BadRequest();
            }
            var rota = _rotaBilgisiService.TGet(r => r.RotaID == seferDTO.RotaID);
            if (rota == null)
            {
                return BadRequest();
            }
            var firma = _firmaService.TGet(f => f.FirmaID == seferDTO.FirmaID);
            if (firma == null)
            {
                return BadRequest();
            }
            var sefer = new Sefer
            {
                TasitID = seferDTO.TasitID,
                KalkisZamani = seferDTO.KalkisZamani,
                VarisZamani = seferDTO.VarisZamani,
                FirmaID = seferDTO.FirmaID,
                BiletSatisFiyati = seferDTO.BiletSatisFiyati,
                RotaID = seferDTO.RotaID,
                Rota = rota,
                Tasit = tasit,               
            };
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
