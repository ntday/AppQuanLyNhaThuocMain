using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class HoaDon
    {
        DatabaseObj db;

        public HoaDon()
        {
            db = new DatabaseObj();
        }


        public string layGiaTriIDENTITYHoaDon()
        {
            string strSQL = "SELECT IDENT_CURRENT('hoaDon') +1 AS next_id";
            DataTable tableNV = db.Execute(strSQL);
            return tableNV.Rows[0]["next_id"].ToString();
        }

        public DataTable danhSachHoaDon()
        {
            string strSQL = "SELECT * FROM hoaDon";
            return db.Execute(strSQL);
        }

        public DataTable layDanhSachHoaDon()
        {
            string strSQL = "SELECT maHoaDon,ngayLapHoaDon,maNV,hoVaTen,hoaDon.sdtKH,tenKH,TenDangTT,TenKM,ghiChu FROM hoaDon LEFT JOIN nhanVien ON nhanVien.soMaNV=hoaDon.soMaNV LEFT JOIN KhachHang ON KhachHang.sdtKH=hoaDon.sdtKH LEFT JOIN dangThanhToan ON dangThanhToan.soMaDangTT=hoaDon.soMaDangTT LEFT JOIN khuyenMai ON khuyenMai.soKM=hoaDon.soKM";
            return db.Execute(strSQL);
        }


        public string layDanhSachTongGiaTheoHoaDon(string mahd)
        {
            string maHD = mahd;
            string strSQL = string.Format("SELECT soLuong * donGia AS tong from chiTietHoaDon WHERE soMaHoaDon = (SELECT soMaHoaDon FROM hoaDon WHERE maHoaDon = '{0}')", maHD);
            try
            {
                DataTable tableGiaTong = db.Execute(strSQL);
                double sum = 0;

                int n = tableGiaTong.Rows.Count - 1;

                for (int i = 0; i < n; i++)
                {
                    sum = sum + double.Parse(tableGiaTong.Rows[i]["tong"].ToString());
                }

                string chuoi = double.Parse(""+sum).ToString("N3");
                string didangChuoi = chuoi.Remove(chuoi.IndexOf('.'));

                return "" + didangChuoi;

            }
            catch (System.Exception)
            {

                return "0";
            }

        }

        public void luuHoaDon(string soMaNV, string sdtKH, string ngayLapHoaDon, string soMaDangTT, string maNhaThuoc, string soKM, string ghiChu)
        {
            string Somanv = soMaNV, Sdtkh = sdtKH, Ngaylaphoadon = ngayLapHoaDon, Somadangtt = soMaDangTT, Manhathuoc = maNhaThuoc, Sokm = soKM, Ghichu = ghiChu;

            string strSQL1 = string.Format("INSERT INTO hoaDon(soMaNV,sdtKH,ngayLapHoaDon,soMaDangTT,maNhaThuoc,ghiChu) VALUES (( SELECT soMaNV FROM nhanVien  WHERE maNV ='{0}'),'{1}','{2}',{3},'{4}',N'{5}');", Somanv, Sdtkh, Ngaylaphoadon, Somadangtt, Manhathuoc, Ghichu);
            string strSQL2 = string.Format("INSERT INTO hoaDon(soMaNV,sdtKH,ngayLapHoaDon,soMaDangTT,maNhaThuoc,soKM,ghiChu) VALUES (( SELECT soMaNV FROM nhanVien  WHERE maNV ='{0}'),'{1}','{2}',{3},'{4}','{5}',N'{6}');", Somanv, Sdtkh, Ngaylaphoadon, Somadangtt, Manhathuoc, Sokm, Ghichu);
            if (Sokm == "" || Sokm.Length < 0) db.ExecuteNonQuery(strSQL1);
            else db.ExecuteNonQuery(strSQL2);

        }

        public void suaHoaDon(string maNhaCungCap, string ngayLapPhieuNT, string soMaNV, string ghiChu, string maPNT)
        {
            string mancc = maNhaCungCap, ngayLap = ngayLapPhieuNT, smnv = soMaNV, ghichu = ghiChu, maSua = maPNT;
            string strSQL = string.Format("UPDATE phieuNhapThuoc SET maNhaCungCap = '{0}' ,ngayLapPhieuNT ='{1}',soMaNV = '{2}' ,ghiChu =N'{3}'  WHERE maPNT = '{4}'", mancc, ngayLap, smnv, ghiChu);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaHoaDon(string maHD)
        {
            string maXoa = maHD;
            string strSQL = string.Format("DELETE FROM hoaDon WHERE maHoaDon  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }


        // chi tiết hóa đơn

        public DataTable chiTietHoaDon(string maHoaDon)
        {
            string MaHoaDon = maHoaDon;
            string strSQL = string.Format("SELECT * FROM chiTietHoaDon WHERE soMaHoaDon = (SELECT soMaHoaDon FROM hoaDon  WHERE maHoaDon = '{0}')", MaHoaDon);
            return db.Execute(strSQL);
        }

        public void themChiTietHoaDon(string soMaHoaDon, string maThuoc, string soMaDVT, string soLuong, string donGia, string ghiChu)
        {
            string Somahoadon = soMaHoaDon, Mathuoc = maThuoc, Somadvt = soMaDVT, Soluong = soLuong, Dongia = donGia, GhiChu = ghiChu;
            string strSQL = string.Format("INSERT INTO chiTietHoaDon(soMaHoaDon,maThuoc,soMaDVT,soLuong,donGia,ghiChu) VALUES ({0},'{1}',( SELECT soMaDVT FROM donViTinh WHERE tenDVT = '{2}'),{3},{4},N'{5}')", Somahoadon, Mathuoc, Somadvt, Soluong, Dongia, GhiChu);
            db.ExecuteNonQuery(strSQL);
        }



    }


}
