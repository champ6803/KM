using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM.Web.Models
{
    public class FisMstDocTypeModel
    {
        public int FIS_MST_DOC_TYPE_ID { get; set; }
        public string FIS_MST_DOC_TYPE_NAME { get; set; }
        public string FIS_MST_DOC_TYPE_DETAIL { get; set; }
        public bool FIS_MST_DOC_TYPE_IS_ACTIVE { get; set; }
        public string FIS_MST_DOC_TYPE_CREATED_BY { get; set; }
        public int? FIS_MST_DOC_TYPE_CREATED_BY_ID { get; set; }
        public DateTime FIS_MST_DOC_TYPE_CREATED_AT { get; set; }
        public string FIS_MST_DOC_TYPE_UPDATED_BY { get; set; }
        public DateTime FIS_MST_DOC_TYPE_UPDATED_AT { get; set; }
    }
}