
using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class DangThanhToan
    {
        DatabaseObj db;
        public DangThanhToan()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachDangThanhToan()
        {
            string strSQL = " SELECT * FROM dangThanhToan";
            return db.Execute(strSQL);
        }

        public void themDangThanhToanMoi(string tenDangTT, string tenNganHang, string soTaiKhoang)
        {
            string ten = tenDangTT, tenNH = tenNganHang, stk = soTaiKhoang;
            string strSQL = string.Format(" INSERT INTO dangThanhToan(tenDangTT,tenNganHang,soTaiKhoang) VALUES (N'{0}', N'{1}','{2}')", ten, tenNH, stk);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaDangThanhToan(string tenDangTT, string tenNganHang, string soTaiKhoang, string maDangTT)
        {
            string ten = tenDangTT, tenNH = tenNganHang, stk = soTaiKhoang, masua = maDangTT;
            string strSQL = string.Format("UPDATE dangThanhToan SET tenDangTT = N'{0}',tenNganHang = N'{1}', soTaiKhoang ='{2}' WHERE maDangTT  = '{3}'", ten, tenNH, stk, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaDangThanhToan(string maDangTT)
        {
            string maXoa = maDangTT;
            string strSQL = string.Format("DELETE FROM dangThanhToan WHERE maDangTT  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }

        public string layMaDangThanhToanTheoTen(string tenDangTT)
        {
           string TenDangTToa = tenDangTT;
            string strSQL = string.Format("SELECT soMaDangTT  FROM dangThanhToan WHERE tenDangTT = N'{0}'", TenDangTToa);
             return db.Execute(strSQL).Rows[0]["soMaDangTT"].ToString();
        }
    }
}
