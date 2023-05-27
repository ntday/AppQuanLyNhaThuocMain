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

namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    public partial class frm_PhanQuyen : Form
    {
        NhanVien nv = new NhanVien();
        User us = new User();
        public frm_PhanQuyen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }



        public void layDanhSachNHanVien()
        {
            DataTable tableKH = nv.layDanhSachNhanVien();
            comboBox_manv.DataSource = tableKH;
            comboBox_manv.DisplayMember = "maNV";
            comboBox_manv.ValueMember = "maNV";

            comboBox_tenNV.DataSource = tableKH;
            comboBox_tenNV.DisplayMember = "tenDN";
            comboBox_tenNV.ValueMember = "tenDN";

            comboBox_hoTenNV.DataSource = tableKH;
            comboBox_hoTenNV.DisplayMember = "hoVaTen";
            comboBox_hoTenNV.ValueMember = "hoVaTen";

            comboBox_sdtNV.DataSource = tableKH;
            comboBox_sdtNV.DisplayMember = "sdtNV";
            comboBox_sdtNV.ValueMember = "sdtNV";

        }

        public void showQuyenNV()
        {
            string soQuyen = us.laySoQuyenHangUserTheoTenDN(comboBox_manv.Text);
            if (soQuyen == "1") radioButton1.Checked = true;
            else if (soQuyen == "2") radioButton2.Checked = true;
            else radioButton3.Checked = true;
        }



        private void frm_PhanQuyen_Load(object sender, EventArgs e)
        {

            this.nhanVienTableAdapter.Fill(this.qLNhaThuocDataSet.nhanVien);
            layDanhSachNHanVien();
        }

        private void maNVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_manv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_manv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showQuyenNV();
        }

        private void comboBox_tenNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showQuyenNV();
        }

        private void comboBox_hoTenNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showQuyenNV();
        }

        private void comboBox_sdtNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showQuyenNV();
        }

        private void comboBox_manv_ValueMemberChanged(object sender, EventArgs e)
        {
            showQuyenNV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Đồng ý thay đổi quyền cho "+comboBox_hoTenNV.Text, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes)
            {
                string tenQuyen;
                if (radioButton1.Checked == true) tenQuyen = "Admin";
                else if (radioButton2.Checked == true) tenQuyen = "User";
                else tenQuyen = "lock";
                try
                {

                    us.capHaQuyen(tenQuyen, comboBox_manv.Text);
                    MessageBox.Show("cập nhật quyền thành công", "THÔNG BÁO");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception err)
                {

                    MessageBox.Show("cập nhật quyền không thành công, có lỗi chưa sác định "+err.Message, "THÔNG BÁO");
                }

            }
        }
    }
}
