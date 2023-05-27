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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.hinhThucThanhToan
{
    public partial class frm_childSuaHTTT : Form
    {
        DangThanhToan dtt = new DangThanhToan();
        public frm_childSuaHTTT()
        {
            InitializeComponent();
        }

        private void dangThanhToanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangThanhToanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaHTTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.dangThanhToan' table. You can move, or remove it, as needed.
            this.dangThanhToanTableAdapter.Fill(this.qLNhaThuocDataSet.dangThanhToan);

        }

        private void soTaiKhoangLabel_Click(object sender, EventArgs e)
        {

        }

        private void soTaiKhoangTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void lamMoiDanhSachDVT()
        {
            DataTable tableDtt = dtt.layDanhSachDangThanhToan();
            dangThanhToanDataGridView.DataSource = tableDtt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mad = maDangTTTextBox.Text;
                string tend = tenDangTTTextBox.Text;
                string tennh = tenNganHangTextBox.Text;
                string stk = soTaiKhoangTextBox.Text;

                dtt.suaDangThanhToan(tend, tennh, stk, mad);
                MessageBox.Show("cập nhật thành công ", "THÔNG BÁO");
                lamMoiDanhSachDVT();
                DialogResult = DialogResult.OK;


            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
