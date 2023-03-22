using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataBase
{
   public class DatabaseContext
   {
      static IDatabase _database = null;
      public static void Initialize(IDatabase database)
      {
         _database = database;
      }

      public static IDatabase GetDatabase()
      {
         return _database;
      }
   }
}
