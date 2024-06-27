using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.DataAccessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Concrete.EntityFramework
{
    public class EfKampanyaDal: EfEntityRepositoryBase<Kampanya, DemoContext>, IKampanyaDal
    {
    }
}
