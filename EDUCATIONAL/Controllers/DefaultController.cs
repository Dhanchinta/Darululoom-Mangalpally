using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDUCATIONAL.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult BLOG()
        {
            return View();
        }
        public ActionResult EVENTS()
        {
            return View();
        }
        public ActionResult GALLERY()
        {
            return View();
        }
        public ActionResult MANAGEMENT()
        {
            return View();
        }
        
    }
}