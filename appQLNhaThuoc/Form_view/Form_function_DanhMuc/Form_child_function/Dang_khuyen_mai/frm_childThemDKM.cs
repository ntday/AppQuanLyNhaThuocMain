using appQLNhaThuoc.Obj_Model;
using System;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Dang_khuyen_mai
{
    public partial class frm_childThemDKM : Form
    {
        DangKhuyenMai dkm = new DangKhuyenMai();
        public frm_childThemDKM()
        {
            InitializeComponent();
        }

        private void dangKhuyenMaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            dangKhuyenMaiBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_childThemDKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            dangKhuyenMaiTableAdapter.Fill(qLNhaThuocDataSet.DangKhuyenMai);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tend = text_tenDang.Text;
            string giam = text_giamGia.Text;
            string qua = text_quaTang.Text;
            if (tend.Length <= 0 && (giam.Length <= 0 || qua.Length <= 0)) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO");
            else
            {
                if (giam.Length <= 0) giam = "0";
                else if (qua.Length <= 0) qua = "";
                dkm.themDangKM(tend, giam, qua);
                MessageBox.Show("thêm mới dạng khuyến mãi thành công", "THÔNG BÁO");
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult ch =  MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();

        }
    }
}
