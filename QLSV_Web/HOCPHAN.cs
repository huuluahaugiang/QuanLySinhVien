//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class HOCPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCPHAN()
        {
            this.DIEMs = new HashSet<DIEM>();
            this.KHUNGCTs = new HashSet<KHUNGCT>();
        }
    
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
        public int SoTinChi { get; set; }
        public string MaBoMon { get; set; }
        public string MaDonVi { get; set; }
    
        public virtual BOMON BOMON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
        public virtual DONVI DONVI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHUNGCT> KHUNGCTs { get; set; }
    }
}
