using appQLNhaThuoc.Form_view.Form_function;
using appQLNhaThuoc.Form_view.Form_function_DanhMuc;
using System;
using System.Linq;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_control
{
    public partial class frm_control_DanhMuc : Form
    {
        public frm_control_DanhMuc()
        {
            InitializeComponent();
        }

        private void frm_control_DanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            frm_QLDonViTinh frmDVT = new frm_QLDonViTinh();

            if (Application.OpenForms.OfType<frm_QLDonViTinh>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmDVT.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmDVT.Show();
            }
        }

        private void vbButton7_Click(object sender, EventArgs e)
        {
            frm_QLHinhThucThanhToan frmDTT = new frm_QLHinhThucThanhToan();
            if (Application.OpenForms.OfType<frm_QLHinhThucThanhToan>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmDTT.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmDTT.Show();
            }
        }

        private void vbButton10_Click(object sender, EventArgs e)
        {
            frm_QLKhuyenMai frmKM = new frm_QLKhuyenMai();
            if (Application.OpenForms.OfType<frm_QLHinhThucThanhToan>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmKM.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmKM.Show();
            }
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            frm_QLKhachHang frmKH = new frm_QLKhachHang();
            if (Application.OpenForms.OfType<frm_QLKhachHang>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmKH.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmKH.Show();
            }
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            frm_QLHangDuoc frmHDP = new frm_QLHangDuoc();
            if (Application.OpenForms.OfType<frm_QLHangDuoc>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmHDP.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmHDP.Show();
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_QLNhaCungCap frmNCC = new frm_QLNhaCungCap();
            if (Application.OpenForms.OfType<frm_QLNhaCungCap>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmNCC.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmNCC.Show();
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_QLNhanVien frmNV = new frm_QLNhanVien();
            if (Application.OpenForms.OfType<frm_QLNhanVien>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmNV.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmNV.Show();
            }
        }

        private void vbButton9_Click(object sender, EventArgs e)
        {
            frm_QLLoThuoc frmLoHang = new frm_QLLoThuoc();
            if (Application.OpenForms.OfType<frm_QLLoThuoc>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmLoHang.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmLoHang.Show();
            }
        }

        private void vbButton8_Click(object sender, EventArgs e)
        {
            frm_QLNhomThuoc frmNhomThuoc = new frm_QLNhomThuoc();
            if (Application.OpenForms.OfType<frm_QLNhomThuoc>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmNhomThuoc.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmNhomThuoc.Show();
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_QlThuoc frmThuoc = new frm_QlThuoc();
            if (Application.OpenForms.OfType<frm_QlThuoc>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmThuoc.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmThuoc.Show();
            }
        }

        private void vbButton11_Click(object sender, EventArgs e)
        {
            frm_QLGiaBan frmGiaBan = new frm_QLGiaBan();
            if (Application.OpenForms.OfType<frm_QLGiaBan>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmGiaBan.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmGiaBan.Show();
            }
        }
    }
}
