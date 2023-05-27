﻿using appQLNhaThuoc.Obj_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    public partial class frm_childSuaNCC : Form
    {
        NhaCungCap ncc = new NhaCungCap();
        string maSua;
        public frm_childSuaNCC()
        {
            InitializeComponent();
        }

        private void nhaCungCapThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhaCungCapThuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childSuaNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhaCungCapThuoc' table. You can move, or remove it, as needed.
            this.nhaCungCapThuocTableAdapter.Fill(this.qLNhaThuocDataSet.nhaCungCapThuoc);

        }

        private void sdtNhaCungCapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailNhaCungCapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = maNhaCungCapTextBox.Text;
                string tenNCC = tenNhaCungCapTextBox.Text;
                string sdtNCC = sdtNhaCungCapTextBox.Text;
                string emailNCC = emailNhaCungCapTextBox.Text;
                string diachiNCC = diaChiNhaCungCapTextBox.Text;

                if (maSua.Length <= 0 || maSua == null) MessageBox.Show("chưa chọn thông tin cần chỉnh sửa", "THÔNG BÁO");
                else
                {
                    ncc.suaNhaCungCap(maNCC, tenNCC, sdtNCC, emailNCC, diachiNCC, maSua);
                    MessageBox.Show("thay đổi thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void nhaCungCapThuocDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = nhaCungCapThuocDataGridView.Rows[e.RowIndex];

            maSua = Convert.ToString(row.Cells["maNhaCungCap"].Value);
        }
    }
}
