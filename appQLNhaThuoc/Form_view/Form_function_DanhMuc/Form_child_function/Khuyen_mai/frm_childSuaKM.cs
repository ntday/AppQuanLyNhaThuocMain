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
    public partial class frm_childSuaKM : Form
    {

        KhuyenMai km = new KhuyenMai();
        public frm_childSuaKM()
        {
            InitializeComponent();
        }
        public void layDanhSachKM()
        {
            DataTable tableKM = km.danhSachKhuyenMai();
            dataGridView_khuyenMai.DataSource = tableKM;
        }


        private void frm_childSuaKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            this.dangKhuyenMaiTableAdapter.Fill(this.qLNhaThuocDataSet.DangKhuyenMai);
            layDanhSachKM();

        }

        private void dataGridView_khuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maKM = textBox_maDonKM.Text;
                string tenkm = textBox_tenKhuyenMai.Text;
                string ngaybd = dateTimePicker_ngayBatDau.Value.ToString("yyyy/MM/dd"); ;
                string ngaykt = dateTimePicker_ngayKetThuc.Value.ToString("yyyy/MM/dd"); ;
                string sl = textBox_soLuong.Text;
                string dangkm = comboBox_dangKhuyenMai.Text;

                if (maKM.Length <= 0) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO LỖI ");
                else
                {
                    if (sl.Length <= 0) sl = "0";
                    km.suaKhuyenMai(tenkm, ngaybd, ngaykt, sl, dangkm,maKM);

                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_dangKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dangKhuyenMaiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox_soLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tenKhuyenMai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ngayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ngayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_maDonKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
