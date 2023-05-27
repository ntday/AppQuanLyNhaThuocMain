using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class GiaDonHang
    {
        DatabaseObj db;
        public GiaDonHang()
        {
            db = new DatabaseObj();
        }


        public DataTable layDanhSachGiaDonHang()
        {
            string strSQL = "SELECT giaDonHang.maThuoc, tenThuoc, donGiaBan, ghiChu FROM giaDonHang LEFT JOIN thuoc ON giaDonHang.maThuoc = thuoc.maThuoc";
            return db.Execute(strSQL);
        }

        public string layGiaNhap(string maThuoc)
        {
            string maTh = maThuoc;
            string strSQL = string.Format("SELECT  chiTietKho.maThuoc,tenThuoc,chiTietKho.maSoLo,chiTietKho.soLuong, chiTietKho.soMaPNT, donGia FROM chiTietKho LEFT JOIN thuoc ON chiTietKho.maThuoc = thuoc.maThuoc LEFT JOIN chiTietPhiepNhap ON chiTietPhiepNhap.soMaPNT = chiTietKho.soMaPNT WHERE chiTietKho.maThuoc = '{0}'", maTh);
            DataTable tb = db.Execute(strSQL);
            return tb.Rows[0]["donGia"].ToString();
        }

        public string layGiaBan(string maThuoc)
        {
            string maTh = maThuoc;
            string strSQL = string.Format("SELECT donGiaBan FROM giaDonHang WHERE maThuoc = '{0}'", maTh);
            try
            {
                DataTable tb = db.Execute(strSQL);
                return tb.Rows[0]["donGiaBan"].ToString();
            }
            catch (System.Exception)
            {
                return "null";
            }


        }

        public void themGiaDonHang(string maThuoc, string donGiaBan, string ghiChu)
        {
            string MaThuoc = maThuoc, DonGia = donGiaBan, GhiChu = ghiChu;
            string strSQL = string.Format("INSERT INTO giaDonHang(maThuoc,donGiaBan,ghiChu) VALUES ('{0}', {1}, N'{2}')", MaThuoc, DonGia.Replace(",", ""), GhiChu);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaGiaDonHangh(string maThuoc, string donGiaBan, string ghiChu, string maThuocC)
        {
            string MaThuoc = maThuoc, DonGia = donGiaBan, GhiChu = ghiChu, MaThuocC = maThuocC;
            string strSQL = string.Format(" UPDATE giaDonHang SET maThuoc = '{0}',donGiaBan = {1}, ghiChu =N'{2}' WHERE maThuoc  = '{3}'", MaThuoc, DonGia.Replace(",", ""), GhiChu, MaThuocC);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaGiaDonHang(string maThuoc)
        {
            string maXoa = maThuoc;
            string strSQL = string.Format("DELETE FROM giaDonHang WHERE maThuoc  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
