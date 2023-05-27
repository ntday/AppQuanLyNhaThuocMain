using appQLNhaThuoc.Form_view.Form_function;
using appQLNhaThuoc.Form_view.Form_function_HeThong;
using System;
using System.Linq;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_control
{
    public partial class frm_control_HeThong : Form
    {
        frm_thongTinNhaThuoc frmTTNhaThuoc = new frm_thongTinNhaThuoc();
        public frm_control_HeThong()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frmTTNhaThuoc.ShowDialog();

        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

            frm_QLNhatKyHeThong frmQLNhatKyHeThong = new frm_QLNhatKyHeThong();
            if (Application.OpenForms.OfType<frm_QLHangDuoc>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmQLNhatKyHeThong.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmQLNhatKyHeThong.Show();
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

            frm_sauLuuDL frmSLDL = new frm_sauLuuDL();
            if (Application.OpenForms.OfType<frm_sauLuuDL>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmSLDL.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmSLDL.Show();
            }
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            frm_phucHoiDL frmPHDL = new frm_phucHoiDL();
            if (Application.OpenForms.OfType<frm_phucHoiDL>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmPHDL.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmPHDL.Show();
            }
        }

        private void frm_control_HeThong_Load(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            frm_PhanQuyen frmPQHT = new frm_PhanQuyen();
            if (Application.OpenForms.OfType<frm_PhanQuyen>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmPQHT.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmPQHT.Show();
            }
        }
    }
}
