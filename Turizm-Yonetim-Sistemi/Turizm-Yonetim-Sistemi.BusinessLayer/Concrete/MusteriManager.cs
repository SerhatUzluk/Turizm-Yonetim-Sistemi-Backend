using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.DataAccessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private readonly IMusteriDal _musteriDal;
        private readonly SignInManager<Musteri> _signInManager;
        private readonly UserManager<Musteri> _userManager;
        public MusteriManager(IMusteriDal musteriDal, SignInManager<Musteri> signInManager, UserManager<Musteri> userManager)
        {
            _musteriDal = musteriDal;
            _signInManager = signInManager;
            _userManager = userManager;
        }    

        public async Task<IdentityResult> CreateMusteriAsync(Musteri musteri, string password)
        {
            return await _userManager.CreateAsync(musteri, password);
        }

        public async Task<SignInResult> SignInMusteriAsync(string email, string password)
        {
            var user = await _userManager.FindByNameAsync(email);
            if (user == null)
            {
                return SignInResult.Failed;
            }

            return await _signInManager.CheckPasswordSignInAsync(user, password, false);
        }

        public async Task<Musteri> FindByNameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public void TAdd(Musteri entity)
        {
            _musteriDal.Add(entity);
        }

        public void TDelete(Musteri entity)
        {
            _musteriDal.Delete(entity);
        }

        public Musteri TGet(Expression<Func<Musteri, bool>> filter)
        {
            return _musteriDal.Get(filter);
        }

        public List<Musteri> TGetAll(Expression<Func<Musteri, bool>> filter = null)
        {
            return _musteriDal.GetAll(filter);
        }

        public void TUpdate(Musteri entity)
        {
            _musteriDal.Update(entity);
        }
    }
}
