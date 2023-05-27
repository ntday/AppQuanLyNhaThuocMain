using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyNhaThuoc;
using System.Data;
namespace appQLNhaThuoc.Obj_Model
{
    class HangDuocPham
    {
        DatabaseObj db;
        public HangDuocPham()
        {
            db = new DatabaseObj();
        }
        public DataTable layDanhSachHangDuoc()
        {
            string strSQL = "SELECT * FROM hangDuocPham";
            return db.Execute(strSQL);
        }
        public void themHangDuoc(string maHD, string tenHD, string sdtHD, string emailHD, string diaChiHD)
        {
            string MaHD = maHD, TenHD = tenHD, SdtHD = sdtHD, EmailHD = emailHD, DiaChiHD = diaChiHD;
            string strSQl = string.Format("INSERT INTO hangDuocPham(maHangDuoc, tenHangDuoc, sdtHangDuoc, emailHangDuoc, diaChiHangDuoc) VALUES ('{0}',N'{1}', '{2}','{3}','{4}' )", MaHD, TenHD, SdtHD, EmailHD, DiaChiHD);
            db.ExecuteNonQuery(strSQl);
        }
        public void suaHangDuoc(string maHD, string tenHD, string sdtHD, string emailHD, string diaChiHD, string maHDC)
        {
            string MaHD = maHD, TenHD = tenHD, SdtHD = sdtHD, EmailHD = emailHD, DiaChiHD = diaChiHD, maSua = maHDC;
            string strSQL = string.Format("UPDATE hangDuocPham SET maHangDuoc ='{0}', tenHangDuoc = N'{1}', sdtHangDuoc = '{2}', emailHangDuoc = '{3}', diaChiHangDuoc = '{4}' WHERE maHangDuoc = '{5}'", MaHD, TenHD, SdtHD, EmailHD, DiaChiHD, maSua);
            db.ExecuteNonQuery(strSQL);
        }
        public void xoaHangDuoc(string maHangDuoc)
        {
            string maXoa = maHangDuoc;
            string strSQL = string.Format("DELETE FROM hangDuocPham WHERE maHangDuoc = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);

        }

    }
}
