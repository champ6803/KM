using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Models;
using KM.Web.Libraries;

namespace KM.Web.Helpers
{
    public class CategoriesHelper
    {
        public List<FisMstDocTypeModel> GetCategoriesList()
        {
            List<FisMstDocTypeModel> list = new CategoriesLibrary().GetCategoriesList();
            return list;
        }
    }
}