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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang
{
    public partial class frm_childXoaKH : Form
    {
        KhachHang kh = new KhachHang();
        public frm_childXoaKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childXoaKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLNhaThuocDataSet.KhachHang);

        }

        private void khachHangDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = khachHangDataGridView.Rows[e.RowIndex];

                sdtKHTextBox.Text = Convert.ToString(row.Cells["sdtKH"].Value);
                hoHoLotKHTextBox.Text = Convert.ToString(row.Cells["hoHoLotKH"].Value);
                tenKHTextBox.Text = Convert.ToString(row.Cells["tenKH"].Value);
                namSinhTextBox.Text = Convert.ToString(row.Cells["namSinh"].Value);
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maXoa = sdtKHTextBox.Text;
                string hovate = hoHoLotKHTextBox.Text;
                string ten = tenKHTextBox.Text;

                if (maXoa.Length <= 0 || maXoa == null) MessageBox.Show("chưa chọn thông tin cần xóa", "THÔNG BÁO");
                else
                {
                    DialogResult ch = MessageBox.Show("đồng ý xóa khách hàng "+hovate+" "+ten, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (ch == DialogResult.Yes)
                    {
                        kh.xoaKhachHang(maXoa);
                        MessageBox.Show("xóa thông tin thành công", "THÔNG BÁO");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");
                //throw;
            }
        }
    }
}
