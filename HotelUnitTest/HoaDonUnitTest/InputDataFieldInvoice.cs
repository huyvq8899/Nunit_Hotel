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
    public class InputDataFieldInvoice
    {
        [TestFixture]
        [Ignore("Skip test for other test")]
        public class InputDataFieldInvoices
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
            /// Test case và test method - các dữ liệu test và kết quả mong muốn được trả về
            /// </summary>
            /// <returns></returns>
            [Test]
            [TestCase("TestMaDon1", ExpectedResult = true)]
            [TestCase("NonExistentMaDon", ExpectedResult = false)]
            [TestCase("", ExpectedResult = true)]
            [TestCase(null, ExpectedResult = false)]
            public bool KiemTraTrungMa_TestCases(string maDon)
            {
                // Act
                bool result = _sqlCommandHoaDon.KiemTraTrungMa(maDon);

                // Assert
                return result;
            }

        }

    }
}
