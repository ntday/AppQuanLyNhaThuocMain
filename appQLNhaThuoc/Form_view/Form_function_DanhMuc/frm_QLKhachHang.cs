using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang;
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
    public partial class frm_QLKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        public frm_QLKhachHang()
        {
            InitializeComponent();
        }

        public void layDanhSachKhachHang()
        {
            DataTable tableKH = kh.layDangSachKhachHang();
            khachHangDataGridView.DataSource = tableKH;
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_QLKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLNhaThuocDataSet.KhachHang);

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_childThemKH frmThemKH = new frm_childThemKH();
            if(frmThemKH.ShowDialog()==DialogResult.OK) layDanhSachKhachHang();

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_childSuaKH frmSuaKH = new frm_childSuaKH();
            if (frmSuaKH.ShowDialog() == DialogResult.OK) layDanhSachKhachHang();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_childXoaKH frmXoaKH = new frm_childXoaKH();
            if (frmXoaKH.ShowDialog() == DialogResult.OK) layDanhSachKhachHang();
        }
    }
}
