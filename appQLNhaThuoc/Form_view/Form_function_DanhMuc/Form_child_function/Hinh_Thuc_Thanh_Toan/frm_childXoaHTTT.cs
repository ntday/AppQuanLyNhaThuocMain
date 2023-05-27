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
    public partial class frm_childXoaHTTT : Form
    {
        DangThanhToan dtt = new DangThanhToan();
        public frm_childXoaHTTT()
        {
            InitializeComponent();
        }

        private void dangThanhToanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangThanhToanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childXoaHTTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.dangThanhToan' table. You can move, or remove it, as needed.
            this.dangThanhToanTableAdapter.Fill(this.qLNhaThuocDataSet.dangThanhToan);

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

        private void soTaiKhoangTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maDangTTLabel_Click(object sender, EventArgs e)
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

                string maX = maDangTTTextBox.Text;
                string tenDan = tenDangTTTextBox.Text;
                if (maX.Length <= 0) MessageBox.Show("chưa chọn thông tin để xóa", "THÔNG BÁO LỖI");
                else
                {
                    DialogResult ch = MessageBox.Show("đồng ý xóa dạng thanh toán " + tenDan, "THÔNG BÁO", MessageBoxButtons.YesNo);
                    if(ch == DialogResult.Yes)
                    {
                        dtt.xoaDangThanhToan(maX);
                        MessageBox.Show("xóa thành công dạng thanh toán "+tenDan, "THÔNG BÁO");
                        lamMoiDanhSachDVT();
                        DialogResult = DialogResult.OK;

                    }
                }

            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi chưa sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
