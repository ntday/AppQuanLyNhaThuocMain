using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class KhachHang
    {
        DatabaseObj db;
        public KhachHang()
        {
            db = new DatabaseObj();
        }

        public DataTable layDangSachKhachHang()
        {
            string strSQL = "SELECT * FROM KhachHang";
            return db.Execute(strSQL);
        }

        public void themKhachHang(string sdtKH, string hoHoLotKH, string tenKH, string namSinh)
        {
            string SdtKH = sdtKH, HoHoLotKH = hoHoLotKH, TenKH = tenKH, NamSinh = namSinh;
            string strSQL = string.Format(" INSERT INTO KhachHang(sdtKH,hoHoLotKH,tenKH, namSinh) VALUES ('{0}',N'{1}',N'{2}','{3}');", SdtKH, HoHoLotKH, TenKH, NamSinh);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaKhachHang(string sdtKH, string hoHoLotKH, string tenKH, string namSinh, string sdtKHc)
        {
            string SdtKH = sdtKH, HoHoLotKH = hoHoLotKH, TenKH = tenKH, NamSinh = namSinh, maSua = sdtKHc;
            string strSQL = string.Format("UPDATE KhachHang SET sdtKH ='{0}',hoHoLotKH =N'{1}',tenKH =N'{2}', namSinh = '{3}' WHERE sdtKH  = '{4}'", SdtKH, HoHoLotKH, TenKH, NamSinh,maSua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaKhachHang(string sdtKH)
        {
            string maXoa = sdtKH;
            string strSQL = string.Format(" DELETE FROM KhachHang WHERE sdtKH  = '{0}'", maXoa);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
