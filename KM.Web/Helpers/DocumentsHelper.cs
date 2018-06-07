using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Models;
using KM.Web.Libraries;

namespace KM.Web.Helpers
{
    public class DocumentsHelper
    {
        public List<DocumentModel> GetDocumentDetailByMasterId(int mstId)
        {
            return new DocumentsLibrary().GetDocumentDetailByMasterId(mstId);
        }

        public DocumentModel GetDocumentDeatailByDocumentId(int docId)
        {
            return new DocumentsLibrary().GetDocumentDetailByDocumentId(docId);
        }
    }
}