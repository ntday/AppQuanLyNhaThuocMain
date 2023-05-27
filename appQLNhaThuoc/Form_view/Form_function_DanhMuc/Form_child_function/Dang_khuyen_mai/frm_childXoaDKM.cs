using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Dang_khuyen_mai
{
    public partial class frm_childXoaDKM : Form
    {
        DangKhuyenMai dkm = new DangKhuyenMai();
        public frm_childXoaDKM()
        {
            InitializeComponent();
        }

        private void dangKhuyenMaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            dangKhuyenMaiBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }
        public void layDanhSachDangkhuyenMai()
        {
            DataTable tableDKM = dkm.layDanhSachDangKM();
            dangKhuyenMaiDataGridView.DataSource = tableDKM;
        }
        private void frm_childXoaDKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            dangKhuyenMaiTableAdapter.Fill(qLNhaThuocDataSet.DangKhuyenMai);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string max = maDangKMTextBox.Text;
                string ten = tenDangKMTextBox.Text;
                DialogResult ch = MessageBox.Show("đồng ý xóa vĩ viễn dạng khuyến mãi " + ten, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ch == DialogResult.Yes)
                {
                    dkm.xoaDangKM(max);
                    MessageBox.Show("xóa thành công dạng khuyến mãi", "THÔNG BÁO");

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
