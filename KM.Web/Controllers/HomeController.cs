using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KM.Web.Helpers;
using KM.Web.Models;

namespace KM.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FisMstDocTypeHelper fmdtHelper = new FisMstDocTypeHelper();
            ViewBag.Title = "Home";
            var docTypeList = fmdtHelper.GetFisMstDocTypeList();

            return View(docTypeList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}