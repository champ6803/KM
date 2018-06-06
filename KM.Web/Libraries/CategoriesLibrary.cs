using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Entities;
using KM.Web.Helpers;
using KM.Web.Models;

namespace KM.Web.Libraries
{
    public class CategoriesLibrary
    {
        string SOURCE = "CategoriesLibrary";
        string ACTION = "";
        kmEntities dbh = new kmEntities();

        internal FisMstDocTypeModel Mapping(fis_mst_doc_type o)
        {
            //ACTION = "Mapping(fis_mst_doc_type)";
            try
            {
                if (o != null)
                {
                    return new FisMstDocTypeModel()
                    {
                        FIS_MST_DOC_TYPE_ID = o.FIS_MST_DOC_TYPE_ID,
                        FIS_MST_DOC_TYPE_NAME = o.FIS_MST_DOC_TYPE_DETAIL,
                        FIS_MST_DOC_TYPE_DETAIL = o.FIS_MST_DOC_TYPE_DETAIL,
                        FIS_MST_DOC_TYPE_IS_ACTIVE = o.FIS_MST_DOC_TYPE_IS_ACTIVE,
                        FIS_MST_DOC_TYPE_CREATED_BY_ID = o.FIS_MST_DOC_TYPE_CREATED_BY_ID,
                        FIS_MST_DOC_TYPE_CREATED_BY = o.FIS_MST_DOC_TYPE_CREATED_BY,
                        FIS_MST_DOC_TYPE_CREATED_AT = o.FIS_MST_DOC_TYPE_CREATED_AT,
                        FIS_MST_DOC_TYPE_UPDATED_BY = o.FIS_MST_DOC_TYPE_UPDATED_BY,
                        FIS_MST_DOC_TYPE_UPDATED_AT = o.FIS_MST_DOC_TYPE_UPDATED_AT
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal List<FisMstDocTypeModel> Mapping(List<fis_mst_doc_type> list)
        {
            //ACTION = "Mapping(fis_mst_doc_type)";
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<FisMstDocTypeModel> mList = new List<FisMstDocTypeModel>();

                    foreach (fis_mst_doc_type o in list)
                    {
                        mList.Add(new FisMstDocTypeModel()
                        {
                            FIS_MST_DOC_TYPE_ID = o.FIS_MST_DOC_TYPE_ID,
                            FIS_MST_DOC_TYPE_NAME = o.FIS_MST_DOC_TYPE_DETAIL,
                            FIS_MST_DOC_TYPE_DETAIL = o.FIS_MST_DOC_TYPE_DETAIL,
                            FIS_MST_DOC_TYPE_IS_ACTIVE = o.FIS_MST_DOC_TYPE_IS_ACTIVE,
                            FIS_MST_DOC_TYPE_CREATED_BY_ID = o.FIS_MST_DOC_TYPE_CREATED_BY_ID,
                            FIS_MST_DOC_TYPE_CREATED_BY = o.FIS_MST_DOC_TYPE_CREATED_BY,
                            FIS_MST_DOC_TYPE_CREATED_AT = o.FIS_MST_DOC_TYPE_CREATED_AT,
                            FIS_MST_DOC_TYPE_UPDATED_BY = o.FIS_MST_DOC_TYPE_UPDATED_BY,
                            FIS_MST_DOC_TYPE_UPDATED_AT = o.FIS_MST_DOC_TYPE_UPDATED_AT
                        });
                    }

                    return mList;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<fis_mst_doc_type> IQueryable()
        {
            return dbh.fis_mst_doc_type;
        }

        public List<FisMstDocTypeModel> GetCategoriesList()
        {
            //ACTION = "GetFisMstDocTypeModel()";

            try
            {
                List<fis_mst_doc_type> objList = IQueryable().ToList();
                List<FisMstDocTypeModel> m = Mapping(objList);

                return m;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}