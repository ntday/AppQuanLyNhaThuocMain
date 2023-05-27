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
    public partial class frm_childSuaHDP : Form
    {
        HangDuocPham hd = new HangDuocPham();
        string maSua;
        public frm_childSuaHDP()
        {
            InitializeComponent();
        }

        private void hangDuocPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangDuocPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaHDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.hangDuocPham' table. You can move, or remove it, as needed.
            this.hangDuocPhamTableAdapter.Fill(this.qLNhaThuocDataSet.hangDuocPham);

        }

        private void button2_Click(object sender, EventArgs e)
        {
                DialogResult ch = MessageBox.Show("Bạn có chắc muốn thoát", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ch == DialogResult.Yes) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = maHangDuocTextBox.Text;
                string tenhd = tenHangDuocTextBox.Text;
                string sdthd = sdtHangDuocTextBox.Text;
                string emailhd = emailHangDuocTextBox.Text;
                string diaChihd = diaChiHangDuocTextBox.Text;
                if (maSua is null ||maSua.Length <= 0) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                    hd.suaHangDuoc(mahd, tenhd, sdthd, emailhd, diaChihd, maSua);
                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void hangDuocPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hangDuocPhamDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void hangDuocPhamDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = hangDuocPhamDataGridView.Rows[e.RowIndex];

            maSua = Convert.ToString(row.Cells["maHangDuoc"].Value);

        }

        private void hangDuocPhamDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
