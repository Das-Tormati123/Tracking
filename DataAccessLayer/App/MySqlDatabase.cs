using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace KT_POC
{
   public class MySqlDatabase : IDatabase
   {
      public MySqlDatabase(string con)
      {

      }
      public void CloseConnection()
      {
         throw new NotImplementedException();
      }

      public int ExecuteNonQuery(DBCommand cmd)
      {
         throw new NotImplementedException();
      }

      public void OpenConnection()
      {
         throw new NotImplementedException();
      }
   }
}
