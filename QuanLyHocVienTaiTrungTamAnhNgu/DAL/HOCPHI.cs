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
    
    public partial class HOCPHI
    {
        public string MaHocPhi { get; set; }
        public string MaHocVien { get; set; }
        public decimal SoTienCanDong { get; set; }
        public decimal SoTienDaDong { get; set; }
        public decimal SoDu { get; set; }
        public decimal No { get; set; }
        public int TrangThai { get; set; }
    
        public virtual HOCVIEN HOCVIEN { get; set; }
    }
}
