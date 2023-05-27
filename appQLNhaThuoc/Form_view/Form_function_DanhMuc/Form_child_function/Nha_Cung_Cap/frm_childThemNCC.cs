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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    public partial class frm_childThemNCC : Form
    {
        NhaCungCap ncc = new NhaCungCap();
        public frm_childThemNCC()
        {
            InitializeComponent();
        }

        private void nhaCungCapThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhaCungCapThuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childThemNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhaCungCapThuoc' table. You can move, or remove it, as needed.
            this.nhaCungCapThuocTableAdapter.Fill(this.qLNhaThuocDataSet.nhaCungCapThuoc);

        }

        private void diaChiNhaCungCapLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNCC = textMaNCC.Text;
            string tenNCC = textTenNCC.Text;
            string sdtNCC = textSDTNCC.Text;
            string emailNCC = textEmailNCC.Text;
            string diaChiNCC = textDiaChiNCC.Text;

            try
            {
                if (textMaNCC.Text.Length > 0 || textTenNCC.Text.Length > 0 || textSDTNCC.Text.Length > 0 || textEmailNCC.Text.Length > 0 || textDiaChiNCC.Text.Length > 0)
                {

                    ncc.themNhaCungCap(maNCC, tenNCC, sdtNCC, emailNCC, diaChiNCC);
                    DialogResult ch = MessageBox.Show("thêm thành công nhà cung cấp", "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult ch = MessageBox.Show("chưa có đủ thông tin cần thiết", "THÔNG BÁO");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi không xác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
