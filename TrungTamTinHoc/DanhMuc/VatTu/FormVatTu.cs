using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.VatTu;

namespace TrungTamTinHoc
{
    public partial class FormVatTu : Form
    {
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        SqlCommandVatTu obj = new SqlCommandVatTu();
        int vitri = 0;
        DataTable mtblgv = new DataTable();
        //======//

        void clearall()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSoLuong.Clear();
            txtMa.Focus();

        }
        //====//
        private void GanDuLieuTuRowVaoText(DataTable tbl, int vitri)
        {
            DataRow drw;
            if(tbl.Rows.Count > 0) {
                drw = tbl.Rows[vitri];
                if (drw != null)
                {
                    txtMa.Text = drw["Ma"].ToString();
                    txtTen.Text = drw["Ten"].ToString();
                    txtSoLuong.Text = drw["SoLuong"].ToString();
                }
            }



        }
        public bool kiemtradulieuphong()
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (obj.kiemtatrungkhoaphong(txtMa.Text))
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
                    string mp, ten, dd;
                    mp = txtMa.Text;
                    ten = txtTen.Text;
                    dd = txtSoLuong.Text;


                    kt = obj.LuuVatTu(mp, ten, dd);
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
                string mp, ten, dd;
                mp = txtMa.Text;
                ten = txtTen.Text;
                dd = txtSoLuong.Text;
                kt = obj.SuaVatTu(mp, ten, dd);
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

        private void FromVatTuLoad(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            mtblgv = obj.getDataTable("VatTu");
            GanDuLieuTuRowVaoText(mtblgv, vitri);
            DataSet ds = new DataSet();
            ds = obj.getDataSet("VatTu");
            dgphong.DataSource = ds.Tables[0];
            btluu.Enabled = false;
            clearall();
        }

        private void YourSelectionChangedEventHandler(object sender, EventArgs e)
        {
            if (dgphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgphong.SelectedRows[0];

                // Lấy dữ liệu từ các cột của dòng đã chọn
                string column1Value = selectedRow.Cells["Ma"].Value.ToString();
                string column2Value = selectedRow.Cells["Ten"].Value.ToString();
                string column3Value = selectedRow.Cells["SoLuong"].Value.ToString();

                // Gán giá trị từ các cột vào các TextBox
                txtMa.Text = column1Value;
                txtTen.Text = column2Value;
                txtSoLuong.Text = column3Value;

                // Tương tự cho các TextBox khác nếu cần
            }
        }
    }
}
