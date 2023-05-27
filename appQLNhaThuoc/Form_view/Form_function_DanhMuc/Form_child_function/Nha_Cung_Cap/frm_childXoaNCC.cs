using appQLNhaThuoc.Obj_Model;
using System;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    public partial class frm_childXoaNCC : Form
    {
        NhaCungCap ncc = new NhaCungCap();
        public frm_childXoaNCC()
        {
            InitializeComponent();
        }

        private void nhaCungCapThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            nhaCungCapThuocBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_childXoaNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhaCungCapThuoc' table. You can move, or remove it, as needed.
            nhaCungCapThuocTableAdapter.Fill(qLNhaThuocDataSet.nhaCungCapThuoc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maXoa = maNhaCungCapTextBox.Text;

                if (maXoa.Length <= 0 || maXoa == null) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                    ncc.xoaNhaCungCap(maXoa);
                    MessageBox.Show("xóa thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maNhaCungCapTextBox.Text.Length > 0 || tenNhaCungCapTextBox.Text.Length > 0 || diaChiNhaCungCapTextBox.Text.Length > 0 || sdtNhaCungCapTextBox.Text.Length > 0 || emailNhaCungCapTextBox.Text.Length > 0)
            {
                DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ch == DialogResult.Yes) Close();

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
