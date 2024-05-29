using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.BaoCao;
using TrungTamTinHoc.DanhMuc.DatPhong;
using TrungTamTinHoc.DanhMuc.VatTu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrungTamTinHoc.DanhMuc.Phong
{
    public partial class FormPhong : Form
    {
        private readonly SqlCommandPhong obj;
        private readonly FormDatPhong FormDatPhong;

        public List<string> ListLoaiPhong = new List<string>
                {
                    "Phòng thường",
                    "Phòng Vip",
                    "Phòng thường 3 ngủ",
                    "Phòng thường 2 ngủ đôi"
                };

        public FormPhong()
        {
            this.obj = new SqlCommandPhong();
            InitializeComponent();

            // Gán danh sách mục vào ComboBox
            ComboBoxLoaiPhongEnum.DataSource = ListLoaiPhong;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        int vitri = 0;
        DataTable mtblgv = new DataTable();
        //======//

        void clearall()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMoTa.Clear();
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
                    txtMa.Text = drw["Ma"].ToString();
                    txtTen.Text = drw["Ten"].ToString();
                    txtGiaPhong.Text = drw["GiaPhong"].ToString();
                    txtMoTa.Text = drw["MoTa"].ToString();
                    if (drw["TrangThai"].ToString() == "true")
                    {
                        checkBoxTrangThai.Checked = true;
                    }
                    else
                    {
                        checkBoxTrangThai.Checked = false;
                    }
                    ComboBoxLoaiPhongEnum.DataSource = ListLoaiPhong;
                    var loaiPhongValue = drw["LoaiPhong"].ToString();
                    ComboBoxLoaiPhongEnum.SelectedItem = loaiPhongValue;
                }
            }



        }
        public bool kiemtradulieuphong()
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGiaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.KiemTraTrungMa(txtMa.Text))
                {
                    MessageBox.Show(" Mã phòng này đã tồn tại !");
                    return false;
                }
                return true;
            }
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (btsua.Enabled == false)
            {

                bool kt;
                //=====================
                if (kiemtradulieuphong() == false)
                {

                    return;
                }
                else
                {
                    string Ma, Ten, LoaiPhong, Mota;
                    bool trangThai;
                    decimal giaPhong;
                    Ma = txtMa.Text;
                    Ten = txtTen.Text;
                    giaPhong = txtGiaPhong.Value;
                    Mota = txtMoTa.Text;
                    trangThai = checkBoxTrangThai.Checked;
                    LoaiPhong = ComboBoxLoaiPhongEnum.SelectedValue.ToString();


                    kt = obj.LuuPhong(Ma, Ten, LoaiPhong, Mota, giaPhong, trangThai);
                    if (kt == false)
                    {
                        MessageBox.Show("Ban Chua Them Duoc!");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = obj.phong();
                        dgphong.DataSource = ds.Tables[0];
                        MessageBox.Show("Ban Them Thanh Cong !");
                        clearall();
                        btluu.Enabled = false;
                        btsua.Enabled = true;
                        btnhapmoi.Text = "Nhập mới";

                        LoadData();


                    }
                }
            }
            else
            {
                bool kt;
                //=====================               
                string Ma, Ten, LoaiPhong, Mota;
                bool trangThai;
                decimal giaPhong;
                Ma = txtMa.Text;
                Ten = txtTen.Text;
                giaPhong = txtGiaPhong.Value;
                Mota = txtMoTa.Text;
                trangThai = checkBoxTrangThai.Checked;
                LoaiPhong = ComboBoxLoaiPhongEnum.SelectedValue.ToString();


                kt = obj.SuaVatTu(Ma, Ten, LoaiPhong, Mota, giaPhong, trangThai);
                if (kt == false)
                {
                    MessageBox.Show("Ban Chua sua Duoc!");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = obj.phong();
                    dgphong.DataSource = ds.Tables[0];
                    MessageBox.Show("Ban da sua Thanh Cong !");
                    //ClearAll();
                    btluu.Enabled = false;
                    btsua.Enabled = true;
                    btnhapmoi.Enabled = true;

                    btsua.Text = "Sửa";
                    LoadData();
                }

            }
        }

        private void btnhapmoi_Click(object sender, EventArgs e)
        {
            clearall();


            if (btnhapmoi.Text == "Nhập mới")
            {

                btnhapmoi.Text = "Huỷ Nhập";
                btsua.Enabled = false;

                btluu.Enabled = true;
            }
            else
            {

                btluu.Enabled = false;
                btnhapmoi.Text = "Nhập mới";
                btsua.Enabled = true;


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDatPhong.Show();

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (btsua.Text == "Sửa")
            {

                txtMa.Enabled = false;
                btnhapmoi.Enabled = false;

                btsua.Text = "Huỷ sửa";
                btluu.Enabled = true;

            }
            else
            {
                txtMa.Enabled = true;
                btluu.Enabled = false;
                btsua.Text = "Sửa";
                btnhapmoi.Enabled = true;


            }
        }

        private void FromPhongLoad(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            mtblgv = obj.getDataTable("Phong");
            GanDuLieuTuRowVaoText(mtblgv, vitri);
            DataSet ds = new DataSet();
            ds = obj.getDataSet("Phong");
            dgphong.DataSource = ds.Tables[0];
            btluu.Enabled = false;
            clearall();
        }

        private void YourSelectidonChangedEventHandler(object sender, EventArgs e)
        {
            if (dgphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgphong.SelectedRows[0];

                // Lấy dữ liệu từ các cột của dòng đã chọn
                string column1Value = selectedRow.Cells["Ma"].Value.ToString();
                string column2Value = selectedRow.Cells["Ten"].Value.ToString();
                string column3Value = selectedRow.Cells["GiaPhong"].Value.ToString();
                string column4Value = selectedRow.Cells["LoaiPhong"].Value.ToString();
                string column5Value = selectedRow.Cells["MoTa"].Value.ToString();

                string trangThaiCellValue = selectedRow.Cells["TrangThai"].Value.ToString();
                int trangThaiValue = int.Parse(trangThaiCellValue);
                checkBoxTrangThai.Checked = trangThaiValue == 1 ? true : false ;

                

                // Gán giá trị từ các cột vào các TextBox
                txtMa.Text = column1Value;
                txtTen.Text = column2Value;
                txtGiaPhong.Text = column3Value;
                txtMoTa.Text = column5Value;
                ComboBoxLoaiPhongEnum.SelectedItem = column4Value;
                //  txtSoLuong.Text = column3Value;

                // Tương tự cho các TextBox khác nếu cần
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
