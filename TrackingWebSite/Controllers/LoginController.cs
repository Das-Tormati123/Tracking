using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Security.Cryptography;
using System.Configuration;
using TrackingWebSite.Models;
using System.Runtime.Remoting.Messaging;
using System.Web.Security;

namespace TrackingWebSite.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
    }
}