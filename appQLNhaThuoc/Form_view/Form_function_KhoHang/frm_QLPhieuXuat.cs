using appQLNhaThuoc.Form_view.Form_function_KhoHang.Form_child_function;
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

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    public partial class frm_QLPhieuXuat : Form
    {
        private string maSua;
        PhieuXuatKho pxk = new PhieuXuatKho();

        public frm_QLPhieuXuat()
        {
            InitializeComponent();
        }


        private void AddButtonToDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView_phieuXuat.Columns.Add(btn);
            //btn.HeaderText = "Click Data";
            btn.Text = "xem chi tiết";
            //btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void layDanhSachPhieuXuatFormat()
        {

            DataTable dt = pxk.layDanhSachPhieuXuatFormat();

            dataGridView_phieuXuat.DataSource = dt;



            comboBox_maPhieu.DataSource = dt;
            comboBox_maPhieu.DisplayMember = "maPXT";
            comboBox_maPhieu.ValueMember = "maPXT";

            comboBox_nhaCungCap.DataSource = dt;
            comboBox_nhaCungCap.DisplayMember = "tenNhaCungCap";
            comboBox_nhaCungCap.ValueMember = "tenNhaCungCap";

            comboBox_nhanVien.DataSource = dt;
            comboBox_nhanVien.DisplayMember = "hoVaTen";
            comboBox_nhanVien.ValueMember = "hoVaTen";

            //dateTimePicker_ngayLap.DataSource = dt;
        }

        private void layMaPhieuXuat()
        {
            DataTable table = pxk.layDanhSachPhieuXuatFormat();
            comboBox_maPhieu.DataSource = table;
            comboBox_maPhieu.DisplayMember = "maPXT";
            comboBox_maPhieu.ValueMember = "maPXT";
        }

        private void layTenNhaCungCap()
        {
            DataTable table = pxk.layDanhSachPhieuXuatFormat();
            comboBox_nhaCungCap.DataSource = table;
            comboBox_nhaCungCap.DisplayMember = "tenNhaCungCap";
            comboBox_nhaCungCap.ValueMember = "tenNhaCungCap";
        }
        private void layTenNhanVien()
        {
            DataTable table = pxk.layDanhSachPhieuXuatFormat();
            comboBox_nhanVien.DataSource = table;
            comboBox_nhanVien.DisplayMember = "hoVaTen";
            comboBox_nhanVien.ValueMember = "hoVaTen";
        }

        private void frm_QLPhieuXuat_Load(object sender, EventArgs e)
        {
            layDanhSachPhieuXuatFormat();
            layMaPhieuXuat();
            layTenNhaCungCap();
            layTenNhanVien();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maPhieu = maSua;
            frm_childChiTietXuat frmChiTietPhieuXuat = new frm_childChiTietXuat();
            frmChiTietPhieuXuat.maphieu = maPhieu;
            frmChiTietPhieuXuat.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView_phieuXuat.Rows[e.RowIndex];
                maSua = Convert.ToString(row.Cells["maPXT"].Value);
                button1.Text = "xem chi tiết phiếu xuất: " + Convert.ToString(row.Cells["maPXT"].Value);

            }
        }
    }
}
