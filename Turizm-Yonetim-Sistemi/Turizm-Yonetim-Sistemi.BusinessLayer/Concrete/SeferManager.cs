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
    public class SeferManager : ISeferService
    {
        private readonly ISeferDal _seferDal;
        public SeferManager(ISeferDal seferDal)
        {
            _seferDal = seferDal;
        }
        public void TAdd(Sefer entity)
        {
            _seferDal.Add(entity);
        }

        public void TDelete(Sefer entity)
        {
            _seferDal.Delete(entity);
        }

        public Sefer TGet(Expression<Func<Sefer, bool>> filter)
        {
            return _seferDal.Get(filter);
        }

        public List<Sefer> TGetAll(Expression<Func<Sefer, bool>> filter = null)
        {
            return _seferDal.GetAll(filter);
        }

        public void TUpdate(Sefer entity)
        {
            _seferDal.Update(entity);
        }
    }
}
