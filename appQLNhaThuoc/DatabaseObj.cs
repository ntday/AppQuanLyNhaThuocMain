
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanLyNhaThuoc
{
    class DatabaseObj
    {
        SqlConnection sqlConn; //đối tượng kết nối csdl
        SqlDataAdapter da; //bộ điều phối dữ liệu
        DataSet ds; //chứa dữ liệu được lấy từ db dứ dạng bản
        public DatabaseObj()
        {

            string strCnn = global::appQLNhaThuoc.Properties.Settings.Default.QLNhaThuocConnectionString;
            sqlConn = new SqlConnection(strCnn);
        }
        //phương thúc để thực hiện câu lệnh strSQL truy vấn dữ liệu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //phương thức để thực hiện câu lệnh thêm, xóa, sửa
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); // mở kết nối
            sqlcmd.ExecuteNonQuery(); // thực hiên câu lệnh thêm sữa xóa
            sqlConn.Close(); // đống kết nối
        }
    }
}

