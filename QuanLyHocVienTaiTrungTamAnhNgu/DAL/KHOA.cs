//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA()
        {
            this.LOPHOC_KHOAHOC = new HashSet<LOPHOC_KHOAHOC>();
        }
    
        public string MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public System.DateTime ThoiGianBatDau { get; set; }
        public System.DateTime ThoiGianKetThuc { get; set; }
        public int TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPHOC_KHOAHOC> LOPHOC_KHOAHOC { get; set; }
    }
}
