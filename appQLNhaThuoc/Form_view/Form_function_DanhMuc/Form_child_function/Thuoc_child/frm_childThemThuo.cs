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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Thuoc_child
{
    public partial class frm_childThemThuo : Form
    {
        Thuoc th = new Thuoc();
        NhomThuoc nt = new NhomThuoc();
        public frm_childThemThuo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("THOÁT VÀ KHÔNG LƯU THAY ĐỔI", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        public void layDanhSachNhomThuoc()
        {
            DataTable dt = nt.layDanhSachNhomThuoc();
            comboBox_nhomThuoc.DataSource = dt;
            comboBox_nhomThuoc.DisplayMember = "tenNhomThuoc";
            comboBox_nhomThuoc.ValueMember = "tenNhomThuoc";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string maT = textBox_maThuoc.Text;
                string tenT = textBox_tenThuoc.Text;
                string nhom = comboBox_nhomThuoc.Text;
                string thanhPhanT = textBox_thanhPhan.Text;
                string congDungT = textBox_congDung.Text;

                if (maT.Length <= 0 || maT is null || tenT.Length <= 0 || tenT is null) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO LỖI");
                else
                {
                    th.themThuoc(maT,tenT,thanhPhanT,congDungT,nhom);
                    MessageBox.Show("Thêm thành công thuốc có mã " + maT, "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi chưa sác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void frm_childThemThuo_Load(object sender, EventArgs e)
        {
            layDanhSachNhomThuoc();
        }
    }
}
