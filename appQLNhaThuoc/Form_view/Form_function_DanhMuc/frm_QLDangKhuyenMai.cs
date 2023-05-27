using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Dang_khuyen_mai;
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
    public partial class frm_QLDangKhuyenMai : Form
    {
        DangKhuyenMai dkm = new DangKhuyenMai();
        public frm_QLDangKhuyenMai()
        {
            InitializeComponent();
        }

        public void layDanhSachDangkhuyenMai()
        {
            DataTable tableDKM = dkm.layDanhSachDangKM();
            dangKhuyenMaiDataGridView.DataSource = tableDKM;
        }
        private void dangKhuyenMaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangKhuyenMaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_QLDangKhuyenMai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            this.dangKhuyenMaiTableAdapter.Fill(this.qLNhaThuocDataSet.DangKhuyenMai);

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemDKM frmThemDKM = new frm_childThemDKM();
            if (frmThemDKM.ShowDialog() == DialogResult.OK) layDanhSachDangkhuyenMai();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaDKM frmSuaDKM =new frm_childSuaDKM();
            if (frmSuaDKM.ShowDialog() == DialogResult.OK) layDanhSachDangkhuyenMai();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaDKM frmXoaDKM = new frm_childXoaDKM();
            if (frmXoaDKM.ShowDialog() == DialogResult.OK) layDanhSachDangkhuyenMai();
        }
    }
}
