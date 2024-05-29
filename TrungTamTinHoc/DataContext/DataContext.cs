using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TrungTamTinHoc.DataContext
{
    public class DataContext
    {
        public SqlConnection con = new SqlConnection();
        public DataContext()
        {

            con.ConnectionString = "Data Source=DESKTOP-LT17KAQ\\THANGNGUYEN;Initial Catalog=Hotel;Persist Security Info=True;User ID=sa;Password=123456@a";
        }
    }
}
