using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class PersonelController : ControllerBase
    {
        IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var personeller = _personelService.TGetAll();
            return Ok(personeller);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var personel = _personelService.TGet(p => p.PersonelID == id);
            return Ok(personel);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Personel personel)
        {
            if (personel == null)
            {
                return BadRequest();
            }
            _personelService.TAdd(personel);
            return CreatedAtAction(nameof(GetById), new {id = personel.PersonelID}, personel);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Personel personel) 
        {
            if(personel == null || personel.PersonelID != id) 
            {
                return BadRequest();
            }
            var existingPersonel = _personelService.TGet(p => p.PersonelID == id);
            if (existingPersonel == null)
            {
                return NotFound();
            }
            _personelService.TUpdate(personel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var personel = _personelService.TGet(p => p.PersonelID == id);
            if (personel == null)
            {
                return NotFound();
            }
            _personelService.TDelete(personel);
            return NoContent();
        }
    }
}
