using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appQLNhaThuoc.Obj_Model;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh
{
    public partial class frm_childThemDVT : Form
    {
        Obj_Model.DonViTinh dvt = new Obj_Model.DonViTinh();
        public frm_childThemDVT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDonViTinhM = text_tenDVTmoi.Text;
                string motaDonViTinhM =""+ text_moTaDVTmoi.Text;
                if(tenDonViTinhM.Length<=0) MessageBox.Show("Chưa nhập đủ thông tin cần thiết", "THÔNG BÁO LỖI");
                else
                {
                    dvt.themDonViTinhMoi(tenDonViTinhM,motaDonViTinhM);
                    MessageBox.Show("Thêm đơn vị tính mới thành công", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("có lỗi không sát định "+err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ch == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
