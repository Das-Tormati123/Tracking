using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataBase
{
   public class DBCommand
   {
      public string ParameterPrefix = "@";
      public List<DBParameter> Parameters { get; set; }
      public string CommandText { get; set; }
      public DBCommandType CommandType { get; set; }

      public DBCommand()
      {
         Parameters = new List<DBParameter>();
      }

      public void AddWithValue(string name, object value)
      {
         Parameters.Add(new DBParameter { 
            Value = value,
            ParameterName = ParameterPrefix + name
         });
      }
   }
}
