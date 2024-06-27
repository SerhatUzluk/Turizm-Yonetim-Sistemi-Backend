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
    public class KampanyaManager : IKampanyaService
    {
        private readonly IKampanyaDal _kampanyaDal;
        public KampanyaManager(IKampanyaDal kampanyaDal)
        {
            _kampanyaDal = kampanyaDal;
        }
        public void TAdd(Kampanya entity)
        {
            _kampanyaDal.Add(entity);
        }

        public void TDelete(Kampanya entity)
        {
            _kampanyaDal.Delete(entity);
        }

        public Kampanya TGet(Expression<Func<Kampanya, bool>> filter)
        {
            return _kampanyaDal.Get(filter);
        }

        public List<Kampanya> TGetAll(Expression<Func<Kampanya, bool>> filter = null)
        {
            return _kampanyaDal.GetAll(filter);
        }

        public void TUpdate(Kampanya entity)
        {
            _kampanyaDal.Update(entity);
        }
    }
}
