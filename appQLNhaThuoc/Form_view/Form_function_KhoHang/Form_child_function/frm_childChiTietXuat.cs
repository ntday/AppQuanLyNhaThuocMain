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

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang.Form_child_function
{
    public partial class frm_childChiTietXuat : Form
    {
        PhieuXuatKho xpk = new PhieuXuatKho();
        public string maphieu;
        public frm_childChiTietXuat()
        {
            InitializeComponent();
        }
        public void layDanhSachChiTietPhieuXuat()
        {
            DataTable table = xpk.layDanhSachChiTietPhieuXuat(maphieu);
            string maSoLo, maThuoc, tenThuoc, tenDVT, donGia, soLuong, thanhTien, lyDo;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                maSoLo = table.Rows[i]["maSoLo"].ToString();
                maThuoc = table.Rows[i]["maThuoc"].ToString();
                tenThuoc = table.Rows[i]["tenThuoc"].ToString();
                tenDVT = table.Rows[i]["tenDVT"].ToString();
                donGia = table.Rows[i]["donGia"].ToString();
                soLuong = table.Rows[i]["soLuong"].ToString();
                lyDo = table.Rows[i]["lyDo"].ToString();


                thanhTien = "" + (double.Parse(donGia) * int.Parse(soLuong));

                dataGridView_chiTietPhieuXuat.Rows.Add(maSoLo, maThuoc, tenThuoc, donGia, soLuong, tenDVT, thanhTien, lyDo);
            }
        }
        private void frm_childChiTietXuat_Load(object sender, EventArgs e)
        {
            this.Text = "chi tiết phiếu xuất " + maphieu;
            layDanhSachChiTietPhieuXuat();
        }

        private void dataGridView_chiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
