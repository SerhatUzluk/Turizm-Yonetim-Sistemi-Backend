using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Abstract
{
    public interface IMusteriService : IGenericService<Musteri>
    {
        Task<IdentityResult> CreateMusteriAsync(Musteri musteri, string password);
        Task<SignInResult> SignInMusteriAsync(string email, string password);
        Task<Musteri> FindByNameAsync(string username);
    }
}
