using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    public partial class frm_editUserProfile : Form
    {
        User us = new User();
        public frm_editUserProfile()
        {
            InitializeComponent();
        }

        private void frm_editUserProfile_Load(object sender, EventArgs e)
        {
            string tenDN = Properties.Settings.Default.UserName;
            textBox_tenDangNhap.Text = tenDN;
            textBox_hoVaTen.Text = us.layTenNV(tenDN);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false) panel1.Enabled = false;
            else panel1.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) textBox_passCu.UseSystemPasswordChar = false;
            else textBox_passCu.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox_passMoi.UseSystemPasswordChar = false;
                textBox_passMoiNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_passMoi.UseSystemPasswordChar = true;
                textBox_passMoiNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_tenDangNhap.Text.Length > 0 || textBox_passMoi.Text.Length > 0)
            {
                if (MessageBox.Show("đồng ý thoát và không lưu thông tin", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
            }
            else Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tendnCu = Properties.Settings.Default.UserName;
            string pass = textBox_passCu.Text;

            string tendnMoi = textBox_tenDangNhap.Text;
            string hoVatenMoi = textBox_hoVaTen.Text;

            string pasMoi = textBox_passMoi.Text;
            string pasMoiNhapLai = textBox_passMoiNhapLai.Text;


            //if(pasMoi==pasMoiNhapLai)

            if (radioButton1.Checked == true)
            {

                // thực hiện lệnh có thay đổi pass

                if (textBox_tenDangNhap.Text.Length <= 0 || textBox_hoVaTen.Text.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (pasMoi.Length <= 0 || pasMoiNhapLai.Length <= 0) MessageBox.Show("nhập đủ thông tin sác nhận mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (pasMoi != pasMoiNhapLai) MessageBox.Show("mật khẩu sác nhận không khớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            // thực hiện lệnh thay đổi có thay đổi pass

                            DataTable tbUser = us.layDanhSachUserTheoTen(tendnCu);
                            if (tendnCu.Length <= 0 || pass.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                                // thực hiện thay đổi

                                                if (MessageBox.Show("đồng ý lưu thông tin thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                                {
                                                    us.doiThongTinUserCoMatKhau(tendnMoi, hoVatenMoi, pasMoi, tendnCu);
                                                    DialogResult = DialogResult.OK;
                                                }

                                            }
                                            catch (Exception)
                                            {

                                                MessageBox.Show("thay đổi thông tin không thành công", "THÔNG BÁO LỖI");
                                            }



                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // thực hiện lệnh không thay đổi pass

                DataTable tbUser = us.layDanhSachUserTheoTen(tendnCu);
                if (tendnCu.Length <= 0 || textBox_hoVaTen.Text.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    // thực hiện thay đổi

                                    if (MessageBox.Show("đồng ý lưu thông tin thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        us.doiThongTinUserKhongMatKhau(tendnMoi, hoVatenMoi, tendnCu);
                                        DialogResult = DialogResult.OK;
                                    }

                                }
                                catch (Exception)
                                {

                                    MessageBox.Show("thay đổi thông tin không thành công", "THÔNG BÁO LỖI");
                                }



                            }
                        }
                    }
                }
            }

        }


    }
}
