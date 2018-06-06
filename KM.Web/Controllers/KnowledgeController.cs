using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KM.Web.Helpers;
using KM.Web.Models;

namespace KM.Web.Controllers
{
    public class KnowledgeController : Controller
    {   
        // GET: Knowledge
        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Documents()
        {
            return View();
        }

        public ActionResult DocumentDetail()
        {
            return View();
        }

        public ActionResult GetCategories()
        {
            try
            {
                var categoriesList = new CategoriesHelper().GetCategoriesList();

                return Json(categoriesList, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}