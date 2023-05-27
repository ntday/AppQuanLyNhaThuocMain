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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang
{
    public partial class frm_childSuaKH : Form
    {
        KhachHang kh = new KhachHang();
        string maSua;
        public frm_childSuaKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLNhaThuocDataSet.KhachHang);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sdtKHTextBox.Text.Length > 0 || hoHoLotKHTextBox.Text.Length > 0 || tenKHTextBox.Text.Length > 0 || namSinhTextBox.Text.Length > 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string suaSDT = sdtKHTextBox.Text;
                string tenkh = tenKHTextBox.Text;
                string holot = hoHoLotKHTextBox.Text;
                string nanSinhKH = namSinhTextBox.Text;

                if (maSua.Length <= 0) { MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO"); }
                else
                {
                    kh.suaKhachHang(suaSDT, holot, tenkh, nanSinhKH, maSua);
                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void khachHangDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = khachHangDataGridView.Rows[e.RowIndex];

            maSua = Convert.ToString(row.Cells["sdtKH"].Value);
        }

        private void khachHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
