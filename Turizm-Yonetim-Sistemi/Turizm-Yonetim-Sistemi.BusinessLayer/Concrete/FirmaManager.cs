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
    public class FirmaManager : IFirmaService
    {
        private readonly IFirmaDal _firmaDal;

        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }
        public void TAdd(Firma entity)
        {
            _firmaDal.Add(entity);
        }

        public void TDelete(Firma entity)
        {
            _firmaDal.Delete(entity);
        }

        public Firma TGet(Expression<Func<Firma, bool>> filter)
        {
            return _firmaDal.Get(filter);
        }

        public List<Firma> TGetAll(Expression<Func<Firma, bool>> filter = null)
        {
            return _firmaDal.GetAll(filter);
        }

        public void TUpdate(Firma entity)
        {
            _firmaDal.Update(entity);
        }
    }
}
