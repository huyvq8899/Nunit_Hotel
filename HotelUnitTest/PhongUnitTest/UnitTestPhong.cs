using NUnit.Framework;
using System;
using Moq;
using System.Data.SqlClient;
using TrungTamTinHoc.DanhMuc.Phong;

namespace TrungTamTinHocUnitTest
{
    public class UnitTestPhong
    {
        [TestFixture]
        [Ignore("Skipping tests in this class.")]
        public class SqlCommandPhongTests
        {
            private Mock<TrungTamTinHoc.DataContext.DataContext> mockDataContext;
            private SqlCommandPhong sqlCommandPhong;
            /// <summary>
            /// Phương thức setup là phương thức sẽ chạy đầu tiên trc khi khởi tạo các test case - để thiết lập môi trường
            /// </summary>
            [SetUp]
            public void Setup()
            {
                // Sử dụng mock cho DataContext
                mockDataContext = new Mock<TrungTamTinHoc.DataContext.DataContext>();
                sqlCommandPhong = new SqlCommandPhong();
            }

            /// <summary>
            /// Test case và test method - các dữ liệu test và kết quả mong muốn đc trả về
            /// </summary>
            /// <returns></returns>
            [Test]
            [TestCase("PH001", "Phòng 1", "Loại A", "Mô tả phòng 1", 100000, true, ExpectedResult = true)]
            [TestCase("PH002", "Phòng 2", "Loại B", "Mô tả phòng 2", 150000, false, ExpectedResult = true)]
            public bool LuuPhong_InsertSuccessful_ReturnsTrue(
                string ma,
                string ten,
                string loaiPhong,
                string moTa,
                decimal giaPhong,
                bool trangThai)
            {
                // Act
                bool result = sqlCommandPhong.LuuPhong(ma, ten, loaiPhong, moTa, giaPhong, trangThai);

                // Assert
                return result;
            }

            /// <summary>
            ///  Các test case tương ứng 
            /// </summary>
            /// <returns></returns>
            [Test]
            [TestCase("", "Phòng 1", "Loại A", "Mô tả phòng 1", 100000, true, ExpectedResult = false, TestName = "LuuPhong_InsertFails_WhenMaIsEmpty")]
            [TestCase("PH003", "", "Loại B", "Mô tả phòng 3", 150000, false, ExpectedResult = false, TestName = "LuuPhong_InsertFails_WhenTenIsEmpty")]
            [TestCase("PH004", "Phòng 4", "", "Mô tả phòng 4", 200000, true, ExpectedResult = false, TestName = "LuuPhong_InsertFails_WhenLoaiPhongIsEmpty")]
            [TestCase("PH005", "Phòng 5", "Loại C", "Mô tả phòng 5", -50000, true, ExpectedResult = false, TestName = "LuuPhong_InsertFails_WhenGiaPhongIsNegative")]
            public bool LuuPhong_InsertFails_WithInvalidParameters(
                string ma,
                string ten,
                string loaiPhong,
                string moTa,
                decimal giaPhong,
                bool trangThai)
            {
                // Act
                bool result = sqlCommandPhong.LuuPhong(ma, ten, loaiPhong, moTa, giaPhong, trangThai);

                // Assert
                return result;
            }

            [TearDown]
            public void TearDown()
            {
                // Không cần gọi Dispose cho mock
            }

        }
    }
}
