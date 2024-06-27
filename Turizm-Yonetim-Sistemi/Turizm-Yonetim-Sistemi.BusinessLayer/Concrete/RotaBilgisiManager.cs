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
    public class RotaBilgisiManager : IRotaBilgisiService
    {
        private readonly IRotaBilgisiDal _rotaBilgisiDal;
        public RotaBilgisiManager(IRotaBilgisiDal rotaBilgisiDal)
        {
            _rotaBilgisiDal = rotaBilgisiDal;
        }
        public void TAdd(RotaBilgisi entity)
        {
            _rotaBilgisiDal.Add(entity);
        }

        public void TDelete(RotaBilgisi entity)
        {
            _rotaBilgisiDal.Delete(entity);
        }

        public RotaBilgisi TGet(Expression<Func<RotaBilgisi, bool>> filter)
        {
            return _rotaBilgisiDal.Get(filter);
        }

        public List<RotaBilgisi> TGetAll(Expression<Func<RotaBilgisi, bool>> filter = null)
        {
            return _rotaBilgisiDal.GetAll(filter);
        }

        public void TUpdate(RotaBilgisi entity)
        {
            _rotaBilgisiDal.Update(entity);
        }
    }
}
