using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.VatTu
{
    public class SqlCommandVatTu
    {

        TrungTamTinHoc.DataContext.DataContext obj = new TrungTamTinHoc.DataContext.DataContext();


        public bool LuuVatTu(string Ma, string Ten, string SoLuong)
        {
            string sql = "INSERT into VatTu(Ma,Ten,SoLuong) values(N'" + Ma + "',N'" + Ten + "',N'" + SoLuong + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }

        public bool kiemtatrungkhoaphong(string MaPhong)
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
            string sql = "select * from phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool SuaVatTu(string Ma, string Ten, string SoLuong)
        {
            string sql = "update VatTu set Ten=N'" + Ten + "',SoLuong=N'" + SoLuong + "' where Ma=N'" + Ma + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
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
            sql = "SELECT * FROM " + tableName;
            cmd.Connection = obj.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //***DO DU LIEU VAO DANH SACH***//
            da.Fill(ds, tableName);
            //****TRA VE DANH SACH SAU KHI DA CO DU LIEU****//
            return ds;
        }

    }
}
