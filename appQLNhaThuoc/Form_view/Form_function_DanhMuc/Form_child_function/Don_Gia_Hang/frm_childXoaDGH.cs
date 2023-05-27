using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc.Form_child_function.Don_Gia_Hang
{
    public partial class frm_childXoaDGH : Form
    {
        public frm_childXoaDGH()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void giaDonHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }
    }
}
