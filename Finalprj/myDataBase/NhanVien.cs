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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.HoaDonBanHangs = new HashSet<HoaDonBanHang>();
            this.HoaDonNhapHangs = new HashSet<HoaDonNhapHang>();
            this.LoginNhanViens = new HashSet<LoginNhanVien>();
        }
    
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public System.DateTime NgayVaoLam { get; set; }
        public Nullable<System.DateTime> NgayNghiViec { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonNhapHang> HoaDonNhapHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginNhanVien> LoginNhanViens { get; set; }
    }
}
