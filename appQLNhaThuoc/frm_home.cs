using appQLNhaThuoc.Form_view.Form_control;
using appQLNhaThuoc.Form_view.Form_function;
using appQLNhaThuoc.Form_view.Form_function_HeThong;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc
{
    public partial class frm_home : Form
    {
        private Form activeForm;
        NhatKyHeThong nkht = new NhatKyHeThong();
        NhaThuoc nt = new NhaThuoc();
        User us = new User();
        frm_loginUser frmLogin;

        public string tenNhanVienDangNhapHome { get; set; }
        public frm_home()
        {
            InitializeComponent();
        }
        private void moMangHinhDieuKhien(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();

            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(childForm);
            panel_container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public string layHoTenNV(string tenDN)
        {
           return us.layTenNV(tenDN);
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            frmLogin = new frm_loginUser();
            DataTable ntTB = nt.layThongTinNhaThuoc();
            frm_thongTinNhaThuoc frmTTNhaThuoc = new frm_thongTinNhaThuoc();
            string quyenHangUser;

            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Close();
            }
            else
            {
                if (ntTB.Rows.Count <= 0)
                {
                    frmTTNhaThuoc.ShowDialog();
                }
                else
                {

                    label_tenNhaThuoc.Text = ntTB.Rows[0].Field<string>("tenNhaThuoc");
                    label_soDienThoai.Text = ntTB.Rows[0].Field<string>("sdtNhaThuoc");
                    label_diaChi.Text = ntTB.Rows[0].Field<string>("diaChiNhaThuoc");
                    label_tenNVDangNhap.Text = frmLogin.tenNhanVienDangNhap;
                    label_hovatenNV.Text = layHoTenNV(frmLogin.tenNhanVienDangNhap);
                    tenNhanVienDangNhapHome = frmLogin.tenNhanVienDangNhap;
                    quyenHangUser = us.layQuyenHangUserTheoTenDN(frmLogin.tenNhanVienDangNhap);
                    if(quyenHangUser=="user"|| quyenHangUser == "User")
                    {
                        button_baoCaoControl.Enabled = false;
                        button_heThongControl.Enabled = false;
                    }

                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_tenNV_Click(object sender, EventArgs e)
        {

        }

        private void button_danhMucControl_Click(object sender, EventArgs e)
        {
            frm_control_DanhMuc frmDanhMuc = new frm_control_DanhMuc();
            moMangHinhDieuKhien(frmDanhMuc, sender);
        }

        private void button_baoCaoControl_Click(object sender, EventArgs e)
        {
            frm_control_BaoCao frmBaoCao = new frm_control_BaoCao();
            moMangHinhDieuKhien(frmBaoCao, sender);
        }

        private void button_bangHangControl_Click(object sender, EventArgs e)
        {
            frm_control_BanHang frmBanHang= new frm_control_BanHang();
            moMangHinhDieuKhien(frmBanHang, sender);
        }

        private void button_khoHangControl_Click(object sender, EventArgs e)
        {
            frm_control_KhoHang frmKhoHang = new frm_control_KhoHang();
            moMangHinhDieuKhien(frmKhoHang, sender);
        }

        private void button_heThongControl_Click(object sender, EventArgs e)
        {
            frm_control_HeThong frmHeThong = new frm_control_HeThong();
            moMangHinhDieuKhien(frmHeThong, sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label_ngayThang.Text = now.ToString("dd/MM/yyyy");
            label_gio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DateTime dateDangXuatNow = DateTime.Now;
                string timeDx = dateDangXuatNow.ToString("yyyy/MM/dd  hh:mm:ss");
                string tenDN = frmLogin.tenNhanVienDangNhap;
                nkht.ghiNhanDangXuat(tenDN, timeDx);
            }
            catch (Exception)
            {

                MessageBox.Show("có lỗi trong quá trình ghi nhận nhật ký đăng xuất", "THÔNG BÁO LỖI");
            }

        }

        private void label_hovatenNV_Click(object sender, EventArgs e)
        {
            frm_editUserProfile frmThayDoiThonTinUser = new frm_editUserProfile();
            if(frmThayDoiThonTinUser.ShowDialog()==DialogResult.OK) Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("đồng ý đăng xuất khổi hệ thống", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    DateTime dateDangXuatNow = DateTime.Now;
                    string timeDx = dateDangXuatNow.ToString("yyyy/MM/dd  hh:mm:ss");
                    string tenDN = frmLogin.tenNhanVienDangNhap;
                    nkht.ghiNhanDangXuat(tenDN, timeDx);
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                catch (Exception)
                {
                    MessageBox.Show("có lỗi trong quá trình ghi nhận nhật ký đăng xuất", "THÔNG BÁO LỖI");
                }

            }
        }
    }
}
