//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finalprj.myDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDonNhapHang
    {
        public string IDhoaDonNH { get; set; }
        public string IDhang { get; set; }
        public int soLuong { get; set; }
    
        public virtual KhoHang KhoHang { get; set; }
        public virtual HoaDonNhapHang HoaDonNhapHang { get; set; }
    }
}
