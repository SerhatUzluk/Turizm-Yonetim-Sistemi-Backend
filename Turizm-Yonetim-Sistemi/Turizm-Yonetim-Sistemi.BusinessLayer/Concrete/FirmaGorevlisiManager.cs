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
    public class FirmaGorevlisiManager : IFirmaGorevlisiService
    {
        private readonly IFirmaGorevlisiDal _firmaGorevlisiDal;
        public FirmaGorevlisiManager(IFirmaGorevlisiDal firmaGorevlisiDal)
        {
            _firmaGorevlisiDal = firmaGorevlisiDal; 
        }
        public void TAdd(FirmaGorevlisi entity)
        {
            _firmaGorevlisiDal.Add(entity);
        }

        public void TDelete(FirmaGorevlisi entity)
        {
            _firmaGorevlisiDal.Delete(entity);
        }

        public FirmaGorevlisi TGet(Expression<Func<FirmaGorevlisi, bool>> filter)
        {
            return _firmaGorevlisiDal.Get(filter);
        }

        public List<FirmaGorevlisi> TGetAll(Expression<Func<FirmaGorevlisi, bool>> filter = null)
        {
            return _firmaGorevlisiDal.GetAll(filter);
        }

        public void TUpdate(FirmaGorevlisi entity)
        {
            _firmaGorevlisiDal.Update(entity);
        }
    }
}
