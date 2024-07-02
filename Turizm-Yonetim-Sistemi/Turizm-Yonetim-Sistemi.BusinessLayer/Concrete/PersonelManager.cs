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
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void TAdd(Personel entity)
        {
            _personelDal.Add(entity);
        }

        public void TDelete(Personel entity)
        {
            _personelDal.Delete(entity);
        }

        public Personel TGet(Expression<Func<Personel, bool>> filter)
        {
            return _personelDal.Get(filter);
        }

        public List<Personel> TGetAll(Expression<Func<Personel, bool>> filter = null)
        {
            return _personelDal.GetAll(filter);
        }

        public void TUpdate(Personel entity)
        {
            _personelDal.Update(entity);
        }
    }
}
