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

namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    public partial class frm_phucHoiDL : Form
    {
        HeThong ht = new HeThong();
        public frm_phucHoiDL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                /*string input = "25052023023832";
                string format = "ddMMyyyyHHmmss";
                DateTime dateTime = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);*/
                if (fileName.IndexOf(".bak") > 0 && fileName.IndexOf(".bak") > 0)
                {
                    label3_url.Text = fileName;
                }
                else MessageBox.Show("sai định dạng sau lưu trước của chương trình", "THÔNG BÁO LỖI");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ht.phucHoiDuLieu(label3_url.Text) == true) MessageBox.Show("Phục hồi dữ liệu thành công", "THÔNG BÁO");
            else MessageBox.Show("Phục hồi dữ liệu không thành công", "THÔNG BÁO LỖI");
        }

        private void label2_time_Click(object sender, EventArgs e)
        {

        }
    }
}
