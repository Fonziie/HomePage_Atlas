using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomePage_Atlas.Controllers
{
    /* HJEMME SIDER */
    public class HomeController : Controller
    {
        /* Forside */
        public ActionResult Index()
        {
            return View();
        }
        /* Information */
        public ActionResult Information()
        {
            return View();
        }
        /* Information */
        public ActionResult Events()
        {
            return View();
        }
        /* Information */
        public ActionResult Galleri()
        {
            return View();
        }
        /* ORGANISATION */
        public ActionResult Organisation()
        {
            return View();
        }



        /* AFDELINGER */
        public ActionResult Afdelinger()
        {
            return View();
        }
        /* PERSONALE */
        public ActionResult Personale()
        {
            return View();
        }
    }
    /* FORM SIDER */
    public class FormController : Controller
    {
        /* ANSØG */
        public ActionResult Index()
        {
            return View();
        }
    }


    /* TEST */
    public class TestController : Controller
    {
        /* ANSØG */
        public ActionResult Index()
        {
            return View();
        }
    }
}
