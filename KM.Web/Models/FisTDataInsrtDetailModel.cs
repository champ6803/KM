using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM.Web.Models
{
    public class FisTDataInsrtDetailModel
    {
        public int FIS_T_DATA_INSRT_DETAIL_ID { get; set; }
        public int FIS_T_DATA_INSRT_ID { get; set; }
        public string FIS_T_DATA_INSRT_DETAIL_DES { get; set; }
        public bool FIS_T_DATA_INSRT_DETAIL_IS_ACTIVE { get; set; }
        public string FIS_T_DATA_INSRT_DETAIL_CREATED_BY { get; set; }
        public DateTime FIS_T_DATA_INSRT_DETAIL_CREATED_AT { get; set; }
        public string FIS_T_DATA_INSRT_DETAIL_UPDATED_BY { get; set; }
        public DateTime FIS_T_DATA_INSRT_DETAIL_UPDATED_AT { get; set; }
    }
}