using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        //public ActionResult Index()
        //{
        //    DateTime date = DateTime.Now;
        //    return View(date);
        //}

        public RedirectToRouteResult Redirect()
        {
            return RedirectToRoute(new { controller = "Example", action = "Index", ID = "MyID" });
        }

        //public RedirectResult Redirect()
        //{
        //    return Redirect("/Example/Index");
        //    //return RedirectPermanent("/Example/Index");
        //}

        public HttpStatusCodeResult StatusCode()
        {
            //return new HttpStatusCodeResult(404, "URL cannot be serviced");
            //return HttpNotFound();
            return new HttpUnauthorizedResult();
        }
    }
}