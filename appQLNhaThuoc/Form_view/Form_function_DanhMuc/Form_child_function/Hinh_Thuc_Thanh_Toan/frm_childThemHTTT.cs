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
    public partial class frm_childThemHTTT : Form
    {
        DangThanhToan dtt = new DangThanhToan();
        public frm_childThemHTTT()
        {
            InitializeComponent();
        }

        private void dangThanhToanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangThanhToanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childThemHTTT_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string tenD = text_tenDangThanhT.Text;
                string tenNH = text_tenTaiKhoangTT.Text;
                string sdt = text_stkThanhToan.Text;

                if(tenD.Length<=0) MessageBox.Show("chưa nhập đủ thông tin","THÔNG BÁO LỖI");
                else
                {
                    dtt.themDangThanhToanMoi(tenD, tenNH, sdt);
                    MessageBox.Show("Thêm thành công dạng thanh toán mới", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                    Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không sát định " + err, "THÔNG BÁO LỖI");
            }
        }
    }
}
