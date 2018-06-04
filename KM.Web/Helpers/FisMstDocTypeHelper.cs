using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Libraries;
using KM.Web.Models;

namespace KM.Web.Helpers
{
    public class FisMstDocTypeHelper
    {
        public List<FisMstDocTypeModel> GetFisMstDocTypeList()
        {
            List<FisMstDocTypeModel> list = new FisMstDocTypeLibrary().GetFisMstDocTypeList();
            return list;
        }
    }
}