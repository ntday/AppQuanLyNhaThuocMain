using appQLNhaThuoc.Obj_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc
{
    public partial class frm_childXoaLT : Form
    {
        LoThuoc lt = new LoThuoc();
        public frm_childXoaLT()
        {
            InitializeComponent();
        }
        public void layDanhSachLoThuoc()
        {
            DataTable tableLT = lt.layDanhSachLoThuoc();
            dataGridView_loThuoc.DataSource = tableLT;
        }
        private void frm_childXoaLT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.loThuoc' table. You can move, or remove it, as needed.
            //this.loThuocTableAdapter.Fill(this.qLNhaThuocDataSet.loThuoc);
            layDanhSachLoThuoc();

        }

        private void dataGridView_loThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_loThuoc.Rows[e.RowIndex];
            string format = "dd/MM/yyyy hh:mm:ss tt";

            //masua = Convert.ToString(row.Cells["maSoLo"].Value);

            textBox_maSoLo.Text = Convert.ToString(row.Cells["maSoLo"].Value);
            textBox_tenHangDuoc.Text = Convert.ToString(row.Cells["tenHangDuoc"].Value);


            DateTime dateTimeSX = DateTime.ParseExact(Convert.ToString(row.Cells["ngaySanXuat"].Value), format, CultureInfo.InvariantCulture);
            dateTimePicker_ngaySX.Value = dateTimeSX;

            DateTime dateTimeHH = DateTime.ParseExact(Convert.ToString(row.Cells["ngayHetHang"].Value), format, CultureInfo.InvariantCulture);
            dateTimePicker_ngayHH.Value = dateTimeHH;

            textBox_dvBaoGo.Text = Convert.ToString(row.Cells["donViBaoGoi"].Value); ;
            textBox_dvDongGoi.Text = Convert.ToString(row.Cells["donViDongGoi"].Value);
            textBox_dvSanPham.Text = Convert.ToString(row.Cells["donViSanPham"].Value);
            textBox_GhiChu.Text = Convert.ToString(row.Cells["ghiChu"].Value); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masolo = textBox_maSoLo.Text;


            try
            {
                if (masolo.Length <= 0) MessageBox.Show("chưa thêm đủ thông tin cần thiết", "THÔNG BÁO LỖI");
                else
                {
                    if(MessageBox.Show("đồng ý xóa lô thuốc có mã "+masolo, "THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        lt.xoaLoThuoc(masolo);
                        MessageBox.Show("xóa thành công lô thuốc " + masolo, "THÔNG BÁO");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sác định" + err.Message, "THÔNG BÁO LỖI");
            }

        }
    }
}
