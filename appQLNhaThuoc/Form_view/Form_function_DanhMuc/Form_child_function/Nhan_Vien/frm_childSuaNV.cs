using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhan_Vien
{
    public partial class frm_childSuaNV : Form
    {
        NhanVien nv = new NhanVien();
        public frm_childSuaNV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void layDanhSachNV()
        {
            DataTable tableNV = nv.layDanhSachNhanVien();
            dataGridViewNhanVien.DataSource = tableNV;
        }

        private void frm_childSuaNV_Load(object sender, EventArgs e)
        {
            layDanhSachNV();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string format = "dd/MM/yyyy hh:mm:ss tt";

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNhanVien.Rows[e.RowIndex];

            text_maNV.Text = Convert.ToString(row.Cells["maNV"].Value);
            text_hoVaTen.Text = Convert.ToString(row.Cells["hoVaTen"].Value);
            text_soDienThoai.Text = Convert.ToString(row.Cells["sdtNV"].Value);
            DateTime dateTime = DateTime.ParseExact(Convert.ToString(row.Cells["ngaySinhNV"].Value), format, CultureInfo.InvariantCulture);
            timePicker_ngaySinh.Value = dateTime;
            text_tenDangNhap.Text = Convert.ToString(row.Cells["tenDN"].Value);

        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string maSua = text_maNV.Text;
                string hoten = text_hoVaTen.Text;
                string sdt = text_soDienThoai.Text;
                DateTime ngaySinh = timePicker_ngaySinh.Value;
                string tendn = text_tenDangNhap.Text;

                string ngaySinhString = ngaySinh.ToString("yyyy-MM-dd");



                if(maSua.Length<=0 || maSua == null) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                    nv.suaNhanVien(hoten, sdt, ngaySinhString, tendn, maSua);
                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
                throw;
            }
        }
    }
}
