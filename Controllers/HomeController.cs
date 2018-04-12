using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp6.Controllers
{
    public class HomeController : Controller
    {
        //Action
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}