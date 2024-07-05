using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.Security;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Abstract
{
    public interface ITokenHandler
    {
        Token CreateToken(IdentityUser user);
    }
}
