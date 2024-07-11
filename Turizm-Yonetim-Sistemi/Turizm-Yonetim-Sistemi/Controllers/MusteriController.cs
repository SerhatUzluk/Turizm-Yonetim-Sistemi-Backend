using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.Security;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;
using Turizm_Yonetim_Sistemi.Models;

namespace Turizm_Yonetim_Sistemi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class MusteriController : ControllerBase
    {
        private readonly IMusteriService _musteriService;
        private readonly MyTokenHandler _tokenHandler;
        private readonly UserManager<Musteri> _userManager;

        public MusteriController(IMusteriService musteriService, MyTokenHandler tokenHandler, UserManager<Musteri> userManager)
        {
            _musteriService = musteriService;
            _tokenHandler = tokenHandler;
            _userManager = userManager;
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

        [HttpPost("register")]
        public async Task<IActionResult> RegisterMusteri([FromBody] RegisterModel model)
        {
            var musteri = new Musteri
            {
                UserName = Guid.NewGuid().ToString(),
                Email = model.Email,
                Ad = model.Ad,
                Soyad = model.Soyad,
                KimlikNo = model.KimlikNo,
                Cinsiyet = model.Cinsiyet,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _musteriService.CreateMusteriAsync(musteri, model.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            return Ok(new { message = "Kayıt işlemi başarılı" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var token = _tokenHandler.CreateToken(user);
                return Ok(token);
            }

            return Unauthorized();
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
            if (existingMusteri == null)
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
