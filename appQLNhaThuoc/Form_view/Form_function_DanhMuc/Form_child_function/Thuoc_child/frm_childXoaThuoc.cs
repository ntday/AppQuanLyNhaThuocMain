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
    public partial class frm_childXoaThuoc : Form
    {
        Thuoc thuoc = new Thuoc();
        public frm_childXoaThuoc()
        {
            InitializeComponent();
        }
        public void layDanhSachThuoc()
        {
            dataGridView_thuoc.DataSource = thuoc.layDanhSachThuoc();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void frm_childXoaThuoc_Load(object sender, EventArgs e)
        {
            layDanhSachThuoc();
        }

        private void dataGridView_thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_thuoc.Rows[e.RowIndex];
            textBox_maThuoc.Text = Convert.ToString(row.Cells["maThuoc"].Value);
            textBox_tenThuoc.Text = Convert.ToString(row.Cells["tenThuoc"].Value);
            comboBox_nhomThuoc.Text = Convert.ToString(row.Cells["tenNhomThuoc"].Value);
            textBox_thanhPhan.Text = Convert.ToString(row.Cells["thanhPhanChinh"].Value);
            textBox_congDung.Text = Convert.ToString(row.Cells["congDungChinh"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maTh = textBox_maThuoc.Text;

            if (MessageBox.Show("đồng ý XÓA thông tin thuốc có mã " + maTh, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thuoc.xoaThuoc(maTh);
                MessageBox.Show("XÓA thông tin thuốc thành công", "THÔNG BÁO");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
