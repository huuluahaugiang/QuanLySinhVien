﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSV_Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLSV2021Entities3 : DbContext
    {
        public QLSV2021Entities3()
            : base("name=QLSV2021Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
    
        public virtual ObjectResult<LaySVTheoLop_Result> LaySVTheoLop(string maLop)
        {
            var maLopParameter = maLop != null ?
                new ObjectParameter("MaLop", maLop) :
                new ObjectParameter("MaLop", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LaySVTheoLop_Result>("LaySVTheoLop", maLopParameter);
        }
    }
}
