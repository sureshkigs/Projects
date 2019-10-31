using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EMCORWebApplication.Models;
using EMCORWebApplication.BL;
using System.Web.Script.Serialization;
using System.Globalization;

namespace EMCORWebApplication.Controllers
{
   

    public class LoginController : Controller
    {
        private LoginManager objLoginManager = new LoginManager();
       

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserClass objUserClass)
        {
            if (ModelState.IsValid)
            {
                UserClass objUser = objLoginManager.ValidateUser(objUserClass.UserName, objUserClass.Password);
                
                if(objUser == null)
                {
                    return View();
                }
                else
                {
                    
                    //SessionPersister. = objUser.UserName;
                     return RedirectToAction("Dashboard", "home");
                    
                }
                

            }
            else
            {
                return View();
            }



        }


       

    }
}