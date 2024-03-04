using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace application.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult UserHome()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {

                return View();
            }
        }
        [HttpPost]
        public ActionResult UserHome(string cbutton)
        {

            if (cbutton == "Logout")
            {
                Session.Abandon();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }

    }
}