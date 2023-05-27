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
    public partial class frm_QLNhatKyHeThong : Form
    {
        NhatKyHeThong nkht = new NhatKyHeThong();
        public frm_QLNhatKyHeThong()
        {
            InitializeComponent();
        }

        public void layDanhSachNhatKy()
        {
            dataGridView_banNhatKyHeThong.DataSource = nkht.layDanhSachNhatKy();
        }

        private void nhatKyHeThongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void frm_QLNhatKyHeThong_Load(object sender, EventArgs e)
        {
            layDanhSachNhatKy();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* DateTime dateA = dateTimePicker1.Value;
            DateTime dateB = dateTimePicker2.Value;

            foreach (DataGridViewRow row in dataGridView_banNhatKyHeThong.Rows)
            {
                if (row.Cells["timeDangNhap"].Value != null)
                {
                    DateTime dateRow = Convert.ToDateTime(row.Cells["timeDangNhap"].Value);
                    if (DateTime.Compare(dateRow, dateA) >= 0 && DateTime.Compare(dateRow, dateB) <= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_banNhatKyHeThong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
