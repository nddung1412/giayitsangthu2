//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceGiayit
{
    using System;
    using System.Collections.Generic;
    
    public partial class sanpham
    {
        public sanpham()
        {
            this.chitiethoadons = new HashSet<chitiethoadon>();
            this.chitietphieunhaps = new HashSet<chitietphieunhap>();
        }
    
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public string chatlieu { get; set; }
        public int giasanpham { get; set; }
        public string motasanpham { get; set; }
        public int soluongcon { get; set; }
        public int sanphammoi { get; set; }
        public string hinhanh { get; set; }
        public int ghichu { get; set; }
        public string maloai { get; set; }
        public Nullable<int> manhacungcap { get; set; }
        public int stt { get; set; }
    
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }
        public virtual ICollection<chitietphieunhap> chitietphieunhaps { get; set; }
        public virtual loaisanpham loaisanpham { get; set; }
        public virtual nhacungcap nhacungcap { get; set; }
    }
}
