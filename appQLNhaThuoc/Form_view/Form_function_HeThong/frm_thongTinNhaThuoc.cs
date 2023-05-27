using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_thongTinNhaThuoc : Form
    {
        NhaThuoc nt = new NhaThuoc();
        bool statusNT;
        public frm_thongTinNhaThuoc()
        {
            InitializeComponent();
        }

        private void nhaThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            nhaThuocBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_thongTinNhaThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.NhaThuoc' table. You can move, or remove it, as needed.
            nhaThuocTableAdapter.Fill(qLNhaThuocDataSet.NhaThuoc);
            DataTable ntTable = nt.layThongTinNhaThuoc();
            if (ntTable.Rows.Count <= 0) statusNT = false;
            else statusNT = true;
        }

        private void nhaThuocBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void sdtNhaThuocLabel_Click(object sender, EventArgs e)
        {

        }

        private void sdtNhaThuocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themSuaNT_Click(object sender, EventArgs e)
        {
            if (statusNT == false)
            {
                string tenNT = tenNhaThuocTextBox.Text;
                string sdtNT = sdtNhaThuocTextBox.Text;
                string diaCNT = diaChiNhaThuocTextBox.Text;
                string msThue = maSoThueTextBox.Text;
                if (tenNT.Length <= 0 || sdtNT.Length <= 0 || diaCNT.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin bắt buộc", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    nt.themThongTinNhaThuoc(tenNT, sdtNT, diaCNT, msThue);
                    MessageBox.Show("thêm thành công thông tin nhà thuốc", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                string tenNT = tenNhaThuocTextBox.Text;
                string sdtNT = sdtNhaThuocTextBox.Text;
                string diaCNT = diaChiNhaThuocTextBox.Text;
                string msThue = maSoThueTextBox.Text;
                if (tenNT.Length <= 0 || sdtNT.Length <= 0 || diaCNT.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin bắt buộc", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    nt.suaThongTinNhaThuoc(tenNT, sdtNT, diaCNT, msThue);

                    MessageBox.Show("thay đổi thành công thông tin nhà thuốc ĐĂNG NHẬP LẠI ĐỂ DÙNG THÔNG TIN MỚI", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btn_thoatDongNT_Click(object sender, EventArgs e)
        {
            if (statusNT == false)
            {
                DialogResult ch = MessageBox.Show("không thể vào hệ thống nếu chưa có đủ thông tin về nhà thuốc BẠN SẺ THOÁT KHỔI CHƯƠNG TRÌNH", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); ;
                if (ch == DialogResult.OK) Application.Exit();
            }
            else
            {
                MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO");
                Close();
            }
        }
    }
}
