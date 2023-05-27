using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class User
    {
        DatabaseObj db;

        public User()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachUserTheoTen(string ten)
        {
            string strSQL = string.Format("SELECT * FROM nhanVien WHERE tenDN = '{0}'", ten);
            return db.Execute(strSQL);
        }


        public string layTenNV(string tenDN)
        {
            string strSQL = string.Format("SELECT hoVaTen FROM nhanVien WHERE tenDN = '{0}'", tenDN);
            DataTable tableNV = db.Execute(strSQL);
            return tableNV.Rows[0]["hoVaTen"].ToString();
        }

        public string layMaNhanhVienTheoTen(string tenDN)
        {
            string strSQL = string.Format("SELECT maNV FROM nhanVien WHERE tenDN = '{0}'", tenDN);
            DataTable tableNV = db.Execute(strSQL);
            return tableNV.Rows[0]["maNV"].ToString();
        }

        public string layQuyenHangUserTheoTenDN(string tenDN)
        {
            string strSQL = string.Format(" SELECT tenQH FROM nhanVien LEFT JOIN quyenHan ON nhanVien.soMaQH = quyenHan.soMaQH WHERE tenDN = '{0}'", tenDN);
            DataTable tableQuen = db.Execute(strSQL);
            if (tableQuen.Rows[0]["tenQH"].ToString() is null || tableQuen.Rows[0]["tenQH"].ToString().Length <= 0) return "admin";
            return tableQuen.Rows[0]["tenQH"].ToString();
        }

        public string laySoQuyenHangUserTheoTenDN(string maNV)
        {
            string strSQL = string.Format(" SELECT nhanVien.soMaQH FROM nhanVien LEFT JOIN quyenHan ON nhanVien.soMaQH = quyenHan.soMaQH WHERE maNV = '{0}'", maNV);
            DataTable tableQuen = db.Execute(strSQL);
            return tableQuen.Rows[0]["soMaQH"].ToString();
        }


        public void doiThongTinUserCoMatKhau(string tenDN, string hoVaTen, string matKhau, string tenDNCu)
        {
            string tendn = tenDN, hovaten = hoVaTen, matkhau = matKhau, maSua = tenDNCu;
            string strSQL = string.Format("UPDATE nhanVien SET tenDN ='{0}', hoVaTen =N'{1}', matKhau ='{2}' WHERE tenDN ='{3}'", tendn, hovaten, matkhau, maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void doiThongTinUserKhongMatKhau(string tenDN, string hoVaTen, string tenDNCu)
        {
            string tendn = tenDN, hovaten = hoVaTen, maSua = tenDNCu;
            string strSQL = string.Format("UPDATE nhanVien SET tenDN ='{0}', hoVaTen =N'{1}'  WHERE tenDN ='{2}';", tendn, hovaten, maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void capHaQuyen(string quyen, string maNV)
        {
            string quyenMoi = quyen, maSua = maNV;
            string strSQL = string.Format("UPDATE nhanVien SET soMaQH = (select soMaQH from quyenHan WHERE tenQH like N'%{0}%') WHERE maNV = '{1}'", quyenMoi,maSua);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
