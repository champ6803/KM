﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KM.Web.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kmEntities : DbContext
    {
        public kmEntities()
            : base("name=kmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fis_mst_doc_type> fis_mst_doc_type { get; set; }
        public virtual DbSet<fis_t_data_insrt> fis_t_data_insrt { get; set; }
        public virtual DbSet<fis_t_data_insrt_detail> fis_t_data_insrt_detail { get; set; }
        public virtual DbSet<usrinfo_mst_site> usrinfo_mst_site { get; set; }
    }
}
