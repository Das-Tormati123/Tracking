using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    internal interface ILoginDataAccess
    {
        bool ValidataLogin(string UserName, string Password);
    }
}
