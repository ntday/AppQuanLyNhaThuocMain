using appQLNhaThuoc.Obj_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc.Form_child_function.Don_Gia_Hang
{
    public partial class frm_childSuaDGH : Form
    {
        GiaDonHang gb = new GiaDonHang();
        Thuoc thuoc = new Thuoc();
        string maSua;
        public frm_childSuaDGH()
        {
            InitializeComponent();
        }

        public void layDanhSachGia()
        {
            dataGridView_giaBan.DataSource = gb.layDanhSachGiaDonHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maTh = comboBox_maThuoc.Text;
                string tenTh = comboBox_tenThuoc.Text;
                string gia = textBox_giaBan.Text;
                string ghiCh = textBox_ghiChu.Text;
                if (maSua.Length <= 0) MessageBox.Show("chưa chọn thuốc", "THÔNG BÁO LỖI");
                else
                {
                    gb.suaGiaDonHangh(maTh,gia,ghiCh,maSua);
                    MessageBox.Show("cập nhật thành công giá bán", "THÔNG BÁO");
                    layDanhSachGia();
                }

            }
            catch (Exception err)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }

        }

        public void layMaThuocVStenThuoc()
        {
            DataTable dt = thuoc.layDanhSachThuoc();
            comboBox_maThuoc.DataSource = dt;
            comboBox_maThuoc.DisplayMember = "maThuoc";
            comboBox_maThuoc.ValueMember = "maThuoc";

            comboBox_tenThuoc.DataSource = dt;
            comboBox_tenThuoc.DisplayMember = "tenThuoc";
            comboBox_tenThuoc.ValueMember = "tenThuoc";
        }

        public void layGiaNhapThuoc(string MaThuoc)
        {

            textBox_giaNhap.Text = gb.layGiaNhap(MaThuoc);
        }

        private void frm_childSuaDGH_Load(object sender, EventArgs e)
        {
            layDanhSachGia();
            layMaThuocVStenThuoc();
        }

        private void dataGridView_giaBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_giaBan.Rows[e.RowIndex];

            //maSua = comboBox_maThuoc.Text = Convert.ToString(row.Cells["maThuoc"].Value);
            maSua  = Convert.ToString(row.Cells["maThuoc"].Value);
            comboBox_maThuoc.Text = Convert.ToString(row.Cells["maThuoc"].Value);
            //comboBox_tenThuoc.Text = Convert.ToString(row.Cells["tenThuoc"].Value);
            textBox_giaBan.Text = Convert.ToString(row.Cells["donGiaBan"].Value);
            textBox_ghiChu.Text = Convert.ToString(row.Cells["ghiChu"].Value);
        }

        private void textBox_phanTramLoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaBan_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_giaBan.Text, out double donGia))
            {
                textBox_giaBan.Text = donGia.ToString("N0");
                textBox_giaBan.SelectionStart = textBox_giaBan.Text.Length;
            }
        }

        private void textBox_giaNhap_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_giaBan.Text, out double donGia))
            {
                textBox_giaBan.Text = donGia.ToString("N0");
                textBox_giaBan.SelectionStart = textBox_giaBan.Text.Length;
            }
        }
        public static double TinhGiaBan(double giaNhap, double phanTramLoiNhuan)
        {
            return giaNhap * (1 + phanTramLoiNhuan / 100);
        }
        private void textBox_giaBan_Click(object sender, EventArgs e)
        {
            //Giá bán = Giá nhập x(1 + 5 %)
            double giaBan, giaNhap;
            int phanTram;
            if (textBox_phanTramLoi.Text.Length <= 0)
            {
                phanTram = 1;
            }
            else
            {
                phanTram = int.Parse(textBox_phanTramLoi.Text);
            }

            giaNhap = double.Parse(textBox_giaNhap.Text);

            giaBan = TinhGiaBan(giaNhap, phanTram);
            textBox_giaBan.Text = "" + giaBan;
        }

        private void textBox_giaNhap_Click(object sender, EventArgs e)
        {
            layGiaNhapThuoc(comboBox_maThuoc.Text);
        }

        private void dataGridView_giaBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
