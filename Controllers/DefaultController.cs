using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelRezervasyonMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2() 
        {
            return View();
        }
        public ActionResult Anasayfa()
        {
            return View(); 
        }
        public ActionResult Hakkımda()
        {
            return View(); 
        }
        
        public ActionResult İletisim()
        {
            return View();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}