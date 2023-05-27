using appQLNhaThuoc.Obj_Model;
using System;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhom_thuoc
{
    public partial class frm_childThemNT : Form
    {
        NhomThuoc nt = new NhomThuoc();
        public frm_childThemNT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox_tenNhomThuoc.Text;
            string mota = textBox_moTaNhomThuoc.Text;

            try
            {
                if (ten is null  || ten.Length <= 0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO ");
                else
                {
                    nt.themNhomThuoc(ten, mota);
                    MessageBox.Show("thêm thành công nhóm thuốc " + ten, "THÔNG BÁO ");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
