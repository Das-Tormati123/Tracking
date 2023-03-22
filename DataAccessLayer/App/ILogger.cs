using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_POC
{
   public interface ILogger
   {
      void Error(string message, Exception ex);
      void Info(string message);
   }
}
