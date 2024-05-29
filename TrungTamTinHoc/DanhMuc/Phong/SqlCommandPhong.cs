using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using TrungTamTinHoc.DanhMuc.DatPhong;

namespace TrungTamTinHoc.DanhMuc.Phong
{
    public class SqlCommandPhong
    {

        private readonly TrungTamTinHoc.DataContext.DataContext obj;

        public SqlCommandPhong()
        {
            this.obj = new TrungTamTinHoc.DataContext.DataContext();
        }


        public bool LuuPhong(string Ma, string Ten,string LoaiPhong, string moTa, decimal giaPhong, bool trangThai)
        {
            string sql = "INSERT INTO Phong (Ma, Ten,LoaiPhong, GiaPhong, MoTa, TrangThai) VALUES (@Ma, @Ten,@LoaiPhong, @GiaPhong, @MoTa, @TrangThai)";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@Ma", Ma);
                cmd.Parameters.AddWithValue("@Ten", Ten); // Đảm bảo Ten là chuỗi Unicode
                cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong); // Đảm bảo Ten là chuỗi Unicode
                cmd.Parameters.AddWithValue("@GiaPhong", giaPhong);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai); // Cần đảm bảo có biến trangThai
                obj.con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                obj.con.Close();
                return rowsAffected > 0; // Trả về true nếu có dòng dữ liệu bị ảnh hưởng
            }

        }

        public bool KiemTraTrungMa(string MaPhong)
        {
            string sql = "select * from VatTu where Ma='" + MaPhong + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }

        public DataSet phong()
        {
            string sql = "select * from Phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool SuaVatTu(string Ma, string Ten,string LoaiPhong, string moTa, decimal giaPhong, bool trangThai)
        {
            string sql = "UPDATE Phong SET Ten = @Ten,LoaiPhong = @LoaiPhong, GiaPhong = @GiaPhong, MoTa = @MoTa, TrangThai = @TrangThai WHERE Ma = @Ma";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong); // Đảm bảo Ten là chuỗi Unicode// Đảm bảo Ten là chuỗi Unicode
                cmd.Parameters.AddWithValue("@GiaPhong", giaPhong);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai); // Cần đảm bảo có biến trangThai
                cmd.Parameters.AddWithValue("@Ma", Ma);
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

        public DataSet getDataSet(string tableName)
        {
            string sql;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            sql = "SELECT Ma, Ten, LoaiPhong, GiaPhong, MoTa, TrangThai FROM " + tableName;
            cmd.Connection = obj.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //***DO DU LIEU VAO DANH SACH***//
            da.Fill(ds, tableName);
            //****TRA VE DANH SACH SAU KHI DA CO DU LIEU****//
            return ds;
        }


        public List<PhongViewModel> getPhongList(string tableName)
        {
            string sql;
            SqlCommand cmd = new SqlCommand();
            List<PhongViewModel> danhSachPhong = new List<PhongViewModel>();

            sql = "SELECT Ma, Ten, LoaiPhong, GiaPhong, MoTa, TrangThai, HoaDonId FROM " + tableName;
            cmd.Connection = obj.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            obj.con.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    PhongViewModel phong = new PhongViewModel
                    {
                        Ma = reader["Ma"].ToString(),
                        Ten = reader["Ten"].ToString(),
                        LoaiPhong = reader["LoaiPhong"].ToString(),
                        GiaPhong = Convert.ToDecimal(reader["GiaPhong"]),
                        MoTa = reader["MoTa"].ToString(),
                        TrangThai = Convert.ToInt16(reader["TrangThai"].ToString()),
                        HinhAnh = System.Drawing.Image.FromFile("D:\\Project-PMBK\\OS\\Small_hotel\\TrungTamTinHoc\\TrungTamTinHoc\\Images\\home.png"),
                        HoaDonId = reader["HoaDonId"].ToString(),
                    };

                    danhSachPhong.Add(phong);
                }
            }
            obj.con.Close();

            return danhSachPhong;
        }

        public bool CapNhatTrangThaiPhong(string Ten, int trangThaiMoi, string HoaDonId = "")
        {
            string sql = "UPDATE Phong SET TrangThai = @TrangThai, HoaDonId = @HoaDonId WHERE Ten = @Ten";
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@HoaDonId", HoaDonId);
                obj.con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                obj.con.Close();
                return rowsAffected > 0; // Trả về true nếu có dòng dữ liệu bị ảnh hưởng
            }
        }



    }
}
