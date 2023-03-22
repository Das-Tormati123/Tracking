using DataAccessLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_POC
{
   public class CustomerContext : DBContext<CustomerEntity, Criteria>
   {
      public void dd()
      {
         try
         {
            Initialize();
            DB.OpenConnection();
            // db po
         }
         catch (Exception)
         {

            throw;
         }
         finally
         {
            DB.CloseConnection();
         }
      }
      protected override int Delete(Criteria criteria)
      {
         try
         {
            DBCommand cmd = new DBCommand();
            cmd.CommandText = "usp_customer_crud";
            cmd.AddWithValue("Type", "Delete");
            cmd.AddWithValue("ID", criteria.ID);
            return DB.ExecuteNonQuery(cmd);
         }
         catch (Exception)
         {
            throw;
         }
      }

      protected override List<CustomerEntity> GetList(Criteria criteria)
      {
         throw new NotImplementedException();
      }

      protected override int Save(CustomerEntity modal)
      {
         try
         {
            DBCommand cmd = new DBCommand();
            cmd.CommandText = "usp_customer_crud";
            cmd.AddWithValue("Type", "Save");
            cmd.AddWithValue("Name", modal.Name);
            cmd.AddWithValue("Salary", modal.Salary);
            return DB.ExecuteNonQuery(cmd);
         }
         catch (Exception)
         {
            throw;
         }
      }

      protected override int Update(CustomerEntity modal)
      {
         throw new NotImplementedException();
      }
   }
}
