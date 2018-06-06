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
            var docTypeList = fmdtHelper.GetFisMstDocTypeList();
            return View(docTypeList);
        }

        public ActionResult GetMasterDoctype()
        {
            try
            {
                FisMstDocTypeHelper docTypeHelper = new FisMstDocTypeHelper();
                var masterDocType = docTypeHelper.GetFisMstDocTypeList();
                return Json(masterDocType, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
    }
}