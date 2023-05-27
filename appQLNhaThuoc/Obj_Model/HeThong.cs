using quanLyNhaThuoc;

namespace appQLNhaThuoc.Obj_Model
{
    class HeThong
    {
        DatabaseObj db;
        public HeThong()
        {
            db = new DatabaseObj();
        }


        public bool sauLuuDuLieu(string duongDanLuu)
        {
            try
            {
                string DuongDanLuu = duongDanLuu;
                string strSQL = string.Format("BACKUP DATABASE QLNhaThuoc TO DISK = '{0}'" +
                    "WITH NOFORMAT, NOINIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10", DuongDanLuu);
                db.ExecuteNonQuery(strSQL);

                return true; // thành công
            }
            catch (System.Exception)
            {

                return false; // không thành công
            }

        }

        public bool phucHoiDuLieu(string duongDanLuu)
        {
            try
            {
                string DuongDanLuu = duongDanLuu;
                string strSQL = string.Format("BACKUP DATABASE QLNhaThuoc TO DISK = '{0}'" +
                    "WITH NOFORMAT, NOINIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10", DuongDanLuu);
                db.Execute(strSQL);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }


        }

    }
}
