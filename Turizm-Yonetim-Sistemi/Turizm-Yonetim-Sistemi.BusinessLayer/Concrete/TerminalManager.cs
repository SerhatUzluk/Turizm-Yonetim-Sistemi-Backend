using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.DataAccessLayer.Abstract;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete
{
    public class TerminalManager : ITerminalDal
    {
        private readonly ITerminalDal _terminalDal;
        public TerminalManager(ITerminalDal terminalDal)
        {
            _terminalDal = terminalDal;
        }
        public void Add(Terminal entity)
        {
            _terminalDal.Add(entity);
        }

        public void Delete(Terminal entity)
        {
            _terminalDal.Delete(entity);
        }

        public Terminal Get(Expression<Func<Terminal, bool>> filter)
        {
            return _terminalDal.Get(filter);
        }

        public List<Terminal> GetAll(Expression<Func<Terminal, bool>> filter = null)
        {
            return _terminalDal.GetAll(filter);
        }

        public void Update(Terminal entity)
        {
            _terminalDal.Update(entity);
        }
    }
}
