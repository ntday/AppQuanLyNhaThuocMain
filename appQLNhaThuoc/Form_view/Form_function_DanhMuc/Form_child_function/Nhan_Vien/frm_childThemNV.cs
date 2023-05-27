using appQLNhaThuoc.Obj_Model;
using System;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhan_Vien
{
    public partial class frm_childThemNV : Form
    {
        NhanVien nv = new NhanVien();
        public frm_childThemNV()
        {
            InitializeComponent();
        }

        private void frm_childThemNV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_hoTen.Text.Length > 0 || text_hoTen.Text.Length > 0 || text_soDienThoai.Text.Length > 0 || text_tenDangNhap.Text.Length > 0)
            {
                DialogResult ch = MessageBox.Show("Thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ch == DialogResult.Yes) Close();

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string ho = text_hoHoLot.Text;
            string hoten = text_hoTen.Text;
            string sdt = text_soDienThoai.Text;
            string ngaySinh = timePicker_ngaySinh.Value.ToString("yyyy/MM/dd"); ;
            string tendn = text_tenDangNhap.Text;

            try
            {
                if (text_hoTen.Text.Length > 0 || text_soDienThoai.Text.Length > 0 || text_tenDangNhap.Text.Length > 0)
                {

                    nv.themNhanVien(hoten,sdt, ngaySinh, tendn);
                    DialogResult ch = MessageBox.Show("thêm thành công nhân viên", "THÔNG BÁO");
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
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
