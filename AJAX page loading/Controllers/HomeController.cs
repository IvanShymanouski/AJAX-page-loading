using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX_page_loading.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Additional(bool modal = true)
        {
            ViewBag.modal = modal;
            return View();
        }
    }
}
