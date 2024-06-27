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
    public class MuavinManager : IMuavinService
    {
        private readonly IMuavinDal _muavinDal;
        public MuavinManager(IMuavinDal muavinDal)
        {
            _muavinDal = muavinDal;
        }
        public void TAdd(Muavin entity)
        {
            _muavinDal.Add(entity);
        }

        public void TDelete(Muavin entity)
        {
            _muavinDal.Delete(entity);
        }

        public Muavin TGet(Expression<Func<Muavin, bool>> filter)
        {
            return _muavinDal.Get(filter);
        }

        public List<Muavin> TGetAll(Expression<Func<Muavin, bool>> filter = null)
        {
            return _muavinDal.GetAll(filter);
        }

        public void TUpdate(Muavin entity)
        {
            _muavinDal.Update(entity);
        }
    }
}
