using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function
{
    public partial class frm_loginUser : Form
    {
        User us = new User();
        NhatKyHeThong nkht = new NhatKyHeThong();
        public string tenNhanVienDangNhap { get; set; }

        public frm_loginUser()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showPass.Checked == true) text_passLogin.UseSystemPasswordChar = false;
            else text_passLogin.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoatLogin_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("BẠN SẼ THOÁT KHỎI THỆ THỐNG", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ch == DialogResult.OK) Application.Exit();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tendn = text_tenLogin.Text;
            string pass = text_passLogin.Text;
            DataTable tbUser = us.layDanhSachUserTheoTen(tendn);
            if (tendn.Length <= 0 || pass.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (tbUser.Rows.Count <= 0) MessageBox.Show("sai tên đăng nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (tbUser.Rows.Count <= 0) MessageBox.Show("sai tên đăng nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string passDB = tbUser.Rows[0].Field<string>("matKhau");
                        if (pass != passDB) MessageBox.Show("sai mật khẩu đăng nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            try
                            {
                                tenNhanVienDangNhap = tendn;
                                DateTime dateDangNhapNow = DateTime.Now;
                                string timeDn = dateDangNhapNow.ToString("yyyy/MM/dd  hh:mm:ss");
                                nkht.ghiNhanDangNhap(tendn, timeDn);


                                Properties.Settings.Default.UserName = tendn;
                                Properties.Settings.Default.Save();

                                DialogResult = DialogResult.OK;
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("có lỗi khi ghi nhận nhất ký hệ thống", "THÔNG BÁO LỖI");
                            }



                        }
                    }
                }
            }
        }

        private void frm_loginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
