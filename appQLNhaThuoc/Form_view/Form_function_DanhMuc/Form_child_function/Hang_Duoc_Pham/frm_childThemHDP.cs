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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham
{
    public partial class frm_childThemHDP : Form
    {
        HangDuocPham hd = new HangDuocPham();
        public frm_childThemHDP()
        {
            InitializeComponent();
        }

        private void hangDuocPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangDuocPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childThemHDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.hangDuocPham' table. You can move, or remove it, as needed.
            this.hangDuocPhamTableAdapter.Fill(this.qLNhaThuocDataSet.hangDuocPham);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_maHangDuoc.Text.Length > 0 || text_tenHangDuoc.Text.Length > 0 || text_soDienThoai.Text.Length > 0 || text_email.Text.Length > 0 || text_diaChiTruSo.Text.Length > 0)
            {
                DialogResult ch = MessageBox.Show("Bạn có chắc muốn thoát", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            string hoten = text_maHangDuoc.Text;
            string tenHangDuoc = text_tenHangDuoc.Text;
            string sdt = text_soDienThoai.Text;
            string email = text_email.Text;
            string diaChi = text_diaChiTruSo.Text;

            try
            {
                if (text_maHangDuoc.Text.Length > 0 || text_soDienThoai.Text.Length > 0 || text_tenHangDuoc.Text.Length > 0 || text_email.Text.Length > 0 || text_diaChiTruSo.Text.Length > 0)
                {

                    hd.themHangDuoc(hoten, tenHangDuoc, sdt, email, diaChi);
                    DialogResult ch = MessageBox.Show("thêm thành công hãng dược", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("chưa có đủ thông tin cần thiết", "THÔNG BÁO");
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
