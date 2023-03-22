using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;

namespace DataAccessLayer.Interfaces
{
    internal interface IMapsDataAccess
    {
        IList<LoginDriverDetails> ValidataLogin();
    }
}
