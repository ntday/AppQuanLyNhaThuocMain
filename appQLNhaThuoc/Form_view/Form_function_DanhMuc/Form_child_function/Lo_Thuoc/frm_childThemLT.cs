using appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc
{
    public partial class frm_childThemLT : Form
    {

        LoThuoc lt = new LoThuoc();

        Obj_Model.DonViTinh dvt = new Obj_Model.DonViTinh();
        public frm_childThemLT()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void layDanhSachDVTdvBaoGo()
        {
            DataTable dt = dvt.layDanhSachDonViTinh();
            textBox_dvBaoGo.DataSource = dt;
            textBox_dvBaoGo.DisplayMember = "tenDVT";
            textBox_dvBaoGo.ValueMember = "tenDVT";
        }

        public void layDanhSachDVTdvDongGoi()
        {
            DataTable dt = dvt.layDanhSachDonViTinh();
            textBox_dvDongGoi.DataSource = dt;
            textBox_dvDongGoi.DisplayMember = "tenDVT";
            textBox_dvDongGoi.ValueMember = "tenDVT";
        }

        public void layDanhSachDVTdvSanPham()
        {
            DataTable dt = dvt.layDanhSachDonViTinh();
            textBox_dvSanPham.DataSource = dt;
            textBox_dvSanPham.DisplayMember = "tenDVT";
            textBox_dvSanPham.ValueMember = "tenDVT";
        }

        public void layDanhSachDVT()
        {
            layDanhSachDVTdvBaoGo();
            layDanhSachDVTdvDongGoi();
            layDanhSachDVTdvSanPham();
        }

        private void hangDuocPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            hangDuocPhamBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        private void frm_childThemLT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.donViTinh' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.hangDuocPham' table. You can move, or remove it, as needed.
            hangDuocPhamTableAdapter.Fill(qLNhaThuocDataSet.hangDuocPham);
            layDanhSachDVT();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("thoát và không lưu thay đổi", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Close();
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
                if (masolo.Length <= 0) MessageBox.Show("chưa thêm đủ thông tin cần thiết", "THÔNG BÁO LỖI");
                else
                {
                    lt.themLoThuoc(masolo, tenhangduoc, ngaysx, ngayhethang, dvbaogo, dvdonggoi, dvsanpham, ghichu);
                    MessageBox.Show("thêm thành công lô thuốc " + masolo, "THÔNG BÁO");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi không sác định" + err.Message, "THÔNG BÁO LỖI");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_childThemDVT frmThemDVT = new frm_childThemDVT();
            if (frmThemDVT.ShowDialog() == DialogResult.OK) layDanhSachDVT();
        }

        private void textBox_dvBaoGo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
