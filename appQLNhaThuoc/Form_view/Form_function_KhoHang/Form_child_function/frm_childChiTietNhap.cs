using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang.Form_child_function
{

    public partial class frm_childChiTietNhap : Form
    {
        PhieuNhapKho npk = new PhieuNhapKho();
        public string maphieu;
        public frm_childChiTietNhap()
        {
            InitializeComponent();
        }

        public void layDanhSachChiTietPhieuNhap()
        {
            DataTable table = npk.layDanhSachChiTietPhieuNhap(maphieu);

            string maSoLo, maThuoc, tenThuoc, tenDVT, donGia, soLuong, thanhTien;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                maSoLo = table.Rows[i]["maSoLo"].ToString();
                maThuoc = table.Rows[i]["maThuoc"].ToString();
                tenThuoc = table.Rows[i]["tenThuoc"].ToString();
                tenDVT = table.Rows[i]["tenDVT"].ToString();
                donGia = table.Rows[i]["donGia"].ToString();
                soLuong = table.Rows[i]["soLuong"].ToString();



                thanhTien = "" + (double.Parse(donGia) * int.Parse(soLuong));

                dataGridView_chiTietPhieuNhap.Rows.Add(maSoLo, maThuoc, tenThuoc, tenDVT, donGia, soLuong, thanhTien);
            }



        }

        private void frm_childChiTietNhap_Load(object sender, EventArgs e)
        {
            this.Text = "chi tiết phiếu nhập " + maphieu;
            layDanhSachChiTietPhieuNhap();
        }

        private void dataGridView_chiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
