using appQLNhaThuoc.Obj_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhan_Vien
{
    public partial class frm_childXoaNV : Form
    {
        NhanVien nv = new NhanVien();
        public frm_childXoaNV()
        {
            InitializeComponent();
        }

        public void layDanhSachNV()
        {
            DataTable tableNV = nv.layDanhSachNhanVien();
            dataGridViewNhanVien.DataSource = tableNV;
        }
        private void frm_childXoaNV_Load(object sender, EventArgs e)
        {
            layDanhSachNV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNhanVien.Rows[e.RowIndex];

            text_maNV.Text = Convert.ToString(row.Cells["maNV"].Value);
            text_hoVaTen.Text = Convert.ToString(row.Cells["hoVaTen"].Value);
            text_soDienThoai.Text = Convert.ToString(row.Cells["sdtNV"].Value);
            DateTime dateTime = DateTime.ParseExact(Convert.ToString(row.Cells["ngaySinhNV"].Value), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            timePicker_ngaySinh.Value = dateTime;
            text_tenDangNhap.Text = Convert.ToString(row.Cells["tenDN"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maXoa = text_maNV.Text;

                if (maXoa.Length <= 0 || maXoa == null) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                    nv.xoaNhanVien(maXoa);
                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    layDanhSachNV();
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
