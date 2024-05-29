using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.BaoCao
{
    public class SQLCommandBaoCao
    {
        TrungTamTinHoc.DataContext.DataContext obj = new TrungTamTinHoc.DataContext.DataContext();

        public BaoCaoViewModel BaoCaoDoanhThu(DateTime fromDate, DateTime toDate, string TenPhong)
        {
            string sql = @"
        SELECT
            COUNT(MaDon) AS SoLuongHoaDon,
            SUM(ThanhTien) AS TongTienHoaDon
        FROM [hotel].[dbo].[HoaDon]
        WHERE GioVao >= @FromDate AND GioVao <= @ToDate AND TenPhong = @TenPhong;
    ";

            int soLuongHoaDon = 0;
            decimal tongTienHoaDon = 0;

            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                cmd.Parameters.AddWithValue("@TenPhong", TenPhong);

                obj.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    soLuongHoaDon = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    tongTienHoaDon = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                }

                BaoCaoViewModel viewModel = new BaoCaoViewModel
                {
                    SoLuongHoaDon = soLuongHoaDon,
                    TongTienHoaDon = tongTienHoaDon
                };

                obj.con.Close();

                return viewModel;
            }
        }


    }
}
