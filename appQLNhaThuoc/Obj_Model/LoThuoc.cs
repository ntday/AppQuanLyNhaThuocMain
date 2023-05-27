using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class LoThuoc
    {
        DatabaseObj db;
        public LoThuoc()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachLoThuoc()
        {
            string strSQL = "SELECT maSoLo, tenHangDuoc, ngaySanXuat, ngayHetHang,donViBaoGoi,donViDongGoi,donViSanPham, ghiChu FROM loThuoc LEFT JOIN hangDuocPham ON loThuoc.maHangDuoc = hangDuocPham.maHangDuoc";
            return db.Execute(strSQL);
        }

        public void themLoThuoc(string maSoLo, string maHangDuoc, string ngaySanXuat, string ngayHetHang, string donViBaoGoi, string donViDongGoi, string donViSanPham, string ghiChu)
        {
            string Masolo = maSoLo, Mahangduoc = maHangDuoc, Ngaysanxuat = ngaySanXuat, Ngayhethang = ngayHetHang, Donvibaogoi = donViBaoGoi, Donvidonggoi = donViDongGoi, Donvisanpham = donViSanPham, Ghichu = ghiChu;
            string strSQL = string.Format("INSERT INTO loThuoc(maSoLo, maHangDuoc, ngaySanXuat, ngayHetHang,donViBaoGoi,donViDongGoi,donViSanPham, ghiChu) VALUES ('{0}', (SELECT maHangDuoc FROM hangDuocPham WHERE tenHangDuoc = N'{1}'), '{2}', '{3}',N'{4}',N'{5}',N'{6}', N'{7}')", Masolo, Mahangduoc, Ngaysanxuat, Ngayhethang, Donvibaogoi, Donvidonggoi, Donvisanpham, Ghichu);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaLoThuoc(string maSoLo, string maHangDuoc, string ngaySanXuat, string ngayHetHang, string donViBaoGoi, string donViDongGoi, string donViSanPham, string ghiChu, string soLoC)
        {
            string Masolo = maSoLo, Mahangduoc = maHangDuoc, Ngaysanxuat = ngaySanXuat, Ngayhethang = ngayHetHang, Donvibaogoi = donViBaoGoi, Donvidonggoi = donViDongGoi, Donvisanpham = donViSanPham, Ghichu = ghiChu, maSua = soLoC;
            string strSQL = string.Format("UPDATE loThuoc SET maSoLo = '{0}', maHangDuoc= (SELECT maHangDuoc FROM hangDuocPham WHERE tenHangDuoc = N'{1}'), ngaySanXuat= '{2}', ngayHetHang= '{3}',donViBaoGoi= N'{4}',donViDongGoi= N'{5}',donViSanPham= N'{6}', ghiChu= '{7}' WHERE maSoLo = '{8}'", Masolo, Mahangduoc, Ngaysanxuat, Ngayhethang, Donvibaogoi, Donvidonggoi, Donvisanpham, Ghichu, maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaLoThuoc(string soLo)
        {
            string maXoa = soLo;
            string strSQL = string.Format("DELETE FROM loThuoc WHERE maSoLo  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
