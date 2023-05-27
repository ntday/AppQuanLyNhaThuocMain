using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Thuoc_child;
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

namespace appQLNhaThuoc.Form_view.Form_function
{

    public partial class frm_QlThuoc : Form
    {
        Thuoc thuoc = new Thuoc();
        public frm_QlThuoc()
        {
            InitializeComponent();
        }

        public void layDanhSachThuoc()
        {
            dataGridView_thuoc.DataSource = thuoc.layDanhSachThuoc();
        }
        private void frm_QlThuoc_Load(object sender, EventArgs e)
        {
            layDanhSachThuoc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemThuo frmThemThuoc = new frm_childThemThuo();
            if (frmThemThuoc.ShowDialog() == DialogResult.OK) layDanhSachThuoc();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaThuoc frmSuaThuoc = new frm_childSuaThuoc();
            if (frmSuaThuoc.ShowDialog() == DialogResult.OK) layDanhSachThuoc();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaThuoc frmXoaThuoc = new frm_childXoaThuoc();
            if (frmXoaThuoc.ShowDialog() == DialogResult.OK) layDanhSachThuoc();
        }
    }
}
