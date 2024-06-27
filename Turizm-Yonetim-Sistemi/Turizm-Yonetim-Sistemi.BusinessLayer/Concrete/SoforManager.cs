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
    public class SoforManager : ISoforService
    {
        private readonly ISoforDal _soforDal;
        public SoforManager(ISoforDal soforDal)
        {
            _soforDal = soforDal;
        }
        public void TAdd(Sofor entity)
        {
            _soforDal.Add(entity);
        }

        public void TDelete(Sofor entity)
        {
            _soforDal.Delete(entity);
        }

        public Sofor TGet(Expression<Func<Sofor, bool>> filter)
        {
            return _soforDal.Get(filter);
        }

        public List<Sofor> TGetAll(Expression<Func<Sofor, bool>> filter = null)
        {
            return _soforDal.GetAll(filter);
        }

        public void TUpdate(Sofor entity)
        {
            _soforDal.Update(entity);
        }
    }
}
