using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
        {
            return Redirect("/Basic/Index");
            //return new RedirectResult("/Basic/Index");

            //if (Server.MachineName == "TINY")
            //{
            //    //Response.Redirect("/Basic/Index");
            //    return new CustomRedirectResult { Url = "/Basic/Index" };
            //}
            //else
            //{
            //    //Response.Write("Controller: Derived, Action: ProduceOutput");
            //    return null;
            //}
        }
    }
}