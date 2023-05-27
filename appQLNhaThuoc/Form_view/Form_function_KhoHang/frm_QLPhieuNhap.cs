using appQLNhaThuoc.Form_view.Form_function_KhoHang.Form_child_function;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    public partial class frm_QLPhieuNhap : Form
    {
        private string maSua;
        PhieuNhapKho pnk = new PhieuNhapKho();
        public frm_QLPhieuNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButtonToDataGridView()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView_phieuNhap.Columns.Add(btn);
            //btn.HeaderText = "Click Data";
            btn.Text = "xem chi tiết";
            //btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }




        private void layDanhSachPhieuNhapDaFormat()
        {

            DataTable dt = pnk.layDanhSachPhieuNhapFormat();

            dataGridView_phieuNhap.DataSource = dt;



            comboBox_maPhieu.DataSource = dt;
            comboBox_maPhieu.DisplayMember = "maPNT";
            comboBox_maPhieu.ValueMember = "maPNT";

            comboBox_nhaCungCap.DataSource = dt;
            comboBox_nhaCungCap.DisplayMember = "tenNhaCungCap";
            comboBox_nhaCungCap.ValueMember = "tenNhaCungCap";

            comboBox_nhanVien.DataSource = dt;
            comboBox_nhanVien.DisplayMember = "hoVaTen";
            comboBox_nhanVien.ValueMember = "hoVaTen";

            //dateTimePicker_ngayLap.DataSource = dt;
        }

        private void layMaPhieuNhap()
        {
            DataTable table = pnk.layDanhSachPhieuNhapFormat();
            comboBox_maPhieu.DataSource = table;
            comboBox_maPhieu.DisplayMember = "maPNT";
            comboBox_maPhieu.ValueMember = "maPNT";
        }

        private void layTenNhaCungCap()
        {
            DataTable table = pnk.layDanhSachPhieuNhapFormat();
            comboBox_nhaCungCap.DataSource = table;
            comboBox_nhaCungCap.DisplayMember = "tenNhaCungCap";
            comboBox_nhaCungCap.ValueMember = "tenNhaCungCap";
        }
        private void layTenNhanVien()
        {
            DataTable table = pnk.layDanhSachPhieuNhapFormat();
            comboBox_nhanVien.DataSource = table;
            comboBox_nhanVien.DisplayMember = "hoVaTen";
            comboBox_nhanVien.ValueMember = "hoVaTen";
        }
        private void frm_QLPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.phieuNhapThuoc' table. You can move, or remove it, as needed.
            phieuNhapThuocTableAdapter.Fill(qLNhaThuocDataSet.phieuNhapThuoc);
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.chiTietKho' table. You can move, or remove it, as needed.
            chiTietKhoTableAdapter.Fill(qLNhaThuocDataSet.chiTietKho);
            //AddButtonToDataGridView();
            layDanhSachPhieuNhapDaFormat();
            layMaPhieuNhap();
            layTenNhaCungCap();
            layTenNhanVien();
            button1.Enabled = false;
        }

        private void comboBox_maPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string maPhieu = maSua;
            frm_childChiTietNhap frmChiTietPhieuNhap = new frm_childChiTietNhap();
            frmChiTietPhieuNhap.maphieu = maPhieu;
            frmChiTietPhieuNhap.ShowDialog();
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
                row = dataGridView_phieuNhap.Rows[e.RowIndex];
                maSua = Convert.ToString(row.Cells["maPNT"].Value);
                button1.Text = "xem chi tiết phiếu nhập: " + Convert.ToString(row.Cells["maPNT"].Value);

            }


        }

        private void dataGridView_phieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
