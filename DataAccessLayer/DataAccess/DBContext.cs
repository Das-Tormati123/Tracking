using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataBase
{
   public abstract class DBContext<T,T1>
   {
      public IDatabase DB;
      protected abstract int Save(T modal);
      protected abstract int Update(T modal);
      protected abstract int Delete(T1 criteria);
      protected abstract List<T> GetList(T1 criteria);

      public void Initialize()
      {
         DB = DatabaseContext.GetDatabase();
      }
      public int Create(T modal,DBOperation dBOperation) {
         try
         {
            Initialize();
            DB.OpenConnection();
            if (dBOperation == DBOperation.New)
               return Save(modal);
            else
               return Update(modal);
         }
         catch
         {
            throw;
         }
         finally
         {
            DB.CloseConnection();
         }
      }
      public int Remove(T1 criteria)
      {
         try
         {
            Initialize();
            DB.OpenConnection();
            return Delete(criteria);
         }
         catch
         {
            throw;
         }
         finally {
            DB.CloseConnection();
         }
         
      }
      public List<T> List(T1 criteria)
      {
         try
         {
            Initialize();
            DB.OpenConnection();
            return GetList(criteria);
         }
         catch
         {
            throw;
         }
         finally
         {
            DB.CloseConnection();
         }
      }
   }
}
