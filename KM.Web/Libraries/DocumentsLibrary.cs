using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KM.Web.Entities;
using KM.Web.Models;

namespace KM.Web.Libraries
{
    public class DocumentsLibrary
    {
        kmEntities dbh = new kmEntities();

        internal DocumentModel Mapping(fis_mst_doc_type o)
        {
            //ACTION = "Mapping(fis_mst_doc_type)";
            try
            {
                if (o != null)
                {
                    return new DocumentModel()
                    {

                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<fis_t_data_insrt> IQueryable()
        {
            return dbh.fis_t_data_insrt;
        }

        public IQueryable<fis_t_data_insrt_detail> IQueryableDetail()
        {
            return dbh.fis_t_data_insrt_detail;
        }

        public DocumentModel GetDocumentDetailByDocumentId(int docId)
        {
            try
            {
                fis_t_data_insrt doc = IQueryable().FirstOrDefault(o => o.FIS_T_DATA_INSRT_ID == docId);
                DocumentModel docModel = new DocumentModel();
                if (doc != null)
                {
                    string docText = "";
                    List<fis_t_data_insrt_detail> docDetailList = IQueryableDetail().Where(o => o.FIS_T_DATA_INSRT_ID == doc.FIS_T_DATA_INSRT_ID).ToList();
                    if (docDetailList.Count > 0)
                    {
                        foreach (fis_t_data_insrt_detail docDetail in docDetailList)
                        {
                            docText = docText + docDetail.FIS_T_DATA_INSRT_DETAIL_DES;
                        }
                    }
                    docModel.DocumentId = doc.FIS_T_DATA_INSRT_ID;
                    docModel.DocumentName = doc.FIS_T_DATA_INSRT_NAME;
                    docModel.DocumentDetail = docText;
                }
                return docModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<DocumentModel> GetDocumentDetailByMasterId(int mstId)
        {
            //ACTION = "GetFisMstDocTypeModel()";
            try
            {
                List<fis_t_data_insrt> objList = IQueryable().Where(o => o.FIS_MST_DOC_TYPE_ID == mstId).ToList();
                //List<DocumentModel> m = Mapping(objList);
                List<DocumentModel> docList = new List<DocumentModel>();
                if (objList.Count > 0)
                {
                    foreach (fis_t_data_insrt obj in objList)
                    {
                        List<fis_t_data_insrt_detail> objDetailList = IQueryableDetail().Where(o => o.FIS_T_DATA_INSRT_ID == obj.FIS_T_DATA_INSRT_ID).ToList();
                        string textDoc = "";
                        if (objDetailList.Count > 0)
                        {
                            foreach (fis_t_data_insrt_detail objDetail in objDetailList)
                            {
                                textDoc = textDoc + objDetail.FIS_T_DATA_INSRT_DETAIL_DES;
                            }
                        }
                        DocumentModel docModel = new DocumentModel();
                        docModel.DocumentId = obj.FIS_T_DATA_INSRT_ID;
                        docModel.DocumentName = obj.FIS_T_DATA_INSRT_NAME;
                        docModel.DocumentDetail = textDoc;
                        docList.Add(docModel);
                    }
                }

                return docList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}