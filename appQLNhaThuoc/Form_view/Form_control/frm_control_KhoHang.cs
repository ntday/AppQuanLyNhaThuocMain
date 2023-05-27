using appQLNhaThuoc.Form_view.Form_function_KhoHang;
using System;
using System.Linq;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_control
{
    public partial class frm_control_KhoHang : Form
    {


        public frm_control_KhoHang()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

            frm_QLNhapKho frmNhapKho = new frm_QLNhapKho();
            if (Application.OpenForms.OfType<frm_QLNhapKho>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmNhapKho.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmNhapKho.Show();
            }
        }

        private void frm_control_KhoHang_Load(object sender, EventArgs e)
        {

        }

        private void vbButton8_Click(object sender, EventArgs e)
        {
            frm_QLXuatKho frmXuatKho = new frm_QLXuatKho();
            if (Application.OpenForms.OfType<frm_QLXuatKho>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmXuatKho.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmXuatKho.Show();
            }
        }



        private void vbButton4_Click(object sender, EventArgs e)
        {
            frm_QLTinhTrangHang frmTinhTrangHang = new frm_QLTinhTrangHang();
            if (Application.OpenForms.OfType<frm_QLTinhTrangHang>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmTinhTrangHang.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmTinhTrangHang.Show();
            }
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

            frm_QLPhieuNhap frmPhieuNhap = new frm_QLPhieuNhap();
            if (Application.OpenForms.OfType<frm_QLPhieuNhap>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmPhieuNhap.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmPhieuNhap.Show();
            }
        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            frm_QLPhieuXuat frmPhieuXuat = new frm_QLPhieuXuat();
            if (Application.OpenForms.OfType<frm_QLPhieuXuat>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmPhieuXuat.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmPhieuXuat.Show();
            }
        }
    }
}
