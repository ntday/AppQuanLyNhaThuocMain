using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_BanHang.Form_child_function
{
    public partial class frm_moRong : Form
    {
        public string tenMayIn { get; set; }
        public frm_moRong()
        {
            InitializeComponent();
        }

        private void frm_moRong_Load(object sender, EventArgs e)
        {


            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboBox_tenMayIn.Items.Add(printer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.tenMayIn = comboBox_tenMayIn.Items.ToString();
            Properties.Settings.Default.Save();

            if(radioButton1.Checked == true)
            {
                Properties.Settings.Default.SoBanIn = 1;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.SoBanIn = 2;
                Properties.Settings.Default.Save();
            }

            MessageBox.Show("đã lưu cài đặt");
            Close();

        }
    }
}
