//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity2
{
    using System;
    using System.Collections.Generic;
    
    public partial class HocPhi
    {
        public string SoBL { get; set; }
        public string MSHV { get; set; }
        public Nullable<System.DateTime> NgayThu { get; set; }
        public Nullable<int> SoTien { get; set; }
        public string NoiDung { get; set; }
        public string NguoiThu { get; set; }
    
        public virtual HocVien HocVien { get; set; }
    }
}
