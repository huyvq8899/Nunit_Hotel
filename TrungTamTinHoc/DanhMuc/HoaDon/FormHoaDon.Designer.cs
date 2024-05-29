namespace TrungTamTinHoc.DanhMuc.HoaDon
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxTrangThai = new System.Windows.Forms.CheckBox();
            this.ComboBoxLoaiPhongEnum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btnhapmoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtChiPhiPhu = new System.Windows.Forms.NumericUpDown();
            this.txtGiaPhong = new System.Windows.Forms.NumericUpDown();
            this.txtDiaChiKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgphong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiPhiPhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTrangThai
            // 
            this.checkBoxTrangThai.AutoSize = true;
            this.checkBoxTrangThai.Location = new System.Drawing.Point(547, 221);
            this.checkBoxTrangThai.Name = "checkBoxTrangThai";
            this.checkBoxTrangThai.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTrangThai.TabIndex = 7;
            this.checkBoxTrangThai.UseVisualStyleBackColor = true;
            // 
            // ComboBoxLoaiPhongEnum
            // 
            this.ComboBoxLoaiPhongEnum.FormattingEnabled = true;
            this.ComboBoxLoaiPhongEnum.Location = new System.Drawing.Point(547, 21);
            this.ComboBoxLoaiPhongEnum.Name = "ComboBoxLoaiPhongEnum";
            this.ComboBoxLoaiPhongEnum.Size = new System.Drawing.Size(234, 24);
            this.ComboBoxLoaiPhongEnum.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn phòng";
           
            // 
            // btnhapmoi
            // 
            this.btnhapmoi.Location = new System.Drawing.Point(8, 10);
            this.btnhapmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnhapmoi.Name = "btnhapmoi";
            this.btnhapmoi.Size = new System.Drawing.Size(88, 28);
            this.btnhapmoi.TabIndex = 0;
            this.btnhapmoi.Text = "Đặt phòng";
            this.btnhapmoi.UseVisualStyleBackColor = true;
            this.btnhapmoi.Click += new System.EventHandler(this.btluu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeNgayDi);
            this.groupBox1.Controls.Add(this.checkBoxTrangThai);
            this.groupBox1.Controls.Add(this.dateTimeNgayDen);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtChiPhiPhu);
            this.groupBox1.Controls.Add(this.txtGiaPhong);
            this.groupBox1.Controls.Add(this.ComboBoxLoaiPhongEnum);
            this.groupBox1.Controls.Add(this.txtDiaChiKhachHang);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(914, 251);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.Location = new System.Drawing.Point(547, 148);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(234, 22);
            this.dateTimeNgayDi.TabIndex = 12;
            // 
            // dateTimeNgayDen
            // 
            this.dateTimeNgayDen.Location = new System.Drawing.Point(547, 106);
            this.dateTimeNgayDen.Name = "dateTimeNgayDen";
            this.dateTimeNgayDen.Size = new System.Drawing.Size(234, 22);
            this.dateTimeNgayDen.TabIndex = 12;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(143, 192);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(189, 22);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(143, 150);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(189, 22);
            this.txtCCCD.TabIndex = 4;
            // 
            // txtChiPhiPhu
            // 
            this.txtChiPhiPhu.Location = new System.Drawing.Point(547, 186);
            this.txtChiPhiPhu.Name = "txtChiPhiPhu";
            this.txtChiPhiPhu.Size = new System.Drawing.Size(234, 22);
            this.txtChiPhiPhu.TabIndex = 11;
            this.txtChiPhiPhu.ValueChanged += new System.EventHandler(this.txtGiaPhong_ValueChanged);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(547, 66);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(234, 22);
            this.txtGiaPhong.TabIndex = 11;
            this.txtGiaPhong.ValueChanged += new System.EventHandler(this.txtGiaPhong_ValueChanged);
            // 
            // txtDiaChiKhachHang
            // 
            this.txtDiaChiKhachHang.Location = new System.Drawing.Point(143, 111);
            this.txtDiaChiKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            this.txtDiaChiKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtDiaChiKhachHang.TabIndex = 4;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(143, 68);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(189, 22);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(426, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Giờ trả phòng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(426, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Chi phí phụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giờ nhận phòng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "CDDD";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(143, 23);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtMaHoaDon.TabIndex = 3;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Địa chỉ khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // dgphong
            // 
            this.dgphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgphong.Location = new System.Drawing.Point(33, 377);
            this.dgphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgphong.Name = "dgphong";
            this.dgphong.RowHeadersWidth = 51;
            this.dgphong.Size = new System.Drawing.Size(898, 200);
            this.dgphong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.btnhapmoi);
            this.groupBox4.Location = new System.Drawing.Point(33, 324);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(227, 45);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 582);
            this.Controls.Add(this.dgphong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.FromHoaDonLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChiPhiPhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTrangThai;
        private System.Windows.Forms.ComboBox ComboBoxLoaiPhongEnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnhapmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtGiaPhong;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChiKhachHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtChiPhiPhu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDen;
    }
}