using appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_QLDonViTinh : Form
    {
        Obj_Model.DonViTinh dvt = new Obj_Model.DonViTinh();
        public frm_QLDonViTinh()
        {
            InitializeComponent();
        }

        public void lamMoiDanhSachDVT()
        {
            DataTable tableDVT = dvt.layDanhSachDonViTinh();
            donViTinhDataGridView.DataSource = tableDVT;
        }

        private void donViTinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            donViTinhBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_QLDonViTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.donViTinh' table. You can move, or remove it, as needed.
            donViTinhTableAdapter.Fill(qLNhaThuocDataSet.donViTinh);

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemDVT frmThemDVt = new frm_childThemDVT();
            if (frmThemDVt.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaDVT frmSuaDVt = new frm_childSuaDVT();
            if (frmSuaDVt.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaDVT frmXoaDVt = new frm_childXoaDVT();
            if (frmXoaDVt.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
