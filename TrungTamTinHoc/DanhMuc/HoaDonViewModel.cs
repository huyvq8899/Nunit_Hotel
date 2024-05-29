using System;
using System.Collections.Generic;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.HoaDon
{
    public class HoaDonViewModel
    {
        public int Id { get; set; }
        public string MaDon { get; set; }
        public string TenKhach { get; set; }
        public string DiaChiKhach { get; set; }
        public string CCCD { get; set; }
        public string SoDienThoai { get; set; }
        public int SoNguoi { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }
        public decimal GiaPhong { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal ChiPhiPhu { get; set; }
        public bool TrangThai { get; set; }
        public string TenPhong { get; set; }
    }
}
