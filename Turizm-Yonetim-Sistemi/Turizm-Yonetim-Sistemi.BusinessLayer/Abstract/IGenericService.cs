using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        //IEntityRepository interface'indeki metodların aynıları fakat karışmamaları için başlarına T eklendi.
        List<T> TGetAll(Expression<Func<T, bool>> filter = null);
        T TGet(Expression<Func<T, bool>> filter);

        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
