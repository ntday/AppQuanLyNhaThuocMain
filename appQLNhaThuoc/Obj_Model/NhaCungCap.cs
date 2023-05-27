using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyNhaThuoc;
using System.Data;
namespace appQLNhaThuoc.Obj_Model
{

    class NhaCungCap
    {
        DatabaseObj db;
        public NhaCungCap()
        {
            db = new DatabaseObj();
        }
        public DataTable layDanhSachNhaCungCap()
        {
            string strSQL = "SELECT * FROM nhaCungCapThuoc";
            return db.Execute(strSQL);
        }
        public void themNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string sdtNhaCungCap, string emailNhaCungCap, string diaChiNhaCungCap)
        {
            string MaNhaCungCap = maNhaCungCap, TenNhaCungCap = tenNhaCungCap, SdtNhaCungCap = sdtNhaCungCap, EmailNhaCungCap = emailNhaCungCap, DiaChiNhaCungCap = diaChiNhaCungCap;
            string strSQL = string.Format("INSERT INTO nhaCungCapThuoc(maNhaCungCap, tenNhaCungCap, sdtNhaCungCap, emailNhaCungCap, diaChiNhaCungCap) VALUES ('{0}', N'{1}', '{2}', '{3}', N'{4}')", maNhaCungCap, tenNhaCungCap, sdtNhaCungCap, emailNhaCungCap, diaChiNhaCungCap);
            db.ExecuteNonQuery(strSQL);
        }
        public void suaNhaCungCap(string maNhaCungCap, string tenNhaCungCap, string sdtNhaCungCap, string emailNhaCungCap, string diaChiNhaCungCap, string maNhaCC)
        {
            string MaNhaCungCap = maNhaCungCap, TenNhaCungCap = tenNhaCungCap, SdtNhaCungCap = sdtNhaCungCap, EmailNhaCungCap = emailNhaCungCap, DiaChiNhaCungCap = diaChiNhaCungCap, MaDoi = maNhaCC;
            string strSQL = string.Format("UPDATE nhaCungCapThuoc SET maNhaCungCap = '{0}', tenNhaCungCap = N'{1}', sdtNhaCungCap = '{2}', emailNhaCungCap = '{3}', diaChiNhaCungCap = N'{4}' WHERE maNhaCungCap = '{4}'  ", MaNhaCungCap, TenNhaCungCap, SdtNhaCungCap, EmailNhaCungCap, DiaChiNhaCungCap, MaDoi);
            db.ExecuteNonQuery(strSQL);
        }
        public void xoaNhaCungCap(string maNhaCungCap)
        {
            string maXoa = maNhaCungCap;
            string strSQL = string.Format(" DELETE FROM nhaCungCapThuoc WHERE maNhaCungCap  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
