using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class Thuoc
    {
        DatabaseObj db;
        public Thuoc()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachThuoc()
        {
            string strSQL = " SELECT maThuoc, tenThuoc, thanhPhanChinh,congDungChinh,tenNhomThuoc FROM thuoc LEFT JOIN nhomThuoc ON thuoc.soMaNT = nhomThuoc.soMaNT";
            return db.Execute(strSQL);
        }

        public DataTable layDanhSachThuocTheoNhom(string tenNhomThuoc)
        {
            string tennhomthuoc = tenNhomThuoc;
            string strSQL = string.Format("SELECT thuoc.maThuoc, thuoc.tenThuoc,nhomThuoc.tenNhomThuoc FROM thuoc INNER JOIN nhomThuoc ON thuoc.soMaNT = nhomThuoc.soMaNT WHERE nhomThuoc.tenNhomThuoc = N'{0}'", tennhomthuoc);
            try
            {
                return db.Execute(strSQL);
            }
            catch (System.Exception)
            {
                return db.Execute(strSQL);
            }
        }

        public void themThuoc(string maThuoc, string tenThuoc, string thanhPhanChinh, string congDungChinh, string tenNhomThuoc)
        {
            string Mathuoc = maThuoc, Tenthuoc = tenThuoc, Thanhphanchinh = thanhPhanChinh, Congdungchinh = congDungChinh, TenNhomThuoc = tenNhomThuoc;

            string strSQL = string.Format("INSERT INTO thuoc(maThuoc, tenThuoc,thanhPhanChinh,congDungChinh, soMaNT) VALUES ('{0}', N'{1}',N'{2}',N'{3}', (SELECT soMaNT FROM nhomThuoc WHERE tenNhomThuoc = N'{4}' ));", Mathuoc, Tenthuoc, Thanhphanchinh, Congdungchinh, TenNhomThuoc);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaThuoc(string maThuoc, string tenThuoc, string thanhPhanChinh, string congDungChinh, string tenNhomThuoc, string mathuocCu)
        {
            string Mathuoc = maThuoc, Tenthuoc = tenThuoc, Thanhphanchinh = thanhPhanChinh, Congdungchinh = congDungChinh, TenNhomThuoc = tenNhomThuoc, maSua = mathuocCu;
            string strSQL = string.Format("UPDATE thuoc SET maThuoc = '{0}', tenThuoc = N'{1}', thanhPhanChinh = N'{2}',congDungChinh = N'{3}',soMaNT = '{4}' WHERE maThuoc = '{5}'", Mathuoc, Tenthuoc, Thanhphanchinh, Congdungchinh, TenNhomThuoc, maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaThuoc(string maThuoc)
        {
            string maXoa = maThuoc;
            string strSQL = string.Format("DELETE FROM thuoc WHERE maThuoc  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}

