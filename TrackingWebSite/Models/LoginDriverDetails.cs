using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingWebSite.Models
{
    public class LoginDriverDetails
    {
        public string DriverName { get; set; }
        public int DriverloginId { get; set; }
        public Guid DriverGUID { get; set; }
        public int MappedSchoolId { get; set; }
    }
}