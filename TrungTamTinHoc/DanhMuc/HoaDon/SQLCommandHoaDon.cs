using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.HoaDon
{
    public class SQLCommandHoaDon
    {

        TrungTamTinHoc.DataContext.DataContext obj = new TrungTamTinHoc.DataContext.DataContext();

        public bool LuuHoaDon(HoaDonViewModel hoaDon)
        {
            /// Check valid dau vao truong nhap lieu
            if(string.IsNullOrEmpty(hoaDon.MaDon) || string.IsNullOrEmpty(hoaDon.TenKhach) || string.IsNullOrEmpty(hoaDon.DiaChiKhach) || string.IsNullOrEmpty(hoaDon.TenPhong))
            {
                return false;
            }

            /// Check valid dau vao lien quan den thoi gian vao va thoi gian tra phong
            
            if(hoaDon.GioVao >= hoaDon.GioRa)
            {
                return false;
            }

            if(hoaDon.GiaPhong <= 0 || hoaDon.ThanhTien <= 0)
            {
                return false;
            }
            string sql = "INSERT INTO HoaDon (MaDon, TenKhach, DiaChiKhach, CCCD, SoDienThoai, SoNguoi, GioVao, GioRa, GiaPhong, ThanhTien, TrangThai, TenPhong) VALUES (@MaDon, @TenKhach, @DiaChiKhach, @CCCD, @SoDienThoai, @SoNguoi, @GioVao, @GioRa, @GiaPhong, @ThanhTien, @TrangThai, @TenPhong)";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@MaDon", hoaDon.MaDon);
                cmd.Parameters.AddWithValue("@TenKhach", hoaDon.TenKhach);
                cmd.Parameters.AddWithValue("@DiaChiKhach", hoaDon.DiaChiKhach);
                cmd.Parameters.AddWithValue("@CCCD", hoaDon.CCCD);
                cmd.Parameters.AddWithValue("@SoDienThoai", hoaDon.SoDienThoai);
                cmd.Parameters.AddWithValue("@SoNguoi", hoaDon.SoNguoi);
                cmd.Parameters.AddWithValue("@GioVao", hoaDon.GioVao);
                cmd.Parameters.AddWithValue("@GioRa", hoaDon.GioRa);
                cmd.Parameters.AddWithValue("@GiaPhong", hoaDon.GiaPhong);
                cmd.Parameters.AddWithValue("@ThanhTien", hoaDon.ThanhTien);
                cmd.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai);
                cmd.Parameters.AddWithValue("@TenPhong", hoaDon.TenPhong);

                obj.con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                obj.con.Close();

                return rowsAffected > 0; // Trả về true nếu có dòng dữ liệu bị ảnh hưởng
            }

        }

        public bool KiemTraTrungMa(string MaDon)
        {   
            if (string.IsNullOrEmpty(MaDon))
            {
                return false;
            }
            string sql = "select * from HoaDon where MaDon='" + MaDon + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }

        public DataSet HoaDon()
        {
            string sql = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool SuaHoaDon(HoaDonViewModel hoaDon)
        {
            string sql = "UPDATE HoaDon SET MaDon = @MaDon, TenKhach = @TenKhach, DiaChiKhach = @DiaChiKhach, CCCD = @CCCD, SoDienThoai = @SoDienThoai, SoNguoi = @SoNguoi, GioVao = @GioVao, GioRa = @GioRa, GiaPhong = @GiaPhong, ThanhTien = @ThanhTien, TrangThai = @TrangThai WHERE MaDon = @MaDon";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@Id", hoaDon.Id); // Giả định rằng bạn có thuộc tính Id trong lớp HoaDon
                cmd.Parameters.AddWithValue("@MaDon", hoaDon.MaDon);
                cmd.Parameters.AddWithValue("@TenKhach", hoaDon.TenKhach);
                cmd.Parameters.AddWithValue("@DiaChiKhach", hoaDon.DiaChiKhach);
                cmd.Parameters.AddWithValue("@CCCD", hoaDon.CCCD);
                cmd.Parameters.AddWithValue("@SoDienThoai", hoaDon.SoDienThoai);
                cmd.Parameters.AddWithValue("@SoNguoi", hoaDon.SoNguoi);
                cmd.Parameters.AddWithValue("@GioVao", hoaDon.GioVao);
                cmd.Parameters.AddWithValue("@GioRa", hoaDon.GioRa);
                cmd.Parameters.AddWithValue("@GiaPhong", hoaDon.GiaPhong);
                cmd.Parameters.AddWithValue("@ThanhTien", hoaDon.ThanhTien);
                cmd.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai == true ? 1 : 0);

                obj.con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                obj.con.Close();

                return rowsAffected > 0; // Trả về true nếu có dòng dữ liệu bị ảnh hưởng
            }
        }

        public DataTable getDataTable(string tableName)
        {
            return getDataSet(tableName).Tables[tableName];
        }

        public DataTable getDataTableDatPhong(string tableName, string HoaDonId)
        {
            return getDataSetHoaDonDatPhong(tableName, HoaDonId).Tables[tableName];

        }

        public DataSet getDataSet(string tableName)
        {
            string sql = "SELECT Id, MaDon, TenKhach, DiaChiKhach, CCCD, SoDienThoai, SoNguoi, GioVao, GioRa, GiaPhong, ThanhTien, TrangThai, TenPhong FROM HoaDon";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                obj.con.Open();
                da.Fill(ds, "HoaDon");
                obj.con.Close();

                return ds;
            }

        }

        public DataSet getDataSetHoaDonDatPhong(string tableName, string HoaDonId)
        {
            string sql = "SELECT Id, MaDon, TenKhach, DiaChiKhach, CCCD, SoDienThoai, SoNguoi, GioVao, GioRa, GiaPhong, ThanhTien, TrangThai, TenPhong FROM HoaDon WHERE MaDon = @HoaDonId";



            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                // Thêm tham số HoaDonId
                cmd.Parameters.AddWithValue("@HoaDonId", HoaDonId);
                DataSet ds = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    obj.con.Open();
                    adapter.Fill(ds, "HoaDon");
                    obj.con.Close();
                }
                return ds;
            }
        }

    }

}
