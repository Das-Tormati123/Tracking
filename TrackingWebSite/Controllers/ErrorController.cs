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
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}