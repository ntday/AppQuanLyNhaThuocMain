
using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class PhieuXuatKho
    {
        DatabaseObj db;

        public PhieuXuatKho()
        {
            db = new DatabaseObj();
        }

        public string layGiaTriIDENTITY()
        {
            string strSQL = "SELECT IDENT_CURRENT('phieuXuatThuoc') +1 AS next_id";
            DataTable tableNV = db.Execute(strSQL);
            return tableNV.Rows[0]["next_id"].ToString();
        }

        //xuất kho
        public DataTable layDanhSachPhieuXuat()
        {
            string strSQL = "SELECT maPXT, tenNhaCungCap, ngayLapPhieuHT,maNV, hoVaTen, ghiChu FROM phieuXuatThuoc  LEFT JOIN nhaCungCapThuoc ON nhaCungCapThuoc.maNhaCungCap = phieuXuatThuoc.maNhaCungCap  LEFT JOIN nhanVien ON nhanVien.soMaNV = phieuXuatThuoc.soMaNV";
            return db.Execute(strSQL);
        }
        public DataTable layDanhSachPhieuXuatFormat()
        {
            string strSQL = " SELECT maPXT, tenNhaCungCap, ngayLapPhieuHT, maNV, hoVaTen, ghiChu FROM phieuXuatThuoc  LEFT JOIN nhaCungCapThuoc ON nhaCungCapThuoc.maNhaCungCap = phieuXuatThuoc.maNhaCungCap  LEFT JOIN nhanVien ON nhanVien.soMaNV = phieuXuatThuoc.soMaNV";
            return db.Execute(strSQL);
        }

        public void themPhieuXuat(string maNhaCungCap, string ngayLapPhieuNT, string soMaNV, string ghiChu)
        {
            string mancc = maNhaCungCap, ngayLap = ngayLapPhieuNT, smnv = soMaNV, ghichu = ghiChu;
            string strSQL = string.Format("  INSERT INTO phieuXuatThuoc(maNhaCungCap,ngayLapPhieuHT,soMaNV,ghiChu) VALUES ('{0}','{1}',(SELECT soMaNV FROM nhanVien WHERE maNV = '{2}'),N'{3}')", mancc, ngayLap, smnv, ghiChu);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaPhieuXuat(string maNhaCungCap, string ngayLapPhieuNT, string soMaNV, string ghiChu, string maPNT)
        {
            string mancc = maNhaCungCap, ngayLap = ngayLapPhieuNT, smnv = soMaNV, ghichu = ghiChu, maSua = maPNT;
            string strSQL = string.Format("UPDATE phieuXuatThuoc SET maNhaCungCap = '{0}' ,ngayLapPhieuHT ='{1}',soMaNV = '{2}' ,ghiChu =N'{3}'  WHERE maPNT = '{4}'", mancc, ngayLap, smnv, ghichu, maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaPhieuXuat(string maPNT)
        {
            string maXoa = maPNT;
            string strSQL = string.Format("  DELETE FROM phieuXuatThuoc WHERE maPXT  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }


        // chi tiết xuất kho
        public DataTable layDanhSachChiTietPhieuXuat(string MAPXT)
        {
            string mapxt = MAPXT;
            string strSQL = string.Format("SELECT  maSoLo, thuoc.maThuoc, tenThuoc,donGia,soLuong, tenDVT, lyDo FROM chiTietPhiepXuat LEFT JOIN thuoc ON thuoc.maThuoc = chiTietPhiepXuat.maThuoc LEFT JOIN donViTinh ON donViTinh.soMaDVT = chiTietPhiepXuat.soMaDVT WHERE soMaPXT = (SELECT soMaPXT FROM phieuXuatThuoc WHERE maPXT = '{0}' )", mapxt);
            return db.Execute(strSQL);
        }
        public void themChiTietPhieuXuat(string soMaPNT, string maSoLo, string maThuoc, string tenDVT, string donGia, string soLuong,string lyDo)
        {
            string SOMAPNT = soMaPNT, MASOLO = maSoLo, MATHUOC = maThuoc, TENDVT = tenDVT, DONGIA = donGia, SOLUONG = soLuong, LYDO = lyDo;
            string strSQL = string.Format(" INSERT INTO chiTietPhiepXuat(soMaPXT,maSoLo,maThuoc,soMaDVT,donGia,soLuong,lyDo) VALUES ('{0}','{1}','{2}',( SELECT soMaDVT FROM donViTinh WHERE tenDVT ='{3}'),'{4}',{5},N'{6}')", SOMAPNT, MASOLO, MATHUOC, TENDVT, DONGIA, SOLUONG, LYDO);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaChiTietPhieuXuat(string soMaPNT, string maSoLo, string maThuoc, string tenDVT, string donGia, string soLuong, string lyDo, string maThuocC)
        {
            string SOMAPNT = soMaPNT, MASOLO = maSoLo, MATHUOC = maThuoc, TENDVT = tenDVT, DONGIA = donGia, SOLUONG = soLuong,LYDO = lyDo, masua = maThuocC;
            string strSQL = string.Format(" UPDATE chiTietPhiepNhap SET soMaPNT ='{0}',maSoLo='{1}',maThuoc='{2}',soMaDVT=( SELECT soMaDVT FROM donViTinh WHERE tenDVT ='{3}'),donGia='{4}',soLuong ={5}, lyDo = N'{6}'WHERE maThuoc = '{7}'", SOMAPNT, MASOLO, MATHUOC, TENDVT, DONGIA, SOLUONG, LYDO, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaChiTietPhieuXuat(string maThuocC)
        {
            string maXoa = maThuocC;
            string strSQL = string.Format(" DELETE FROM chiTietPhiepXuat WHERE soMaPXT  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }

    }
}
