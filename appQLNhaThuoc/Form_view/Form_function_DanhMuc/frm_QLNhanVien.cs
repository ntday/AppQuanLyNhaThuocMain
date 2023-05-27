using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhan_Vien;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_QLNhanVien : Form
    {

        NhanVien nv = new NhanVien();
        User us = new User();
        string quyenHangUser;
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }

        public void layDanhSachNV()
        {
            DataTable tableNV = nv.layDanhSachNhanVien();
            dataGridViewNhanVien.DataSource = tableNV;
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            layDanhSachNV();

            string tenDN = Properties.Settings.Default.UserName;
            quyenHangUser = us.layQuyenHangUserTheoTenDN(tenDN);
            if (quyenHangUser == "user" || quyenHangUser == "User")  panel1.Enabled = false;

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemNV frmThemNV = new frm_childThemNV();
            frmThemNV.ShowDialog();
            layDanhSachNV();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaNV frmSuaNV = new frm_childSuaNV();
            frmSuaNV.ShowDialog();
            layDanhSachNV();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaNV frmXoaNV = new frm_childXoaNV();
            frmXoaNV.ShowDialog();
            layDanhSachNV();
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
