using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class LoginDriverDetails
    {
        public string DriverName { get; set; }
        public int DriverloginId { get; set; }
        public Guid DriverGUID { get; set; }
        public int MappedSchoolId { get; set; }
    }
}
