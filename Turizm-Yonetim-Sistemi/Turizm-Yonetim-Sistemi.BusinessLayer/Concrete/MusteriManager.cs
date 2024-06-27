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
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
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
