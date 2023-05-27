using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh
{
    public partial class frm_childSuaDVT : Form
    {
        Obj_Model.DonViTinh dvt = new Obj_Model.DonViTinh();
        public frm_childSuaDVT()
        {
            InitializeComponent();
        }

        private void donViTinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donViTinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaDVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.donViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.qLNhaThuocDataSet.donViTinh);

        }

        private void donViTinhDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void lamMoiDanhSachDVT()
        {
            DataTable tableDVT = dvt.layDanhSachDonViTinh();
            donViTinhDataGridView.DataSource = tableDVT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maDVTC = maDVTTextBox.Text;
                string tenDVTm = tenDVTTextBox.Text;
                string moTaDVTn = moTaDVTTextBox.Text;
                if(tenDVTm.Length<=0) MessageBox.Show("chưa nhập tên đơn vị tính", "THÔNG BÁO LỖI");
                else
                {
                    dvt.suaDonViTinh(tenDVTm, moTaDVTn, maDVTC);
                    MessageBox.Show("cập nhật thành công đơn vị tính ", "THÔNG BÁO");
                    lamMoiDanhSachDVT();
                    DialogResult = DialogResult.OK;

                }

            }
            catch(Exception err)
            {
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void maDVTTextBox_TextChanged(object sender, EventArgs e)
        {

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
