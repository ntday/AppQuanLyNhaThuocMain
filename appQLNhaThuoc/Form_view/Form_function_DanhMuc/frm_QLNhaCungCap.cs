using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_QLNhaCungCap : Form
    {
        NhaCungCap ncc = new NhaCungCap();

        public frm_QLNhaCungCap()
        {
            InitializeComponent();
        }

        public void layDanhSachNcc()
        {
            DataTable tableNCC = ncc.layDanhSachNhaCungCap();
            nhaCungCapThuocDataGridView.DataSource = tableNCC;
        }
        private void nhaCungCapThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            nhaCungCapThuocBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_QLNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhaCungCapThuoc' table. You can move, or remove it, as needed.
            nhaCungCapThuocTableAdapter.Fill(qLNhaThuocDataSet.nhaCungCapThuoc);

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemNCC frmThemNCC = new frm_childThemNCC();
            if (frmThemNCC.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaNCC frmSuaNCC = new frm_childSuaNCC();
            if (frmSuaNCC.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaNCC frmXoaNCC = new frm_childXoaNCC();
            if (frmXoaNCC.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }
    }
}
