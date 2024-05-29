using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.BaoCao;
using TrungTamTinHoc.DanhMuc.DatPhong;
using TrungTamTinHoc.DanhMuc.Phong;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrungTamTinHoc.DanhMuc.HoaDon
{
    public partial class FormHoaDon : Form
    {
        private readonly SqlCommandPhong phongComand;


        public int TrangThai = 0;

        public PhongViewModel DataPhong { get; set; }
        public FormHoaDon()
        {
            phongComand = new SqlCommandPhong();

            InitializeComponent();
            dateTimeNgayDen.Format = DateTimePickerFormat.Custom;
            dateTimeNgayDen.CustomFormat = "dd/MM/yyyy HH:mm"; // This displays date and time in Vietnamese format
            dateTimeNgayDi.Format = DateTimePickerFormat.Custom;                                         // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimeNgayDi.CustomFormat = "dd/MM/yyyy HH:mm"; // This displays date and time in Vietnamese format
        }

        // Phương thức để nhận dữ liệu từ form chính
        public void SetData(TrungTamTinHoc.DanhMuc.DatPhong.PhongViewModel data)
        {
            if (data != null)
            {
                this.DataPhong = data;
                TrangThai = data.TrangThai;

                if (TrangThai == 0)
                {
                    this.SetUpForDatPhong();
                }
                else
                {
                    this.SetUpForTraPhong();
                }
            }

            SetDataFormDatPhong(data);

            // Sử dụng dữ liệu trong form mới
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaPhong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        SQLCommandHoaDon obj = new SQLCommandHoaDon();

        int vitri = 0;
        DataTable mtblgv = new DataTable();
        //======//

        void clearall()
        {
            txtMaHoaDon.Clear();
            txtTenKhachHang.Clear();
            txtDiaChiKhachHang.Clear();
            txtCCCD.Clear();
            txtSoDienThoai.Clear();
            txtGiaPhong.Value = 0;
            dateTimeNgayDen.Value = DateTime.Now;
            dateTimeNgayDi.Value = DateTime.Now;
            txtChiPhiPhu.Value = 0;
            txtGiaPhong.Value = 0;
            checkBoxTrangThai.Checked = false;

        }
        //====//
        private void GanDuLieuTuRowVaoText(DataTable tbl, int vitri)
        {
            DataRow drw;
            if (tbl.Rows.Count > 0)
            {
                drw = tbl.Rows[vitri];
                if (drw != null)
                {
                    txtMaHoaDon.Text = drw["MaDon"].ToString();
                    txtTenKhachHang.Text = drw["TenKhach"].ToString();
                    txtDiaChiKhachHang.Text = drw["DiaChiKhach"].ToString();
                    txtCCCD.Text = drw["CCCD"].ToString();
                    txtSoDienThoai.Text = drw["SoDienThoai"].ToString();
                    txtGiaPhong.Value = decimal.Parse(drw["GiaPhong"].ToString());
                    dateTimeNgayDen.Value = Convert.ToDateTime(drw["GioVao"]);
                    dateTimeNgayDi.Value = Convert.ToDateTime(drw["GioRa"]);
                    ComboBoxLoaiPhongEnum.SelectedItem = drw["TenPhong"].ToString();

                    if (drw["TrangThai"].ToString() == "true")
                    {
                        checkBoxTrangThai.Checked = true;
                    }
                    else
                    {
                        checkBoxTrangThai.Checked = false;
                    }
                }
            }



        }



        public void SetDataFormDatPhong(PhongViewModel DataPhong)
        {
            var let = phongComand.getDataSet("Phong");

            ComboBoxLoaiPhongEnum.DataSource = let.Tables["Phong"];
            ComboBoxLoaiPhongEnum.DisplayMember = "Ten"; // Hiển thị tên khách hàng trong combo box
            ComboBoxLoaiPhongEnum.ValueMember = "Ten";

            txtGiaPhong.Value = DataPhong.GiaPhong;
            checkBoxTrangThai.Checked = DataPhong.TrangThai == 0 ? false : true;
            ComboBoxLoaiPhongEnum.SelectedValue = DataPhong.Ten;
        }
        public bool kiemtradulieuphong()
        {
            if (txtMaHoaDon.Text == "" || txtTenKhachHang.Text == "" || txtGiaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.KiemTraTrungMa(txtMaHoaDon.Text))
                {
                    MessageBox.Show(" Mã này đã tồn tại !");
                    return false;
                }
                return true;
            }
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (this.DataPhong.TrangThai == 0)
            {

                bool kt;
                //=====================
                if (kiemtradulieuphong() == false)
                {

                    return;
                }
                else
                {
                    HoaDonViewModel hoaDon = new HoaDonViewModel
                    {
                        MaDon = txtMaHoaDon.Text,
                        TenKhach = txtTenKhachHang.Text,
                        DiaChiKhach = txtDiaChiKhachHang.Text,
                        CCCD = txtCCCD.Text,
                        SoDienThoai = txtSoDienThoai.Text,
                        GiaPhong = txtGiaPhong.Value,
                        GioVao = dateTimeNgayDen.Value,
                        GioRa = dateTimeNgayDi.Value,
                        ChiPhiPhu = txtChiPhiPhu.Value,
                        TenPhong = ComboBoxLoaiPhongEnum.Text,

                    };

                    kt = obj.LuuHoaDon(hoaDon);
                    if (kt == false)
                    {
                        int TrangThaiMoi = this.DataPhong.TrangThai == 1 ? 0 : 1;
                        phongComand.CapNhatTrangThaiPhong(hoaDon.TenPhong, TrangThaiMoi);
                        return;
                    }
                    else
                    {
                        int TrangThaiMoi = this.DataPhong.TrangThai == 1 ? 0 : 1;
                        phongComand.CapNhatTrangThaiPhong(hoaDon.TenPhong, TrangThaiMoi, hoaDon.MaDon);
                        DataSet ds = new DataSet();
                        ds = obj.HoaDon();
                        dgphong.DataSource = ds.Tables[0];
                        MessageBox.Show("Phòng đã đặt thành công");
                        clearall();
                        LoadData();


                    }
                }
            }
            else
            {
                bool kt;
                //=====================               
                HoaDonViewModel hoaDon = new HoaDonViewModel
                {
                    MaDon = txtMaHoaDon.Text,
                    TenKhach = txtTenKhachHang.Text,
                    DiaChiKhach = txtDiaChiKhachHang.Text,
                    CCCD = txtCCCD.Text,
                    SoDienThoai = txtSoDienThoai.Text,
                    GiaPhong = txtGiaPhong.Value,
                    GioVao = dateTimeNgayDen.Value,
                    GioRa = dateTimeNgayDi.Value,
                    ChiPhiPhu = txtChiPhiPhu.Value,
                    TenPhong = ComboBoxLoaiPhongEnum.Text,
                };


                kt = obj.SuaHoaDon(hoaDon);
                if (kt == false)
                {
                    MessageBox.Show("Ban Chua sua Duoc!");
                    return;
                }
                else
                {
                    int TrangThaiMoi = this.DataPhong.TrangThai == 1 ? 0 : 1;
                    phongComand.CapNhatTrangThaiPhong(hoaDon.TenPhong, TrangThaiMoi, "");
                    DataSet ds = new DataSet();
                    ds = obj.HoaDon();
                    dgphong.DataSource = ds.Tables[0];
                    MessageBox.Show("Phòng đã trả thành công");
                    LoadData();
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FromHoaDonLoad(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            /*            var let = phongComand.getDataSet("Phong");

                        ComboBoxLoaiPhongEnum.DataSource = let.Tables["Phong"];
                        ComboBoxLoaiPhongEnum.DisplayMember = "Ten"; // Hiển thị tên khách hàng trong combo box
                        ComboBoxLoaiPhongEnum.ValueMember = "Ten";

                        // Load du liwu cua phong*/
            if (this.DataPhong != null)
            {
                string HoaDonId = this.DataPhong.HoaDonId;
                if (HoaDonId != "")
                {
                    mtblgv = obj.getDataTableDatPhong("HoaDon", HoaDonId);
                    GanDuLieuTuRowVaoText(mtblgv, vitri);
                }
            }

        }

        private void YourSelectidonChangedEventHandler(object sender, EventArgs e)
        {
            if (dgphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgphong.SelectedRows[0];

                // Lấy giá trị từ các cột ban đầu
                string column1Value = selectedRow.Cells["MaDon"].Value.ToString();
                string column2Value = selectedRow.Cells["TenKhach"].Value.ToString();
                string column3Value = selectedRow.Cells["GiaPhong"].Value.ToString();
                string column4Value = selectedRow.Cells["GioDen"].Value.ToString();
                string column5Value = selectedRow.Cells["GioRa"].Value.ToString();
                string column6Value = selectedRow.Cells["ChiPhiPhu"].Value.ToString();
                string trangThaiCellValue = selectedRow.Cells["TrangThai"].Value.ToString();
                int trangThaiValue = int.Parse(trangThaiCellValue);
                checkBoxTrangThai.Checked = trangThaiValue == 1 ? true : false;

                // Gán giá trị từ các cột ban đầu vào các cột mới
                txtMaHoaDon.Text = column1Value;
                txtTenKhachHang.Text = column2Value;
                txtGiaPhong.Value = decimal.Parse(column3Value);
                dateTimeNgayDen.Value = Convert.ToDateTime(column4Value);
                dateTimeNgayDi.Value = Convert.ToDateTime(column5Value);
                txtChiPhiPhu.Value = decimal.Parse(column6Value);
            }
        }


        private void SetUpForDatPhong()
        {
            btnhapmoi.Text = "Đặt phòng";
        }

        private void SetUpForTraPhong()
        {
            btnhapmoi.Text = "Trả phòng";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
