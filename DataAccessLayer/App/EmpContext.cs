using DataAccessLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_POC.App
{
   public class EmpContext : DBContext<EmpEntiry, Criteria>
   {
      protected override int Delete(Criteria criteria)
      {
         throw new NotImplementedException();
      }

      protected override List<EmpEntiry> GetList(Criteria criteria)
      {
         throw new NotImplementedException();
      }

      protected override int Save(EmpEntiry modal)
      {
         throw new NotImplementedException();
      }

      protected override int Update(EmpEntiry modal)
      {
         throw new NotImplementedException();
      }
   }
}
