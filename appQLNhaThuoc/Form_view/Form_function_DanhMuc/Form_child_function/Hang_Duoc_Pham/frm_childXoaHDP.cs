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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham
{
    public partial class frm_childXoaHDP : Form
    {
        HangDuocPham hd = new HangDuocPham();
        public frm_childXoaHDP()
        {
            InitializeComponent();
        }

        private void hangDuocPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangDuocPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childXoaHDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.hangDuocPham' table. You can move, or remove it, as needed.
            this.hangDuocPhamTableAdapter.Fill(this.qLNhaThuocDataSet.hangDuocPham);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maHangDuocLabel1_Click(object sender, EventArgs e)
        {

        }

        private void maHangDuocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailHangDuocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn thoát", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void hangDuocPhamDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maXoa = maHangDuocTextBox.Text;
                if (maXoa.Length <= 0 || maXoa == null) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                  if(MessageBox.Show("bạn có chắc muốn xóa hãng được phẩm "+tenHangDuocTextBox.Text,"THỒN BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        hd.xoaHangDuoc(maXoa);
                        MessageBox.Show("xóa thông tin thành công", "THÔNG BÁO");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }
    }
}
