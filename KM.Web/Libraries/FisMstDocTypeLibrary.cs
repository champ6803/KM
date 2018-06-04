using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Models;
using KM.Web.Entities;

namespace KM.Web.Libraries
{
    public class FisMstDocTypeLibrary
    {
        string SOURCE = "FisMstDocTypeLibrary";
        string ACTION = "";
        kmEntities dbh = new kmEntities();

        internal FisMstDocTypeModel Mapping(fis_mst_doc_type o)
        {
            ACTION = "Mapping(fis_mst_doc_type)";
            try
            {
                if (o != null)
                {
                    return new FisMstDocTypeModel()
                    {
                        FIS_MST_DOC_TYPE_ID = o.FIS_MST_DOC_TYPE_ID,
                        FIS_MST_DOC_TYPE_NAME = o.FIS_MST_DOC_TYPE_NAME,
                        FIS_MST_DOC_TYPE_IS_ACTIVE = o.FIS_MST_DOC_TYPE_IS_ACTIVE
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
            ACTION = "Mapping(fis_mst_doc_type)";
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
                            FIS_MST_DOC_TYPE_NAME = o.FIS_MST_DOC_TYPE_NAME,
                            FIS_MST_DOC_TYPE_IS_ACTIVE = o.FIS_MST_DOC_TYPE_IS_ACTIVE
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

        public List<FisMstDocTypeModel> GetFisMstDocTypeList()
        {
            ACTION = "GetFisMstDocTypeModel()";

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