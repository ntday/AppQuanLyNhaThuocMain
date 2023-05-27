using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_QLLoThuoc : Form
    {
        LoThuoc lt = new LoThuoc();
        public frm_QLLoThuoc()
        {
            InitializeComponent();
        }

        public void layDanhSachLoThuoc()
        {
            DataTable tableLT = lt.layDanhSachLoThuoc();
            dataGridView_loThuoc.DataSource = tableLT;
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaLT frmXoaLT = new frm_childXoaLT();
            if (frmXoaLT.ShowDialog() == DialogResult.OK) layDanhSachLoThuoc();
        }

        private void frm_QLLoThuoc_Load(object sender, EventArgs e)
        {
            layDanhSachLoThuoc();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemLT frmThemLT = new frm_childThemLT();
            if (frmThemLT.ShowDialog() == DialogResult.OK) layDanhSachLoThuoc();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaLT frmSuaLT = new frm_childSuaLT();
            if (frmSuaLT.ShowDialog() == DialogResult.OK) layDanhSachLoThuoc();
        }
    }
}
