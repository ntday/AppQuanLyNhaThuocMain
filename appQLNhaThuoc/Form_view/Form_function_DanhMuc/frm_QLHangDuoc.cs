using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_QLHangDuoc : Form
    {
        HangDuocPham hd = new HangDuocPham();
        public frm_QLHangDuoc()
        {
            InitializeComponent();
        }

        private void hangDuocPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            hangDuocPhamBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }
        public void layDanhSachHangDuoc()
        {
            DataTable tableHD = hd.layDanhSachHangDuoc();
            hangDuocPhamDataGridView.DataSource = tableHD;
        }
        private void frm_QLHangDuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.hangDuocPham' table. You can move, or remove it, as needed.
            hangDuocPhamTableAdapter.Fill(qLNhaThuocDataSet.hangDuocPham);

        }

        private void hangDuocPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemHDP frmThemHDP = new frm_childThemHDP();
            if (frmThemHDP.ShowDialog() == DialogResult.OK) layDanhSachHangDuoc();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaHDP frmSuaHDP = new frm_childSuaHDP();
            if (frmSuaHDP.ShowDialog() == DialogResult.OK) layDanhSachHangDuoc();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaHDP frmXoaHDP = new frm_childXoaHDP();
            if (frmXoaHDP.ShowDialog() == DialogResult.OK) layDanhSachHangDuoc();
        }
    }
}
