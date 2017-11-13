using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitCherryManager.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Manage Cherries";

            return View();
        }
    }
}
