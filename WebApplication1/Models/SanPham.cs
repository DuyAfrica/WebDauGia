//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public int ID_SanPham { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public Nullable<decimal> GiaKhoiDiem { get; set; }
        public Nullable<decimal> BuocGia { get; set; }
        public Nullable<decimal> GiaMuaNgay { get; set; }
        public string TenNguoiBan { get; set; }
        public Nullable<System.DateTime> ThoiGianDang { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> ID_DanhMuc { get; set; }
    }
}
