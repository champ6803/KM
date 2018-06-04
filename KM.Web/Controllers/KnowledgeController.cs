using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}