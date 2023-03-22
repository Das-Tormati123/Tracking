using DataAccessLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
   public interface IDatabase
   {
      int ExecuteNonQuery(DBCommand cmd);
      void OpenConnection();
      void CloseConnection();
   }
}
