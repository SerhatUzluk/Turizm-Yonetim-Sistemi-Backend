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
    public class VardiyaManager : IVardiyaService
    {
        private readonly IVardiyaDal _vardiyaDal;

        public VardiyaManager(IVardiyaDal vardiyaDal)
        {
            _vardiyaDal = vardiyaDal;
        }

        public void TAdd(Vardiya entity)
        {
            _vardiyaDal.Add(entity);
        }

        public void TDelete(Vardiya entity)
        {
            _vardiyaDal.Delete(entity);
        }

        public Vardiya TGet(Expression<Func<Vardiya, bool>> filter)
        {
            return _vardiyaDal.Get(filter);
        }

        public List<Vardiya> TGetAll(Expression<Func<Vardiya, bool>> filter = null)
        {
            return _vardiyaDal.GetAll(filter);
        }

        public void TUpdate(Vardiya entity)
        {
            _vardiyaDal.Update(entity);
        }
    }
}
