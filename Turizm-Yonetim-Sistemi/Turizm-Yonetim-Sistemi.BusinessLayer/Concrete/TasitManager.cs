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
    public class TasitManager : ITasitService
    {
        private readonly ITasitDal _tasitDal;
        public TasitManager(ITasitDal tasitDal)
        {
            _tasitDal = tasitDal;
        }
        public void TAdd(Tasit entity)
        {
            _tasitDal.Add(entity);
        }

        public void TDelete(Tasit entity)
        {
            _tasitDal.Delete(entity);
        }

        public Tasit TGet(Expression<Func<Tasit, bool>> filter)
        {
            return _tasitDal.Get(filter);
        }

        public List<Tasit> TGetAll(Expression<Func<Tasit, bool>> filter = null)
        {
            return _tasitDal.GetAll(filter);
        }

        public void TUpdate(Tasit entity)
        {
            _tasitDal.Update(entity);
        }
    }
}
