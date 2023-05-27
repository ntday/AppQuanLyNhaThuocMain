using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class Kho
    {
        DatabaseObj db;
        public Kho()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachKho()
        {
            //string strSQL = "SELECT tenKho,maThuoc,maSoLo,soLuong, soMaPNT FROM chiTietKho LEFT JOIN kho ON chiTietKho.soMakho = kho.soMakho";
            string strSQL = "SELECT * FROM kho";
            return db.Execute(strSQL);
        }

        public void themKhoMoi(string tenKho, string ghiChu)
        {
            string tem = tenKho, mota = ghiChu;
            string strSQL = string.Format("INSERT INTO kho(tenKho,ghiChu) VALUES (N'{0}',N'{1}')", tem, mota);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaKho(string tenKho, string ghiChu, string maKho)
        {
            string tem = tenKho, mota = ghiChu, masua = maKho;
            string strSQL = string.Format("UPDATE kho SET tenKho = N'{0}' ,ghiChu =N'{1}' WHERE maKho = '{2}'", tem, mota, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaKho(string maKho)
        {
            string maXoa = maKho;
            string strSQL = string.Format("  DELETE FROM kho WHERE maKho  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }

        // chi tiết kho

        public DataTable layDanhChiTietKho()
        {
            string strSQL = "SELECT  chiTietKho.maThuoc,tenThuoc,chiTietKho.maSoLo,soLuong FROM chiTietKho LEFT JOIN thuoc ON chiTietKho.maThuoc = thuoc.maThuoc";
            return db.Execute(strSQL);
        }

        public void themChiTietKho(string maThuoc, string maSoLo, string soLuong, string soMaPNT)
        {
            string Mathuoc = maThuoc, Masolo = maSoLo, Soluong = soLuong, smapnt = soMaPNT;
            string strSQL = string.Format("INSERT INTO chiTietKho(soMakho,maThuoc,maSoLo,soLuong,soMaPNT) VALUES ('1','{0}','{1}',{2},'{3}');", Mathuoc, Masolo, Soluong, smapnt);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaChiTietKho(string soMakho, string maThuoc, string maSoLo, string soLuong, string maThuocC, string maSoLoC)
        {
            string Somakho = soMakho, Mathuoc = maThuoc, Masolo = maSoLo, Soluong = soLuong, MaThuocC = maThuocC, MaSoLoC = maSoLoC;
            string strSQL = string.Format(" UPDATE chiTietKho SET soMakho = '{0}',maThuoc = '{1}' ,maSoLo = '{2}' ,soLuong = {3} WHERE maThuoc = '{4}' AND maSoLo ='{5}'", Somakho, Mathuoc, Masolo, Soluong, MaThuocC, MaSoLoC);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaSoLuongTrongKho(string soMakho, string soLuong, string maThuocC, string maSoLoC)
        {
            string Somakho = soMakho, Soluong = soLuong, MaThuocC = maThuocC, MaSoLoC = maSoLoC;
            string strSQL = string.Format(" UPDATE chiTietKho SET soMakho = '{0}' ,soLuong = {1} WHERE maThuoc = '{2}' AND maSoLo ='{3}'", Somakho, Soluong, MaThuocC, MaSoLoC);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaSoLuongTrongKhoTheoMaThuoc(string soMakho, string soLuong, string maThuocC)
        {
            string Somakho = soMakho, Soluong = soLuong, MaThuocC = maThuocC;
            string strSQL = string.Format(" UPDATE chiTietKho SET soMakho = '{0}' ,soLuong = {1} WHERE maThuoc = '{2}'", Somakho, Soluong, MaThuocC);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaChiTietKho(string maThuocC, string maSoLoC)
        {
            string MaThuocC = maThuocC, MaSoLoC = maSoLoC;
            string strSQL = string.Format(" DELETE FROM chiTietKho WHERE  maThuoc = '{0}' AND maSoLo ='{1}'", MaThuocC, MaSoLoC);
            db.ExecuteNonQuery(strSQL);
        }

        public bool chekTonTaiChiTiet(string maThuoc, string maSoLo)
        {
            string MaThuocC = maThuoc, MaSoLoC = maSoLo;
            string strSQL = string.Format("SELECT COUNT(*) AS checkUnique  FROM chiTietKho WHERE maThuoc ='{0}' AND maSoLo='{1}'", MaThuocC, MaSoLoC);
            DataTable tableChek = db.Execute(strSQL);
            int soChek = int.Parse(tableChek.Rows[0]["checkUnique"].ToString());
            if (soChek == 0) return true; // chưa có chi tiết kho
            else return false; // đã có chi tiết kho

        }


        public string layDonViTinhTheoMaThuoc(string maThuoc)
        {

            string MaThuoc = maThuoc;
            string strSQL = string.Format(" SELECT chiTietKho.maThuoc, tenDVT FROM chiTietKho  LEFT JOIN chiTietPhiepNhap ON chiTietPhiepNhap.soMaPNT = chiTietKho.soMaPNT  LEFT JOIN donViTinh ON donViTinh.soMaDVT = chiTietPhiepNhap.soMaDVT WHERE chiTietKho.maThuoc ='{0}' ", MaThuoc);

            try
            {
                DataTable tableSL = db.Execute(strSQL);
                return tableSL.Rows[0]["tenDVT"].ToString();
            }
            catch (System.Exception)
            {

                return "null";
            }


        }

        public int laySoLuongKhoTheoMaThuocvsMaLo(string maThuoc, string maLo)
        {
            string MaThuoc = maThuoc, MaSoLo = maLo;
            string strSQL = string.Format("SELECT soLuong FROM chiTietKho WHERE  maThuoc = '{0}' AND maSoLo ='{1}'", MaThuoc, MaSoLo);

            DataTable tableSL = db.Execute(strSQL);
            int sl = int.Parse(tableSL.Rows[0]["soLuong"].ToString());
            return sl;
        }

        public int laySoLuongKhoTheoMaThuoc(string maThuoc)
        {
            string MaThuoc = maThuoc;
            string strSQL = string.Format("SELECT soLuong FROM chiTietKho WHERE  maThuoc = '{0}'", MaThuoc);
            try
            {
                DataTable tableSL = db.Execute(strSQL);

                int sl = int.Parse(tableSL.Rows[0]["soLuong"].ToString());

                return sl;
            }
            catch (System.Exception)
            {

                return 0;
            }

        }

        public DataTable layDanhSachTinhTrang()
        {
            string strSQL = "SELECT thuoc.maThuoc,tenThuoc,chiTietKho.maSoLo,ngaySanXuat,ngayHetHang, chiTietKho.soLuong,tenDVT FROM thuoc LEFT JOIN chiTietKho ON  thuoc.maThuoc = chiTietKho.maThuoc LEFT JOIN loThuoc ON chiTietKho.maSoLo = loThuoc.maSoLo LEFT JOIN chiTietPhiepNhap ON chiTietPhiepNhap.soMaPNT = chiTietKho.soMaPNT LEFT JOIN donViTinh ON donViTinh.soMaDVT = chiTietPhiepNhap.soMaDVT";
            return db.Execute(strSQL);
        }
        public DataTable layDanhSachTinhTrangTheoMa(string maThuoc)
        {
            string mathuoc = maThuoc;
            string strSQL = string.Format("SELECT thuoc.maThuoc,tenThuoc,chiTietKho.maSoLo,ngaySanXuat,ngayHetHang,loThuoc.tenDVT soLuong FROM thuoc LEFT JOIN chiTietKho ON  thuoc.maThuoc = chiTietKho.maThuoc LEFT JOIN loThuoc ON chiTietKho.maSoLo = loThuoc.maSoLo WHERE thuoc.maThuoc LIKE '%{0}%'", mathuoc);
            return db.Execute(strSQL);
        }
        public DataTable layDanhSachTinhTrangTheoTen(string tenThuoc)
        {
            string tenthuoc = tenThuoc;
            string strSQL = string.Format("SELECT thuoc.maThuoc,tenThuoc,chiTietKho.maSoLo,ngaySanXuat,ngayHetHang, soLuong FROM thuoc LEFT JOIN chiTietKho ON  thuoc.maThuoc = chiTietKho.maThuoc LEFT JOIN loThuoc ON chiTietKho.maSoLo = loThuoc.maSoLo WHERE tenThuoc LIKE N'%{0}%'", tenthuoc);
            return db.Execute(strSQL);
        }
    }
}
