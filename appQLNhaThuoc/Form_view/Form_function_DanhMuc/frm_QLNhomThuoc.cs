using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhom_thuoc;
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
    public partial class frm_QLNhomThuoc : Form
    {
        NhomThuoc nt = new NhomThuoc();
        public frm_QLNhomThuoc()
        {
            InitializeComponent();
        }

        public void layDanhSachNcc()
        {
            DataTable tableNCC = nt.layDanhSachNhomThuoc();
            nhomThuocDataGridView.DataSource = tableNCC;
        }

        private void nhomThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomThuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_QLNhomThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhomThuoc' table. You can move, or remove it, as needed.
            this.nhomThuocTableAdapter.Fill(this.qLNhaThuocDataSet.nhomThuoc);

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemNT frmThemNT = new frm_childThemNT();
            if (frmThemNT.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaNT frmSuaNT = new frm_childSuaNT();
            if (frmSuaNT.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaNT frmXoaNT = new frm_childXoaNT();
            if (frmXoaNT.ShowDialog() == DialogResult.OK) layDanhSachNcc();
        }
    }
}
