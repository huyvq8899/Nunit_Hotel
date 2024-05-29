using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.DatPhong
{
    public class PhongViewModel
    {
        public string Ma { get; set; }      // Mã phòng
        public string Ten { get; set; }     // Tên phòng
        public string LoaiPhong { get; set; } // Loại phòng
        public decimal GiaPhong { get; set; } // Giá phòng
        public string MoTa { get; set; }     // Mô tả
        public int TrangThai { get; set; } // Trạng thái phòng
            
        // Nếu bạn muốn lưu hình ảnh và màu sắc, bạn có thể sử dụng kiểu dữ liệu tương ứng.
        public Image HinhAnh { get; set; }    // Hình ảnh phòng (sử dụng kiểu dữ liệu phù hợp)
        public Color MauSac { get; set; }     // Màu sắc phòng (sử dụng kiểu dữ liệu phù hợp)

        public string HoaDonId { get; set; }
    }

}
