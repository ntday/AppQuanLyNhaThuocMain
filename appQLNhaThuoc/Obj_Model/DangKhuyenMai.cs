using quanLyNhaThuoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appQLNhaThuoc.Obj_Model
{
    class DangKhuyenMai
    {
        DatabaseObj db;

        public DangKhuyenMai()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachDangKM()
        {
            string strSQL = "SELECT * FROM DangKhuyenMai";
            return db.Execute(strSQL);
        }

        public void themDangKM(string tenDangKM, string giamGia, string quaTang)
        {
            string tendang = tenDangKM, giamgia = giamGia, quatang = quaTang;
            string strSQL = string.Format(" INSERT INTO DangKhuyenMai(tenDangKM, giamGia, quaTang) VALUES (N'{0}', {1}, N'{2}')",tendang,giamgia,quatang);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaDangKM(string tenDangKM, string giamGia, string quaTang, string maDangC)
        {
            string tendang = tenDangKM, giamgia = giamGia, quatang = quaTang, masua = maDangC;
            string strSQL = string.Format("UPDATE DangKhuyenMai SET tenDangKM =N'{0}',giamGia={1},quaTang=N'{2}' WHERE maDangKM  = '{3}'", tendang,giamgia,quatang, masua);
            db.ExecuteNonQuery(strSQL);
        }
        public void xoaDangKM(string maDangC)
        {
            string  maXoa = maDangC;
            string strSQL = string.Format("  DELETE FROM DangKhuyenMai WHERE maDangKM  = '{0}'",maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
