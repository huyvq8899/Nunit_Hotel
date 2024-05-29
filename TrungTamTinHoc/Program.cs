using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrungTamTinHoc.DanhMuc.BaoCao;
using TrungTamTinHoc.DanhMuc.DatPhong;
using TrungTamTinHoc.DanhMuc.HoaDon;
using TrungTamTinHoc.DanhMuc.Phong;

namespace TrungTamTinHoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frlogin());
        }
    }
}