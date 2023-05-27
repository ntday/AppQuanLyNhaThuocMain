using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class DonViTinh
    {
        DatabaseObj db;
        public DonViTinh()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachDonViTinh()
        {
            string strSQL = " SELECT * FROM donViTinh";
            return db.Execute(strSQL);
        }

        public void themDonViTinhMoi(string tenDVTmoi, string moTaDVTmoi)
        {
            string tem = tenDVTmoi, mota = moTaDVTmoi;
            string strSQL = string.Format("INSERT INTO donViTinh(tenDVT,moTaDVT) VALUES (N'{0}', N'{1}')", tem, mota);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaDonViTinh(string tenDVTmoi, string moTaDVTmoi, string maDVT)
        {
            string tem = tenDVTmoi, mota = moTaDVTmoi, masua = maDVT;
            string strSQL = string.Format(" UPDATE donViTinh SET tenDVT = N'{0}',moTaDVT = N'{1}' WHERE maDVT  = '{2}'", tem, mota, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaDonViTinh(string maDVT)
        {
            string maXoa = maDVT;
            string strSQL = string.Format("DELETE FROM donViTinh WHERE maDVT  = '{0}'",maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
