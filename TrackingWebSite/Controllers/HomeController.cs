using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrackingWebSite.Models;
using System.Configuration;
using TrackingWebSite.DataAccessLayer;
using CommonClasses;

namespace TrackingWebSite.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                
                return View();
            }
            
            return RedirectToAction("Index", "DashBoard");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(ViewLogin viewLogin)
        {

            LoginDataAccess loginDAL = new LoginDataAccess(connectionString);
            try
            {
                bool isValid = false;
                isValid = loginDAL.ValidataLogin(viewLogin.Username, viewLogin.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(viewLogin.Username, false);
                    return RedirectToAction("Index", "DashBoard");
                }
                TempData["Message"] = "Invalid username or password";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
            finally
            {

            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}