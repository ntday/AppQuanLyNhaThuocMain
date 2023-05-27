using appQLNhaThuoc.Form_view.Form_function_DanhMuc.Form_child_function.Don_Gia_Hang;
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

namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc
{

    public partial class frm_QLGiaBan : Form
    {
        GiaDonHang gb = new GiaDonHang();
        public frm_QLGiaBan()
        {
            InitializeComponent();
        }

        public void layDanhSachGia()
        {
            dataGridView_giaBan.DataSource = gb.layDanhSachGiaDonHang();
        }
        private void frm_QLGiaBan_Load(object sender, EventArgs e)
        {
            layDanhSachGia();
        }
        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemDGH frmThemGb = new frm_childThemDGH();
            if (frmThemGb.ShowDialog() == DialogResult.OK) layDanhSachGia();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaDGH frmSuaGb = new frm_childSuaDGH();
            if (frmSuaGb.ShowDialog() == DialogResult.OK) layDanhSachGia();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaDGH frmXoaGb = new frm_childXoaDGH();
            if (frmXoaGb.ShowDialog() == DialogResult.OK) layDanhSachGia();
        }

        private void dataGridView_giaBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
