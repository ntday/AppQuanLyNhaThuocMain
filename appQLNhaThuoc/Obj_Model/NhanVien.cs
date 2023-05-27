using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class NhanVien
    {
        DatabaseObj db;
        public NhanVien()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachNhanVien()
        {
            string strSQL = "SELECT maNV,hoVaTen,sdtNV,ngaySinhNV,tenDN, tenQH FROM nhanVien LEFT JOIN quyenHan on  nhanVien.soMaQH = quyenHan.soMaQH";
            return db.Execute(strSQL);
        }

        public void themNhanVien(string hoVaTen, string sdtNV, string ngaySinhNV, string tenDN)
        {

            string HoVaTen = hoVaTen, SdtNV = sdtNV, NgaySinhNV = ngaySinhNV, TenDN = tenDN;
            string strSQL = string.Format(" INSERT INTO nhanVien(hoVaTen,sdtNV,ngaySinhNV,tenDN,matKhau, soMaQH) VALUES (N'{0}',N'{1}','{2}','{3}','abc@1234', 2)",hoVaTen,SdtNV, NgaySinhNV, TenDN);
            db.ExecuteNonQuery(strSQL);
        }
        public void suaNhanVien(string hoVaTen, string sdtNV, string ngaySinhNV, string tenDN, string maNV)
        {

            string HoVaTen = hoVaTen, SdtNV = sdtNV, NgaySinhNV = ngaySinhNV, TenDN = tenDN, maSua = maNV;
            string strSQL = string.Format("UPDATE nhanVien SET hoVaTen =N'{0}',sdtNV='{1}',ngaySinhNV='{2}',tenDN ='{3}' WHERE maNV  = '{4}'",  hoVaTen, SdtNV, NgaySinhNV, TenDN, maSua);
            db.ExecuteNonQuery(strSQL);
        }
        public void xoaNhanVien(string maNV)
        {
            string maXoa = maNV;
            string strSQL = string.Format("DELETE FROM nhanVien WHERE maNV  = '{0}'",maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
