using appQLNhaThuoc.Form_view.Form_function_BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_control
{
    public partial class frm_control_BanHang : Form
    {
        public frm_control_BanHang()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            frm_mangHinhTinhTien frmTinhTien = new frm_mangHinhTinhTien();
            if (Application.OpenForms.OfType<frm_mangHinhTinhTien>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmTinhTien.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmTinhTien.Show();
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            frm_QLHoaDonBanLe frmHoaDon = new frm_QLHoaDonBanLe();
            if (Application.OpenForms.OfType<frm_QLHoaDonBanLe>().Any(f => f.Visible))
            {
                // Form1 is open and visible
                frmHoaDon.Activate();
            }
            else
            {
                // Form1 is not open or not visible

                frmHoaDon.Show();
            }
        }

        private void frm_control_BanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
