using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.HoaDon;
using TrungTamTinHoc.DanhMuc.Phong;

namespace TrungTamTinHoc.DanhMuc.BaoCao
{
    public partial class FormThongKeDatPhong : Form
    {

        public FormThongKeDatPhong()
        {

            InitializeComponent();
            dateTimeNgayDen.Format = DateTimePickerFormat.Custom;
            dateTimeNgayDen.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeNgayDen.Value = DateTime.Today; // Đặt giá trị mặc định là 00:00 của hôm nay

            dateTimeNgayDi.Format = DateTimePickerFormat.Custom;
            dateTimeNgayDi.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeNgayDi.Value = DateTime.Today.AddDays(1).AddMinutes(-1); // Đặt giá trị mặc định là 23:59 của hôm nay
            // Tạo một ImageList và thêm biểu tượng vào đó
            ImageList imageList = new ImageList();
            imageList.Images.Add("iconKey", Properties.Resources.Add); // Thay thế "iconKey" bằng một khóa độc nhất cho biểu tượng

            // Tạo một nút và gán biểu tượng cho nút
            myButton.ImageList = imageList;
            myButton.ImageKey = "iconKey"; // Thay thế "iconKey" bằng khóa của biểu tượng trong ImageList

            myButton.ImageAlign = ContentAlignment.TopLeft; // Đặt ảnh ở vị trí trái cùng
            myButton.TextImageRelation = TextImageRelation.ImageBeforeText; // Đặt ảnh trước chữ

        }

        SQLCommandBaoCao SQLCommandBaoCao = new SQLCommandBaoCao();
        private void LoadBaoCaoThongKe(object sender, EventArgs e)
        {

            DateTime fromDate = dateTimeNgayDen.Value; // Thay thế bằng ngày bắt đầu
            DateTime toDate = dateTimeNgayDi.Value; // Thay thế bằng ngày kết thúc
            string maPhong = "Mã phòng cần báo cáo"; // Thay thế bằng mã phòng cần báo cáo

            BaoCaoViewModel baoCaoThanhCong = SQLCommandBaoCao.BaoCaoDoanhThu(fromDate, toDate, "1");
            textTongDoanhThu.Value = baoCaoThanhCong.TongTienHoaDon;
            txtTongSoLuongKhach.Value = baoCaoThanhCong.SoLuongHoaDon;

            LoadData();

        }

        SQLCommandHoaDon sqlHoaDon = new SQLCommandHoaDon();
        int vitri = 0;
        DataTable mtblgv = new DataTable();
        private void LoadData()
        {
            mtblgv = sqlHoaDon.getDataTable("HoaDon");
            DataSet ds = new DataSet();
            ds = sqlHoaDon.getDataSet("HoaDon");
            dgphong.DataSource = ds.Tables[0];
            //crystalReportViewer1.ReportSource = ds;

            var cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\Project-PMBK\OS\Small_hotel\TrungTamTinHoc\TrungTamTinHoc\CrystalReport4.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
