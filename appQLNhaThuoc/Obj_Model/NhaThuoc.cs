using quanLyNhaThuoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appQLNhaThuoc.Obj_Model
{
    class NhaThuoc
    {
        DatabaseObj db;

        public NhaThuoc()
        {
            db = new DatabaseObj();
        }

        public DataTable layThongTinNhaThuoc()
        {
            string strSQL = "SELECT * FROM NhaThuoc";
            return db.Execute(strSQL);
        }

        public void themThongTinNhaThuoc(string tenNhaThuoc, string sdtNhaThuoc, string diaChiNhaThuoc, string maSoThue)
        {
            string tenNT = tenNhaThuoc,sdtNT = sdtNhaThuoc,diaCNT = diaChiNhaThuoc, msThue;
            if (maSoThue.Length <= 0) msThue = "";
            else msThue = maSoThue;
            string strSQL = string.Format(" INSERT INTO NhaThuoc(maNhaThuoc,tenNhaThuoc, sdtNhaThuoc, diaChiNhaThuoc,maSoThue) VALUES ('NT001', N'{0}','{1}',N'{2}','{3}')",tenNT,sdtNT,diaCNT, msThue);
            db.ExecuteNonQuery(strSQL);
        }

        public void suaThongTinNhaThuoc(string tenNhaThuoc, string sdtNhaThuoc, string diaChiNhaThuoc, string maSoThue)
        {

            string tenNT = tenNhaThuoc,sdtNT = sdtNhaThuoc,diaCNT = diaChiNhaThuoc, msThue;
            if (maSoThue.Length <= 0) msThue = "";
            else msThue = maSoThue;
            string strSQL = string.Format("UPDATE NhaThuoc SET tenNhaThuoc =N'{0}', sdtNhaThuoc='{1}', diaChiNhaThuoc =N'{2}',maSoThue ='{3}' WHERE maNhaThuoc = 'NT001'", tenNT,sdtNT,diaCNT, msThue);
            db.ExecuteNonQuery(strSQL);
        }

    }
}
