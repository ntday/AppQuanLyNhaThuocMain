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
    public partial class frm_childSuaThuoc : Form
    {
        Thuoc thuoc = new Thuoc();
        string maSua ="";
        public frm_childSuaThuoc()
        {
            InitializeComponent();
        }

        public void layDanhSachThuoc()
        {
            dataGridView_thuoc.DataSource = thuoc.layDanhSachThuoc();
        }
        private void frm_childSuaThuoc_Load(object sender, EventArgs e)
        {
            layDanhSachThuoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
        }

        private void dataGridView_thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_thuoc.Rows[e.RowIndex];

            maSua = Convert.ToString(row.Cells["maThuoc"].Value);

            textBox_maThuoc.Text = Convert.ToString(row.Cells["maThuoc"].Value);
            textBox_tenThuoc.Text = Convert.ToString(row.Cells["tenThuoc"].Value);
            comboBox_nhomThuoc.Text = Convert.ToString(row.Cells["tenNhomThuoc"].Value);
            textBox_thanhPhan.Text = Convert.ToString(row.Cells["thanhPhanChinh"].Value);
            textBox_congDung.Text = Convert.ToString(row.Cells["congDungChinh"].Value);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maTh = textBox_maThuoc.Text;
            string tenTh = textBox_tenThuoc.Text;
            string nhomTh = comboBox_nhomThuoc.Text;
            string thanhPhanTh = textBox_thanhPhan.Text;
            string congDungTh = textBox_congDung.Text;

            if(MessageBox.Show("đồng ý thay đổi thông tin thuốc có mã "+maSua,"THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thuoc.suaThuoc(maTh, tenTh, thanhPhanTh, congDungTh, nhomTh, maSua);
                MessageBox.Show("đã thay đổi thông tin thuốc thành công", "THÔNG BÁO");
                DialogResult = DialogResult.OK;
            }

        }

        private void dataGridView_thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
