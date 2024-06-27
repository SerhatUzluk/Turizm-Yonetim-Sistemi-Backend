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
    //entity'ye özgü metod varsa buraya da dahil edilmeli.
    public class BiletManager : IBiletService
    {
        private readonly IBiletDal _biletDal;
        public BiletManager(IBiletDal biletDal)
        {
            _biletDal = biletDal;
        }
        public void TAdd(Bilet entity)
        {
            _biletDal.Add(entity);
        }

        public void TDelete(Bilet entity)
        {
            _biletDal.Delete(entity);
        }

        public Bilet TGet(Expression<Func<Bilet, bool>> filter)
        {
            return _biletDal.Get(filter);
        }

        public List<Bilet> TGetAll(Expression<Func<Bilet, bool>> filter = null)
        {
            return _biletDal.GetAll(filter);
        }

        public void TUpdate(Bilet entity)
        {
            _biletDal.Update(entity);
        }
    }
}
