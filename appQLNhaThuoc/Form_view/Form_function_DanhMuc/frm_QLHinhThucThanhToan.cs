using appQLNhaThuoc.Form_view.Form_function.Form_child_function.hinhThucThanhToan;
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
    public partial class frm_QLHinhThucThanhToan : Form
    {
        DangThanhToan dtt = new DangThanhToan();
        public frm_QLHinhThucThanhToan()
        {
            InitializeComponent();
        }

        private void dangThanhToanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dangThanhToanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_QLHinhThucThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.dangThanhToan' table. You can move, or remove it, as needed.
            this.dangThanhToanTableAdapter.Fill(this.qLNhaThuocDataSet.dangThanhToan);

        }

        public void lamMoiDanhSachDVT()
        {
            DataTable tableDtt = dtt.layDanhSachDangThanhToan();
            dangThanhToanDataGridView.DataSource = tableDtt;
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemHTTT frmThemDTT = new frm_childThemHTTT();
            if (frmThemDTT.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaHTTT frmSuaDTT = new frm_childSuaHTTT();
            if (frmSuaDTT.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaHTTT frmXoaDTT = new frm_childXoaHTTT();
            if (frmXoaDTT.ShowDialog() == DialogResult.OK) lamMoiDanhSachDVT();
            else lamMoiDanhSachDVT();
        }

        private void dangThanhToanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
