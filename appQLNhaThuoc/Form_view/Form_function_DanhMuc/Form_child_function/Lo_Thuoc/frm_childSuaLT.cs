using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc
{
    public partial class frm_childSuaLT : Form
    {
        LoThuoc lt = new LoThuoc();
        string  masua;
        public frm_childSuaLT()
        {
            InitializeComponent();
        }

        public void layDanhSachLoThuoc()
        {
            DataTable tableLT = lt.layDanhSachLoThuoc();
            dataGridView_loThuoc.DataSource = tableLT;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masolo = textBox_maSoLo.Text;
            string tenhangduoc = tenHangDuocComboBox.Text;
            string ngaysx = dateTimePicker_ngaySX.Value.ToString("yyyy/MM/dd");
            string ngayhethang = dateTimePicker_ngayHH.Value.ToString("yyyy/MM/dd");
            string dvbaogo = textBox_dvBaoGo.Text;
            string dvdonggoi = textBox_dvDongGoi.Text;
            string dvsanpham = textBox_dvSanPham.Text;
            string ghichu = textBox_GhiChu.Text;


            try
            {
                if (masua.Length <= 0) MessageBox.Show("chưa thêm đủ thông tin cần thiết", "THÔNG BÁO LỖI");
                else
                {
                    lt.suaLoThuoc(masolo, tenhangduoc, ngaysx, ngayhethang, dvbaogo, dvdonggoi, dvsanpham, ghichu, masua);
                    MessageBox.Show("thay đổi thành công lô thuốc " + masolo, "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sác định" + err.Message, "THÔNG BÁO LỖI");
            }

        }

        private void dataGridView_loThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_loThuoc.Rows[e.RowIndex];
            string format = "dd/MM/yyyy hh:mm:ss tt";

            masua = Convert.ToString(row.Cells["maSoLo"].Value);

            textBox_maSoLo.Text = Convert.ToString(row.Cells["maSoLo"].Value);
            tenHangDuocComboBox.Text = Convert.ToString(row.Cells["tenHangDuoc"].Value);


            DateTime dateTimeSX = DateTime.ParseExact(Convert.ToString(row.Cells["ngaySanXuat"].Value), format, CultureInfo.InvariantCulture);
            dateTimePicker_ngaySX.Value = dateTimeSX;

            DateTime dateTimeHH = DateTime.ParseExact(Convert.ToString(row.Cells["ngayHetHang"].Value), format, CultureInfo.InvariantCulture);
            dateTimePicker_ngayHH.Value = dateTimeHH;

            textBox_dvBaoGo.Text = Convert.ToString(row.Cells["donViBaoGoi"].Value); ;
            textBox_dvDongGoi.Text = Convert.ToString(row.Cells["donViDongGoi"].Value);
            textBox_dvSanPham.Text = Convert.ToString(row.Cells["donViSanPham"].Value);
            textBox_GhiChu.Text = Convert.ToString(row.Cells["ghiChu"].Value); ;


        }

        private void dataGridView_loThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_childSuaLT_Load(object sender, EventArgs e)
        {
            layDanhSachLoThuoc();
        }
    }
}
