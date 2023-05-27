using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class NhatKyHeThong
    {
        DatabaseObj db;

        public NhatKyHeThong()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhSachNhatKy()
        {
            string strSQL = "SELECT maNV, hoVaTen, timeDangNhap,timeDangXuat  FROM nhatKyHeThong LEFT JOIN nhanVien ON nhatKyHeThong.soMaNV = nhanVien.soMaNV";
            return db.Execute(strSQL);
        }
        public void ghiNhanDangNhap(string tenDN, string timeDN)
        {
            string tendn = tenDN, timedn = timeDN;
            string strSQL = string.Format("INSERT INTO nhatKyHeThong(soMaNV, timeDangNhap,trangThai) VALUES ((SELECT soMaNV FROM nhanVien WHERE tenDN = '{0}'), '{1}' ,'dn')", tendn, timedn);
            db.ExecuteNonQuery(strSQL);
        }

        public void ghiNhanDangXuat(string tenDN, string timeDX)
        {
            string tendn = tenDN, timedn = timeDX;
            string strSQL = string.Format("UPDATE nhatKyHeThong SET timeDangXuat = N'{0}', trangThai = 'dx' WHERE soMaNV = (SELECT soMaNV FROM nhanVien WHERE tenDN = '{1}') AND trangThai = 'dn';", timedn, tendn);
            db.ExecuteNonQuery(strSQL);
        }
    }
}
