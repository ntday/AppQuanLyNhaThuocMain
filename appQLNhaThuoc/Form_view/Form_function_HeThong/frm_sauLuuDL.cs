using appQLNhaThuoc.Obj_Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    public partial class frm_sauLuuDL : Form
    {
        HeThong ht = new HeThong();
        public frm_sauLuuDL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = Regex.Replace(dlg.FileName, @"[\s/]", ""); ;

                string input = label2_time.Text;
                string output = Regex.Replace(input, @"[\s/:]", "");

                label3_url.Text = fileName+output+ ".bak".Trim();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ht.sauLuuDuLieu(label3_url.Text) == true) MessageBox.Show("sao lưu dữ liệu thành công","THÔNG BÁO");
            else MessageBox.Show("sao lưu dữ liệu không thành công","THÔNG BÁO LỖI");
        }

        private void label3_url_Click(object sender, EventArgs e)
        {

        }
    }
}
