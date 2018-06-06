using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM.Web.Models
{
    public class FisTDataInsrtModel
    {
        public int FIS_T_DATA_INSRT_ID { get; set; }
        public int FIS_MST_DOC_TYPE_ID { get; set; }
        public int USRINFO_MST_SITE_ID { get; set; }
        public string FIS_T_DATA_INSRT_NAME { get; set; }
        public bool FIS_T_DATA_INSRT_IS_ACTIVE { get; set; }
        public string FIS_T_DATA_INSRT_CREATED_BY { get; set; }
        public DateTime FIS_T_DATA_INSRT_CREATED_AT { get; set; }
        public string FIS_T_DATA_INSRT_UPDATED_BY { get; set; }
        public DateTime FIS_T_DATA_INSRT_UPDATED_AT { get; set; }
    }
}