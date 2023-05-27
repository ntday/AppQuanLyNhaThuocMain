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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai
{
    public partial class frm_childThemKM : Form
    {
        KhuyenMai km = new KhuyenMai();
        public frm_childThemKM()
        {
            InitializeComponent();
        }

        private void frm_childThemKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.DangKhuyenMai' table. You can move, or remove it, as needed.
            this.dangKhuyenMaiTableAdapter.Fill(this.qLNhaThuocDataSet.DangKhuyenMai);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string tenkm = textBox_tenKhuyenMai.Text;
                string ngaybd = dateTimePicker_ngayBatDau.Value.ToString("yyyy/MM/dd"); ;
                string ngaykt = dateTimePicker_ngayKetThuc.Value.ToString("yyyy/MM/dd"); ;
                string sl = textBox_soLuong.Text;
                string dangkm = comboBox_dangKhuyenMai.Text;

                if(tenkm.Length<=0) MessageBox.Show("chưa nhập đủ thông tin ", "THÔNG BÁO LỖI ");
                else
                {
                    if (sl.Length <= 0) sl = "0";
                    km.themKhuyenMai(tenkm, ngaybd, ngaykt, sl, dangkm);

                    MessageBox.Show("thêm thông tin thành công", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không sát định " + err.Message, "THÔNG BÁO LỖI ");
            }
        }
    }
}
