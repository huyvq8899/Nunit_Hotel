using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DanhMuc.HoaDon;
using TrungTamTinHoc.DataContext;

namespace HotelUnitTest.HoaDonUnitTest
{
    public class SaveInforInvoice_UnitTest
    {

        [TestFixture]

        public class SaveInvoiceUnitTest
        {

            private DataContext _context;
            private SQLCommandHoaDon _sqlCommandHoaDon;

            private string _connectionString = "YourTestDatabaseConnectionString";

            [SetUp]
            public void Setup()
            {
                // Initialize the database connection
                _connectionString = "Data Source=DESKTOP-LT17KAQ\\THANGNGUYEN;Initial Catalog=Hotel;Persist Security Info=True;User ID=sa;Password=123456@a";
                _sqlCommandHoaDon = new SQLCommandHoaDon();
            }

            /// <summary>
            ///  Test case save thong tin hoa don voi cac gia tri dau vao k hop le hoac trong
            /// <returns></returns>
            [Test]
            [TestCase("HD001", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = true, TestName = "LuuHoaDon_InsertSuccessful_ReturnsTrue")]
            [TestCase("", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenMaDonIsEmpty")]
            [TestCase("HD002", "", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenTenKhachIsEmpty")]
            [TestCase("HD003", "John Doe", "", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenDiaChiKhachIsEmpty")]
            [TestCase("HD004", "John Doe", "123 Main St", "", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenCCCDIsEmpty")]
            [TestCase("HD005", "John Doe", "123 Main St", "123456789", "", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenSoDienThoaiIsEmpty")]
            [TestCase("HD006", "John Doe", "123 Main St", "123456789", "123456789", 0, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenSoNguoiIsZero")]
            [TestCase("HD007", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGioVaoIsNull")]
            [TestCase("HD008", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGioRaIsNull")]
            [TestCase("HD009", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGiaPhongIsNegative")]
            [TestCase("HD010", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenThanhTienIsNegative")]
            [TestCase("HD011", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenTrangThaiIsNull")]
            [TestCase("HD012", "John Doe", "123 Main St", "123456789", "123456789", 2, ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenTenPhongIsEmpty")]
            public bool LuuHoaDon_InsertFails_ForInvalidInput(
            string maDon, string tenKhach, string diaChiKhach,
            string cccd, string soDienThoai, int soNguoi)
            {
                // Arrange
                HoaDonViewModel hoaDon = new HoaDonViewModel
                {
                    MaDon = maDon,
                    TenKhach = tenKhach,
                    DiaChiKhach = diaChiKhach,
                    CCCD = cccd,
                    SoDienThoai = soDienThoai,
                    SoNguoi = soNguoi,
                    GioVao = DateTime.Now,
                    GioRa = DateTime.Now.AddHours(2),
                    GiaPhong = 100000,
                    ThanhTien = 200000,
                    TrangThai = true,
                    TenPhong = "Phòng 1"
                };

                // Act
                bool result = _sqlCommandHoaDon.LuuHoaDon(hoaDon);

                // Assert
                return result;
            }

            /// <summary>
            ///  Test case lien quan den check logic nhu la gio phong den va gio tra phong 
            /// </summary>
            /// <returns></returns>

            [Test]
            [TestCase("HD001", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", 100000, 200000, true, "Phòng 1", ExpectedResult = true, TestName = "LuuHoaDon_InsertSuccessful_ReturnsTrue")]
            [TestCase("HD013", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T12:00:00", "2024-05-20T10:00:00", 100000, 200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGioRaBeforeGioVao")]
            [TestCase("HD014", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T10:00:00", 100000, 200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGioRaEqualsGioVao")]
            [TestCase("HD015", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T09:59:59", 100000, 200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGioRaBeforeGioVaoBoundary")]
            [TestCase("HD016", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T11:59:59", 100000, 200000, true, "Phòng 1", ExpectedResult = true, TestName = "LuuHoaDon_InsertSuccessful_WhenGioRaAfterGioVaoBoundary")]
            public bool LuuHoaDon_InsertFails_ForInvalidInput(
                  string maDon, string tenKhach, string diaChiKhach,
                  string cccd, string soDienThoai, int soNguoi,
                  string gioVao, string gioRa, decimal giaPhong,
                  decimal thanhTien, bool trangThai, string tenPhong)
            {
                // Arrange
                HoaDonViewModel hoaDon = new HoaDonViewModel
                {
                    MaDon = maDon,
                    TenKhach = tenKhach,
                    DiaChiKhach = diaChiKhach,
                    CCCD = cccd,
                    SoDienThoai = soDienThoai,
                    SoNguoi = soNguoi,
                    GioVao = DateTime.Parse(gioVao),
                    GioRa = DateTime.Parse(gioRa),
                    GiaPhong = giaPhong,
                    ThanhTien = thanhTien,
                    TrangThai = trangThai,
                    TenPhong = tenPhong
                };

                // Act
                bool result = _sqlCommandHoaDon.LuuHoaDon(hoaDon);

                // Assert
                return result;
            }

            /// <summary>
            /// Cac testCase lien quan den thanh tien thanh toan cua hoa don
            /// </summary>
            /// <returns></returns>

            [Test]
            [TestCase("HD001", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", 100000, 200000, true, "Phòng 1", ExpectedResult = true, TestName = "LuuHoaDon_InsertSuccessful_ReturnsTrue")]
            [TestCase("HD017", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", -1000, 200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGiaPhongIsNegative")]
            [TestCase("HD018", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", 0, 200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenGiaPhongIsZero")]
            [TestCase("HD019", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", 100000, -200000, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenThanhTienIsNegative")]
            [TestCase("HD020", "John Doe", "123 Main St", "123456789", "123456789", 2, "2024-05-20T10:00:00", "2024-05-20T12:00:00", 100000, 0, true, "Phòng 1", ExpectedResult = false, TestName = "LuuHoaDon_InsertFails_WhenThanhTienIsZero")]
            public bool LuuHoaDon_InsertFails_ForInvalidInputMoney(
              string maDon, string tenKhach, string diaChiKhach,
              string cccd, string soDienThoai, int soNguoi,
              string gioVao, string gioRa, decimal giaPhong,
              decimal thanhTien, bool trangThai, string tenPhong)
            {
                // Arrange
                HoaDonViewModel hoaDon = new HoaDonViewModel
                {
                    MaDon = maDon,
                    TenKhach = tenKhach,
                    DiaChiKhach = diaChiKhach,
                    CCCD = cccd,
                    SoDienThoai = soDienThoai,
                    SoNguoi = soNguoi,
                    GioVao = DateTime.Parse(gioVao),
                    GioRa = DateTime.Parse(gioRa),
                    GiaPhong = giaPhong,
                    ThanhTien = thanhTien,
                    TrangThai = trangThai,
                    TenPhong = tenPhong
                };

                // Act
                bool result = _sqlCommandHoaDon.LuuHoaDon(hoaDon);

                // Assert
                return result;
            }
        }
    }
}
