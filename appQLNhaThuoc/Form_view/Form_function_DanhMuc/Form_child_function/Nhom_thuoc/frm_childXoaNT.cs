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

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhom_thuoc
{
    public partial class frm_childXoaNT : Form
    {
        NhomThuoc nt = new NhomThuoc();
        public frm_childXoaNT()
        {
            InitializeComponent();
        }

        private void nhomThuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomThuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNhaThuocDataSet);

        }

        private void frm_childXoaNT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.nhomThuoc' table. You can move, or remove it, as needed.
            this.nhomThuocTableAdapter.Fill(this.qLNhaThuocDataSet.nhomThuoc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = maNhomThuocTextBox.Text;
            string ten = tenNhomThuocTextBox.Text;
            string mota = moTaTextBox.Text;

            try
            {
                if (ten.Length <= 0|| ma.Length<=0) MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO ");
                else
                {
                   if(MessageBox.Show("đồng ý xóa nhóm thuốc "+ten,"THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        nt.xoaNhomThuoc(ma);
                        MessageBox.Show("xóa thành công nhóm thuốc " + ten, "THÔNG BÁO ");
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sác định " + err.Message, "THÔNG BÁO LỖI");
            }
        }
    }
}
