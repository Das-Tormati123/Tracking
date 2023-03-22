using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Interfaces;
using DataAccessLayer.DataBase;

namespace KT_POC
{
   public class SqlDatabase : IDatabase
   {
      SqlConnection _con = null;
      public CommandType CommandType { get; set; }
      public SqlDatabase(string connectionString)
      {
         _con = new SqlConnection(connectionString);
         CommandType = CommandType.StoredProcedure;
      }
      public void CloseConnection()
      {
         if (_con.State == ConnectionState.Open)
            _con.Close();
      }

      public int ExecuteNonQuery(DBCommand cmd)
      {
         var dbCmd = new SqlCommand(cmd.CommandText,_con);
         dbCmd.CommandType = CommandType;
         AddParameters(dbCmd, cmd);
         return dbCmd.ExecuteNonQuery();
      }

      public void OpenConnection()
      {
         if (_con.State == ConnectionState.Closed)
            _con.Open();
      }

      private void AddParameters(SqlCommand cmd,DBCommand dBCommand)
      {
         dBCommand.Parameters.ForEach((p) => {
            cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
         });
      }
   }
}
