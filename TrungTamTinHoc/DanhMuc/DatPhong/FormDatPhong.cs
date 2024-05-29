using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.HoaDon;
using TrungTamTinHoc.DanhMuc.Phong;
using Label = System.Windows.Forms.Label;

namespace TrungTamTinHoc.DanhMuc.DatPhong
{
    public partial class FormDatPhong : Form
    {
        private readonly SqlCommandPhong _phongCommand;
        private readonly FormHoaDon FormHoaDon;

        public List<PhongViewModel> phongViewModels = new List<PhongViewModel>();
        public FormDatPhong()
        {
            this._phongCommand = new SqlCommandPhong();
            this.FormHoaDon = new FormHoaDon();


            phongViewModels = _phongCommand.getPhongList("Phong");

            InitializeComponent();
            foreach (PhongViewModel room in phongViewModels)
            {
                // Tạo một UserControl tùy chỉnh để hiển thị thông tin phòng
                RoomControl roomControl = new RoomControl(room);
                if (room.TrangThai == 0)
                {
                    roomControl.BackColor = Color.Green;
                }
                else
                {
                    roomControl.BackColor = Color.Red;
                }
                roomControl.RoomClicked += RoomControl_RoomClicked;
                roomControl.Size = new Size(130, 100);
                flowLayoutPanel1.Controls.Add(roomControl);
                // Thêm UserControl vào ListBox
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Sắp xếp từ trên xuống
                flowLayoutPanel1.WrapContents = true; // Cho phép ngắt dòng khi cần
                flowLayoutPanel1.AutoScroll = true; // Hiển thị thanh cuộn nếu cần
            }
        }

        private void RoomControl_RoomClicked(object sender, EventArgs e)
        {
            // Ép kiểu sender thành RoomControl để truy cập thông tin phòng
            RoomControl clickedRoom = (RoomControl)sender;

            // Bây giờ bạn có thể truy cập thông tin phòng từ clickedRoom và thực hiện các hành động tùy ý
            string roomName = clickedRoom.room.Ten;

            this.Hide();

            // Tạo form mới

            // Truyền dữ liệu từ form chính (Form1) sang form mới (Form2)
            FormHoaDon.SetData(clickedRoom.room);

            // Mở form mới
            FormHoaDon.Show();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void danhMucVatTuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }



    // Gán danh sách vào ListBox

    public class RoomControl : UserControl
    {
        public PhongViewModel room;
        public event EventHandler RoomClicked;

        protected virtual void OnRoomClicked(EventArgs e)
        {
            RoomClicked?.Invoke(this, e);
        }

        public RoomControl(PhongViewModel room)
        {
            this.room = room;
            InitializeUI();
            this.Click += RoomControl_Click;
        }
        private void InitializeUI()
        {
            // Tạo và cấ hình các thành phần giao diện
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
            {
                Size = new Size(110, 80), // Giảm chiều cao của Panel
                Location = new Point(10, 10),
                BackgroundImageLayout = ImageLayout.Stretch, // Sử dụng ImageLayout.Stretch để căn chỉnh hình ảnh nền
                BackgroundImage = room.HinhAnh
            };
            Label label = new Label
            {
                Text = room.Ten,
                Location = new Point(30, 60), // Điều chỉnh vị trí dựa trên chiều cao mới của Panel
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 9, FontStyle.Bold), // Đặt kích thước và kiểu font
            };

            // Thêm Label vào Panel, không cần thêm Panel vào Controls vì Panel đã là Controls
            panel.Controls.Add(label);
            panel.Click += RoomControl_Click;
            // Thêm Panel vào Controls của Form hoặc Container
            this.Controls.Add(panel);

            // Đặt màu nền của Form hoặc Container thành màu nền của room
            this.BackColor = room.MauSac;
        }

        private void RoomControl_Click(object sender, EventArgs e)
        {
            // Khi UserControl được click, gọi sự kiện RoomClicked
            OnRoomClicked(e);
        }


    }

}
