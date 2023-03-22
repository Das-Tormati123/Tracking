using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataBase
{
   public enum DBOperation
   {
      New,
      Update
   }

   public enum DBCommandType { 
      Text,
      Procedure
   }
}
