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
    public partial class frm_childThemKH : Form
    {
        KhachHang kh = new KhachHang();
        public frm_childThemKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childThemKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLNhaThuocDataSet.KhachHang);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdt = textSDT.Text;
            string hoLot = textHoLot.Text;
            string ten = textTen.Text;
            string namSinh = textNamSinh.Text;
            try
            {
                if (textSDT.Text.Length > 0 || textHoLot.Text.Length > 0 || textTen.Text.Length > 0 || textNamSinh.Text.Length > 0)
                {

                    kh.themKhachHang(sdt, hoLot, ten, namSinh);
                    DialogResult ch = MessageBox.Show("thêm thành công khách hàng", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    DialogResult ch = MessageBox.Show("chưa có đủ thông tin cần thiết", "THÔNG BÁO");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes) Close();
        }
    }
}
