using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai;
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
    public partial class frm_QLKhuyenMai : Form
    {
        KhuyenMai km = new KhuyenMai();
        public frm_QLKhuyenMai()
        {
            InitializeComponent();
        }

        public void layDanhSachKM()
        {
            DataTable tableKM = km.danhSachKhuyenMai();
            dataGridView_khuyenMai.DataSource = tableKM;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_QLKhuyenMai_Load(object sender, EventArgs e)
        {
            layDanhSachKM();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            frm_QLDangKhuyenMai frmDKM = new frm_QLDangKhuyenMai();
            if (Application.OpenForms.OfType<frm_QLDangKhuyenMai>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmDKM.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmDKM.Show();
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemKM frmThemKM = new frm_childThemKM();
            if(frmThemKM.ShowDialog()== DialogResult.OK) layDanhSachKM();

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaKM frmSuaKM = new frm_childSuaKM();
            if (frmSuaKM.ShowDialog() == DialogResult.OK) layDanhSachKM();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaKM frmXoaKM = new frm_childXoaKM();
            if (frmXoaKM.ShowDialog() == DialogResult.OK) layDanhSachKM();
        }
    }
}
