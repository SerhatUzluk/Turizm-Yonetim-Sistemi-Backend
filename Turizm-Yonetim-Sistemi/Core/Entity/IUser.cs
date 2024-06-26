using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public interface IUser
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string PhoneNumber { get; set; }
    }
}
