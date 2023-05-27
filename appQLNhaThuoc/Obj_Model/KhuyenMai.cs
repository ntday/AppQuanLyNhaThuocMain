using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class KhuyenMai
    {
        DatabaseObj db;

        public KhuyenMai()
        {
            db = new DatabaseObj();
        }

        public DataTable danhSachKhuyenMai()
        {
            string strSQL = "SELECT maKM, TenKM, ngayBatDau, ngayKetThuc, soLuong, tenDangKM FROM khuyenMai LEFT JOIN DangKhuyenMai ON khuyenMai.soMaDangKM  = DangKhuyenMai.soMaDangKM";
            return db.Execute(strSQL);
        }

        public void themKhuyenMai(string TenKM, string ngayBatDau, string ngayKetThuc, string soLuong, string tenDangKM)
        {
            string tenkm = TenKM, ngaybd = ngayBatDau, ngaykt = ngayKetThuc, soluong = soLuong, tendangkm = tenDangKM;
            string strSQL = string.Format("INSERT INTO khuyenMai(TenKM, ngayBatDau, ngayKetThuc, soLuong, soMaDangKM) VALUES (N'{0}', '{1}', '{2}', {3}, ( SELECT soMaDangKM FROM DangKhuyenMai WHERE tenDangKM =N'{4}'))", tenkm,ngaybd,ngaykt,soluong,tendangkm);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaKhuyenMai(string TenKM, string ngayBatDau, string ngayKetThuc, string soLuong, string tenDangKM, string maKM)
        {
            string tenkm = TenKM, ngaybd = ngayBatDau, ngaykt = ngayKetThuc, soluong = soLuong, tendangkm = tenDangKM, masua = maKM;
            string strSQL = string.Format("UPDATE khuyenMai SET TenKM=N'{0}', ngayBatDau='{1}', ngayKetThuc='{2}', soLuong={3}, soMaDangKM= ( SELECT soMaDangKM FROM DangKhuyenMai WHERE tenDangKM =N'{4}') WHERE maKM = '{5}'", tenkm, ngaybd, ngaykt, soluong, tendangkm, masua);
            db.ExecuteNonQuery(strSQL);
        }
        public void xoaDotKM(string makm)
        {
            string maXoa = makm;
            string strSQL = string.Format("  DELETE FROM khuyenMai WHERE maKM  = '{0}'",maXoa );
            db.ExecuteNonQuery(strSQL);
        }


        public string laySoKMVTheoTen(string tenKM)
        {

            string tenkm = tenKM;
            string strSQL = string.Format("SELECT soKM FROM khuyenMai WHERE TenKM = N'{0}'", tenkm);

             DataTable dt = db.Execute(strSQL);
            return dt.Rows[0]["soKM"].ToString();
        }

        public DataTable layMaGiamGiaVSQuaTangTheoTen(string tenKM)
        {
            string tenkm = tenKM;
            string strSQL = string.Format(" SELECT giamGia, quaTang FROM DangKhuyenMai WHERE soMaDangKM = (SELECT soMaDangKM FROM khuyenMai WHERE TenKM = N'{0}')", tenkm);
            try
            {
                    return db.Execute(strSQL);
             }
            catch (Exception)
            {

                DataTable dt = new DataTable();
                dt.Rows[0]["giamGia"] = "0";
                dt.Rows[0]["quaTang"] = "";

                return dt;
            }


            /* DataTable dt = db.Execute(strSQL);
            return dt.Rows[0]["soKM"].ToString();*/
        }

    }
}
