using CommonClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackingWebSite.DataAccessLayer;

namespace TrackingWebSite.Controllers
{
    [Authorize]
    public class MapsController : Controller
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // GET: Maps
        public ActionResult Index()
        {
            return View();  
        }
        [HttpGet]
        public JsonResult GetAllDriverData()
        {
            IList<LoginDriverDetails> listDrivers = new List<LoginDriverDetails>();
            try
            {
                MapsDataAccess mapsDataAccess = new MapsDataAccess(connectionString);
                listDrivers = mapsDataAccess.ValidataLogin();
            }
            catch(Exception Ex)
            {

            }
            return Json(listDrivers, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Animate()
        {
            return View();
        }
        public ActionResult Icon()
        {
            return View();
        }
        public ActionResult Steet()
        {
            return View();
        }
        public ActionResult ModeTravel()
        {
            return View();
        }
        public ActionResult Traffic()
        {
            return View();
        }
        public ActionResult RouteColor()
        {
            return View();
        }
    }
}