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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai
{
    public partial class frm_childXoaKM : Form
    {
        KhuyenMai km = new KhuyenMai();
        public frm_childXoaKM()
        {
            InitializeComponent();
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
                string max = textBox_maDonKM.Text;
                string ten = textBox_tenKhuyenMai.Text;
                DialogResult ch = MessageBox.Show("đồng ý xóa vĩ viễn dạng khuyến mãi " + ten, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ch == DialogResult.Yes)
                {
                    km.xoaDotKM(max);
                    MessageBox.Show("xóa thành công khuyến mãi", "THÔNG BÁO");

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
        public void layDanhSachKM()
        {
            DataTable tableKM = km.danhSachKhuyenMai();
            dataGridView_khuyenMai.DataSource = tableKM;
        }

        private void dataGridView_khuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_khuyenMai.Rows[e.RowIndex];

            textBox_maDonKM.Text = Convert.ToString(row.Cells["maKM"].Value);
            textBox_tenKhuyenMai.Text = Convert.ToString(row.Cells["TenKM"].Value);
            textBox_soLuong.Text = Convert.ToString(row.Cells["soLuong"].Value);
            //dateTimePicker_thoiGiangBD.Text = Convert.ToString(row.Cells["maNV"].Value);
            //dateTimePicker_thoiGiangKT.Text = Convert.ToString(row.Cells["maNV"].Value);
            comboBox_dangKhuyenMai.Text = Convert.ToString(row.Cells["tenDangKM"].Value);

            DateTime dateTimeBD = DateTime.ParseExact(Convert.ToString(row.Cells["ngayBatDau"].Value), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            dateTimePicker_ngayBatDau.Value = dateTimeBD;
            DateTime dateTimeKT = DateTime.ParseExact(Convert.ToString(row.Cells["ngayKetThuc"].Value), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            dateTimePicker_ngayKetThuc.Value = dateTimeKT;
        }

        private void dataGridView_khuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_childXoaKM_Load(object sender, EventArgs e)
        {
            layDanhSachKM();
        }
    }
}
