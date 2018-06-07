using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KM.Web.Helpers;
using KM.Web.Models;

namespace KM.Web.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult Documents()
        {
            return View();
        }

        protected DocumentsHelper docHelp = new DocumentsHelper();
         
        [HttpPost]
        public ActionResult GetDocumentDetailByMasterId(int docTypeId)
        {
            try
            {
                if (docTypeId != 0) {
                    var docDeatail = docHelp.GetDocumentDetailByMasterId(docTypeId);
                    return Json(docDeatail, JsonRequestBehavior.AllowGet);
                }
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult GetDocumentDetailByDocumentId(int docId)
        {
            try
            {
                if (docId != 0)
                {
                    var docDetail = docHelp.GetDocumentDeatailByDocumentId(docId);
                    return Json(docDetail, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}