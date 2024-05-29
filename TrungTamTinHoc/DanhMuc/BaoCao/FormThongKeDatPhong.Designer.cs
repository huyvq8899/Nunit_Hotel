namespace TrungTamTinHoc.DanhMuc.BaoCao
{
    partial class FormThongKeDatPhong
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
            this.button9 = new System.Windows.Forms.Button();
            this.myButton = new System.Windows.Forms.Button();
            this.checkBoxTrangThai = new System.Windows.Forms.CheckBox();
            this.dgphong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayDen = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxLoaiPhongEnum = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSoLuongKhach = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textTongDoanhThu = new System.Windows.Forms.NumericUpDown();
            this.qlTrungTamTinHocDataSet1 = new TrungTamTinHoc.QLTrungTamTinHocDataSet();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoLuongKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTongDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlTrungTamTinHocDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(261, 202);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 28);
            this.button9.TabIndex = 4;
            this.button9.Text = "Thoát";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(137, 202);
            this.myButton.Margin = new System.Windows.Forms.Padding(4);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(116, 28);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "Lấy dữ liệu";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.LoadBaoCaoThongKe);
            // 
            // checkBoxTrangThai
            // 
            this.checkBoxTrangThai.AutoSize = true;
            this.checkBoxTrangThai.Location = new System.Drawing.Point(148, 152);
            this.checkBoxTrangThai.Name = "checkBoxTrangThai";
            this.checkBoxTrangThai.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTrangThai.TabIndex = 7;
            this.checkBoxTrangThai.UseVisualStyleBackColor = true;
            // 
            // dgphong
            // 
            this.dgphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgphong.Location = new System.Drawing.Point(60, 365);
            this.dgphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgphong.Name = "dgphong";
            this.dgphong.RowHeadersWidth = 51;
            this.dgphong.Size = new System.Drawing.Size(293, 225);
            this.dgphong.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Báo cáo thống kê";
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.Location = new System.Drawing.Point(148, 109);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(234, 22);
            this.dateTimeNgayDi.TabIndex = 12;
            // 
            // dateTimeNgayDen
            // 
            this.dateTimeNgayDen.Location = new System.Drawing.Point(148, 67);
            this.dateTimeNgayDen.Name = "dateTimeNgayDen";
            this.dateTimeNgayDen.Size = new System.Drawing.Size(234, 22);
            this.dateTimeNgayDen.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myButton);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.dateTimeNgayDi);
            this.groupBox1.Controls.Add(this.checkBoxTrangThai);
            this.groupBox1.Controls.Add(this.dateTimeNgayDen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBoxLoaiPhongEnum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(60, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(434, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // ComboBoxLoaiPhongEnum
            // 
            this.ComboBoxLoaiPhongEnum.FormattingEnabled = true;
            this.ComboBoxLoaiPhongEnum.Location = new System.Drawing.Point(148, 15);
            this.ComboBoxLoaiPhongEnum.Name = "ComboBoxLoaiPhongEnum";
            this.ComboBoxLoaiPhongEnum.Size = new System.Drawing.Size(234, 24);
            this.ComboBoxLoaiPhongEnum.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Giờ trả phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn phòng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giờ nhận phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng số lượng phòng";
            // 
            // txtTongSoLuongKhach
            // 
            this.txtTongSoLuongKhach.Location = new System.Drawing.Point(708, 163);
            this.txtTongSoLuongKhach.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.txtTongSoLuongKhach.Name = "txtTongSoLuongKhach";
            this.txtTongSoLuongKhach.Size = new System.Drawing.Size(234, 22);
            this.txtTongSoLuongKhach.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng doanh thu";
            // 
            // textTongDoanhThu
            // 
            this.textTongDoanhThu.Location = new System.Drawing.Point(708, 202);
            this.textTongDoanhThu.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.textTongDoanhThu.Name = "textTongDoanhThu";
            this.textTongDoanhThu.Size = new System.Drawing.Size(234, 22);
            this.textTongDoanhThu.TabIndex = 11;
            // 
            // qlTrungTamTinHocDataSet1
            // 
            this.qlTrungTamTinHocDataSet1.DataSetName = "QLTrungTamTinHocDataSet";
            this.qlTrungTamTinHocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(360, 365);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1028, 360);
            this.crystalReportViewer1.TabIndex = 19;
            // 
            // FormThongKeDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 751);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dgphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textTongDoanhThu);
            this.Controls.Add(this.txtTongSoLuongKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormThongKeDatPhong";
            this.Text = "FormThongKeDatPhong";
            this.Load += new System.EventHandler(this.LoadBaoCaoThongKe);
            ((System.ComponentModel.ISupportInitialize)(this.dgphong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoLuongKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTongDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlTrungTamTinHocDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.CheckBox checkBoxTrangThai;
        private System.Windows.Forms.DataGridView dgphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxLoaiPhongEnum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTongSoLuongKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textTongDoanhThu;
        private QLTrungTamTinHocDataSet qlTrungTamTinHocDataSet1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}