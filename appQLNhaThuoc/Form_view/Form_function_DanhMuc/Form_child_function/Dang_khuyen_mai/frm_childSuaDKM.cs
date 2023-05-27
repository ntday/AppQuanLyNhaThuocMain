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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Dang_khuyen_mai
{
    public partial class frm_childSuaDKM : Form
    {
        DangKhuyenMai dkm = new DangKhuyenMai();
        public frm_childSuaDKM()
        {
            InitializeComponent();
        }

        private void dangKhuyenMaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangKhuyenMaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaDKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            this.dangKhuyenMaiTableAdapter.Fill(this.qLNhaThuocDataSet.DangKhuyenMai);

        }

        private void tenDangKMLabel_Click(object sender, EventArgs e)
        {

        }

        private void tenDangKMTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string masua = maDangKMTextBox.Text;
                string tend = tenDangKMTextBox.Text;
                string giam = giamGiaTextBox.Text;
                string qua = quaTangTextBox.Text;
                if (tend.Length <= 0 && (giam.Length <= 0 || qua.Length <= 0)) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO");
                else
                {
                    if (giam.Length <= 0) giam = "0";
                    else if (qua.Length <= 0) qua = "";
                    dkm.suaDangKM(tend, giam, qua, masua);
                    MessageBox.Show("sửa thành công dạng khuyến mãi", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không sát định "+err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }
    }
}
