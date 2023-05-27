using quanLyNhaThuoc;
using System.Data;

namespace appQLNhaThuoc.Obj_Model
{
    class BangTam
    {
        DatabaseObj db;
        public BangTam()
        {
            db = new DatabaseObj();
        }

        public DataTable layDanhBangTam()
        {
            string strSQL = " SELECT * FROM bangSoLuongTam";
            return db.Execute(strSQL);
        }

        public void themBangTam(string maThuoc, string soLuongTam)
        {
            string MaThuoc = maThuoc, SoLuongTam = soLuongTam;
            string strSQL = string.Format("INSERT INTO bangSoLuongTam(maThuoc,soLuongTam) VALUES ('{0}', '{1}')", MaThuoc, SoLuongTam);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaSoLuongBangTam(string soLuongTam, string maThuocTamC)
        {
            string SoLuongTam = soLuongTam, masua = maThuocTamC;
            string strSQL = string.Format(" UPDATE bangSoLuongTam SET soLuongTam = '{0}' WHERE maThuoc  = '{1}'", SoLuongTam, masua);
            db.ExecuteNonQuery(strSQL);
        }

        public void xoaBangTam()
        {
            string strSQL = string.Format("DELETE FROM bangSoLuongTam");
            db.ExecuteNonQuery(strSQL);
        }

        public bool checkDaCoBangtamTheoMaThuoc(string maThuoc)
        {
            string maTh = maThuoc;
            string strSQL =string.Format("SELECT COUNT(*) AS checkUnique  FROM bangSoLuongTam WHERE maThuoc ='{0}'", maTh);
             DataTable tbCheck =  db.Execute(strSQL);
            int soCheck = int.Parse(tbCheck.Rows[0]["checkUnique"].ToString());
            if (soCheck <= 0) return true; // chưa có thuốc trong bảng tạm
            else return false; // đã có thuốc trong bảng tạm
        }

        public int laySoLuongBangTamTheoMa(string maThuoc)
        {
            string maTh = maThuoc;
            string strSQL = string.Format("SELECT soLuongTam  FROM bangSoLuongTam WHERE maThuoc ='{0}'", maTh);
            DataTable tbCheck = db.Execute(strSQL);
            int soLuongT = int.Parse(tbCheck.Rows[0]["soLuongTam"].ToString());
            return soLuongT;
        }
    }
}
