using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KM.Web.Models
{
    public class UsrinfoMstSiteModel
    {
        public int USRINFO_MST_SITE_ID { get; set; }
        public string USRINFO_MST_SITE_NAME { get; set; }
        public bool USRINFO_MST_SITE_IS_ACTIVE { get; set; }
        public string USRINFO_MST_SITE_CREATED_BY { get; set; }
        public DateTime USRINFO_MST_SITE_CREATED_AT { get; set; }
        public string USRINFO_MST_SITE_UPDATED_BY { get; set; }
        public DateTime USRINFO_MST_SITE_UPDATED_AT { get; set; }
    }
}