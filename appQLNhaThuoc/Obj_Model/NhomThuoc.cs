using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class NhomThuoc
    {
        DatabaseObj db;
        public NhomThuoc()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachNhomThuoc()
        {
            string strSQL = " SELECT * FROM nhomThuoc";
            return db.Execute(strSQL);
        }

        public void themNhomThuoc(string tenNhomThuoc, string moTa)
        {
            string tem = tenNhomThuoc, mota = moTa;
            string strSQL = string.Format("INSERT INTO nhomThuoc(tenNhomThuoc, moTa) VALUES (N'{0}', N'{1}')", tem, mota);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaNhomThuoc(string tenNhomThuoc, string moTa, string maNhomThuoc)
        {
            string tem = tenNhomThuoc, mota = moTa, masua = maNhomThuoc;
            string strSQL = string.Format("UPDATE nhomThuoc SET tenNhomThuoc = N'{0}', moTa= N'{1}'  WHERE maNhomThuoc = '{2}'", tem, mota, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaNhomThuoc(string maNhomThuoc)
        {
            string maXoa = maNhomThuoc;
            string strSQL = string.Format(" DELETE FROM nhomThuoc WHERE maNhomThuoc  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
