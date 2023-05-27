using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class PhieuNhapKho
    {
        DatabaseObj db;

        public PhieuNhapKho()
        {
            db = new DatabaseObj();
        }

        public string layGiaTriIDENTITY()
        {
            string strSQL = "SELECT IDENT_CURRENT('phieuNhapThuoc') +1 AS next_id";
            DataTable tableNV = db.Execute(strSQL);
            return tableNV.Rows[0]["next_id"].ToString();
        }

        //nhập kho

        public DataTable layDanhSachPhieuNhap()
        {
            string strSQL = "SELECT *FROM phieuNhapThuoc";
            return db.Execute(strSQL);
        }
        public DataTable layDanhSachPhieuNhapFormat()
        {
            string strSQL = " select maPNT, tenNhaCungCap, ngayLapPhieuNT,maNV, hoVaTen, ghiChu from phieuNhapThuoc LEFT JOIN nhaCungCapThuoc ON nhaCungCapThuoc.maNhaCungCap = phieuNhapThuoc.maNhaCungCap LEFT JOIN nhanVien ON nhanVien.soMaNV = phieuNhapThuoc.soMaNV";
            return db.Execute(strSQL);
        }
        public void themPhieuNhap(string maNhaCungCap, string ngayLapPhieuNT, string soMaNV, string ghiChu)
        {
            string mancc = maNhaCungCap, ngayLap = ngayLapPhieuNT, smnv = soMaNV, ghichu = ghiChu;
            string strSQL = string.Format("  INSERT INTO phieuNhapThuoc(maNhaCungCap,ngayLapPhieuNT,soMaNV,ghiChu) VALUES ('{0}','{1}',(SELECT soMaNV FROM nhanVien WHERE maNV = '{2}'),N'{3}')", mancc, ngayLap, smnv, ghiChu);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaPhieuNhap(string maNhaCungCap, string ngayLapPhieuNT, string soMaNV, string ghiChu, string maPNT)
        {
            string mancc = maNhaCungCap, ngayLap = ngayLapPhieuNT, smnv = soMaNV, ghichu = ghiChu, maSua = maPNT;
            string strSQL = string.Format("UPDATE phieuNhapThuoc SET maNhaCungCap = '{0}' ,ngayLapPhieuNT ='{1}',soMaNV = '{2}' ,ghiChu =N'{3}'  WHERE maPNT = '{4}'", mancc, ngayLap, smnv, ghiChu);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaPhieuNhap(string maPNT)
        {
            string maXoa = maPNT;
            string strSQL = string.Format("  DELETE FROM phieuNhapThuoc WHERE maPNT  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }


        // chi tiết nhập kho
        public DataTable layDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            string maphieunhap = maPhieuNhap;
            string strSQL = string.Format("SELECT  maSoLo, thuoc.maThuoc, tenThuoc,donGia,soLuong, tenDVT FROM chiTietPhiepNhap LEFT JOIN phieuNhapThuoc ON phieuNhapThuoc.soMaPNT = chiTietPhiepNhap.soMaPNT LEFT JOIN thuoc ON thuoc.maThuoc = chiTietPhiepNhap.maThuoc LEFT JOIN donViTinh ON donViTinh.soMaDVT = chiTietPhiepNhap.soMaDVT WHERE phieuNhapThuoc.soMaPNT =  (SELECT soMaPNT FROM phieuNhapThuoc WHERE maPNT = N'{0}')", maphieunhap);
            return db.Execute(strSQL);
        }
        public void themChiTietPhieuNhap(string soMaPNT, string maSoLo, string maThuoc, string tenDVT, string donGia, string soLuong)
        {
            string SOMAPNT = soMaPNT, MASOLO = maSoLo, MATHUOC = maThuoc, TENDVT = tenDVT, DONGIA = donGia, SOLUONG = soLuong;
            string strSQL = string.Format(" INSERT INTO chiTietPhiepNhap(soMaPNT,maSoLo,maThuoc,soMaDVT,donGia,soLuong) VALUES ('{0}','{1}','{2}',( SELECT soMaDVT FROM donViTinh WHERE tenDVT =N'{3}'),'{4}',{5})", SOMAPNT, MASOLO, MATHUOC, TENDVT, DONGIA, SOLUONG);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaChiTietPhieuNhap(string soMaPNT, string maSoLo, string maThuoc, string tenDVT, string donGia, string soLuong, string maThuocC)
        {
            string SOMAPNT = soMaPNT, MASOLO = maSoLo, MATHUOC = maThuoc, TENDVT = tenDVT, DONGIA = donGia, SOLUONG = soLuong, masua = maThuocC;
            string strSQL = string.Format(" UPDATE chiTietPhiepNhap SET soMaPNT ='{0}',maSoLo='{1}',maThuoc='{2}',soMaDVT=( SELECT soMaDVT FROM donViTinh WHERE tenDVT ='{3}'),donGia='{4}',soLuong ={5} WHERE maThuoc = '{6}'", SOMAPNT, MASOLO, MATHUOC, TENDVT, DONGIA, SOLUONG, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaChiTietPhieuNhap(string maThuocC)
        {
            string maXoa = maThuocC;
            string strSQL = string.Format(" DELETE FROM chiTietPhiepNhap WHERE maThuoc  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }



    }
}
