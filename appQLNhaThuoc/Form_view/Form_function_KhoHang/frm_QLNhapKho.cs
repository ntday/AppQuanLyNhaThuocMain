using appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh;
using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc;
using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap;
using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Thuoc_child;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    public partial class frm_QLNhapKho : Form
    {
        LoThuoc lt = new LoThuoc();
        Thuoc thuoc = new Thuoc();
        DonViTinh dvt = new DonViTinh();
        NhaCungCap ncc = new NhaCungCap();
        User us = new User();
        PhieuNhapKho pnk = new PhieuNhapKho();
        string maPN;
        Kho kho = new Kho();
        KhuyenMai khuyenMai = new KhuyenMai();

        public frm_QLNhapKho()
        {
            InitializeComponent();
        }


        public void layDanhSachNCC()
        {
            DataTable dt = ncc.layDanhSachNhaCungCap();
            comboBox_maNCC.DataSource = dt;
            comboBox_maNCC.DisplayMember = "maNhaCungCap";
            comboBox_maNCC.ValueMember = "maNhaCungCap";

            comboBox_tenNCC.DataSource = dt;
            comboBox_tenNCC.DisplayMember = "tenNhaCungCap";
            comboBox_tenNCC.ValueMember = "tenNhaCungCap";
        }

        public void layDanhSachLoThuoc()
        {
            DataTable dt = lt.layDanhSachLoThuoc();
            comboBox_maLo.DataSource = dt;
            comboBox_maLo.DisplayMember = "maSoLo";
            comboBox_maLo.ValueMember = "maSoLo";
        }

        public void layDanhSachT()
        {
            DataTable dt = thuoc.layDanhSachThuoc();
            comboBox_maThuoc.DataSource = dt;
            comboBox_maThuoc.DisplayMember = "maThuoc";
            comboBox_maThuoc.ValueMember = "maThuoc";

            comboBox_tenThuoc.DataSource = dt;
            comboBox_tenThuoc.DisplayMember = "tenThuoc";
            comboBox_tenThuoc.ValueMember = "tenThuoc";
        }

        public void layDanhSachDVT()
        {
            DataTable dt = dvt.layDanhSachDonViTinh();
            comboBox_donViTinh.DataSource = dt;
            comboBox_donViTinh.DisplayMember = "tenDVT";
            comboBox_donViTinh.ValueMember = "soMaDVT";

        }
        private void chiTietPhiepNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            chiTietPhiepNhapBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qLNhaThuocDataSet);

        }

        public void layThongTinNhanhVien()
        {
            string tenDN = Properties.Settings.Default.UserName;
            string hoTenNVDN = us.layTenNV(tenDN);
            string maNhanVienDN = us.layMaNhanhVienTheoTen(tenDN);

            textBox_maNhanVien.Text = maNhanVienDN;
            textBox_tenNhanVien.Text = hoTenNVDN;
        }

        public void taoMaPhieuNhap()
        {
            maPN = pnk.layGiaTriIDENTITY();

            string str = "0000";
            int num = int.Parse(maPN);
            string result = "PNT-" + num.ToString().PadLeft(str.Length, '0');

            textBox_maPhieuNhap.Text = result;
        }
        private void frm_QLNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaThuocDataSet.chiTietPhiepNhap' table. You can move, or remove it, as needed.
            chiTietPhiepNhapTableAdapter.Fill(qLNhaThuocDataSet.chiTietPhiepNhap);
            layDanhSachNCC();
            layDanhSachLoThuoc();
            layDanhSachT();
            layDanhSachDVT();
            layThongTinNhanhVien();
            taoMaPhieuNhap();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBox_donViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_themLoThuoc_Click(object sender, EventArgs e)
        {
            frm_childThemLT frmThem = new frm_childThemLT();
            if (frmThem.ShowDialog() == DialogResult.OK) layDanhSachLoThuoc();
        }

        private void dateTimePicker_thoiGianLapPhieu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_themThongTinThuoc_Click(object sender, EventArgs e)
        {
            frm_childThemThuo frmThemThuoc = new frm_childThemThuo();
            if (frmThemThuoc.ShowDialog() == DialogResult.OK) layDanhSachT();
        }

        private void button_themDonViTinh_Click(object sender, EventArgs e)
        {
            frm_childThemDVT frmThemDVT = new frm_childThemDVT();
            if (frmThemDVT.ShowDialog() == DialogResult.OK) layDanhSachDVT();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frm_childThemNCC frmThemNCC = new frm_childThemNCC();
            if (frmThemNCC.ShowDialog() == DialogResult.OK) layDanhSachNCC();
        }

        private void AddDataToDataGridView(string maLo, string maT, string tenT, string donVT, string soL, string donG)
        {
            bool isDrugCodeExist = false;
            string tien;
            int SoLuongThuoc;
            double donGia;
            double tongThanhTien;
            foreach (DataGridViewRow row in dataGridView_chiTietPhieuNhap.Rows)
            {
                if (row.Cells["maThuoc"].Value != null && row.Cells["maThuoc"].Value.ToString() == maT && row.Cells["maSoLo"].Value != null && row.Cells["maSoLo"].Value.ToString() == maLo)
                {
                    row.Cells["soLuong"].Value = "" + (int.Parse(row.Cells["soLuong"].Value.ToString()) + int.Parse(soL));

                    SoLuongThuoc = int.Parse(row.Cells["soLuong"].Value.ToString());
                    donGia = double.Parse(row.Cells["donGia"].Value.ToString());
                    tongThanhTien = SoLuongThuoc * donGia;
                    tien = "" + tongThanhTien;
                    row.Cells["thanhTien"].Value = tien;
                    isDrugCodeExist = true;
                    break;
                }
            }
            if (!isDrugCodeExist)
            {
                string donGiaThuoc = textBox_donGia.Text;
                string soluongThuoc = textBox_soLuong.Text;

                tien = "" + (int.Parse(soluongThuoc) * double.Parse(donGiaThuoc));

                dataGridView_chiTietPhieuNhap.Rows.Add(maLo, maT, tenT, donVT, soL, donG, tien);
            }
        }

        private void button_themChiTietHang_Click(object sender, EventArgs e)
        {

            try
            {

                string maloH = comboBox_maLo.Text;
                string soluong = textBox_soLuong.Text;
                string maThuoc = comboBox_maThuoc.Text;
                string tenThuoc = comboBox_tenThuoc.Text;
                string donViTinh = comboBox_donViTinh.Text;
                string donGia = textBox_donGia.Text.Replace(",", "");

                if (soluong.Length <= 0 || donGia.Length <= 0)
                {
                    MessageBox.Show("chưa nhập đủ thông tin cần thiết", "THÔNG BÁO lỗi");
                }
                else
                {
                    AddDataToDataGridView(maloH, maThuoc, tenThuoc, donViTinh, soluong, donGia);
                    int sum = 0;
                    for (int i = 0; i < dataGridView_chiTietPhieuNhap.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView_chiTietPhieuNhap.Rows[i].Cells["thanhTien"].Value);
                    }
                    label_tongGiaNhap.Text = "" + sum;

                }

            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi chưa sát định " + err.Message, "THÔNG BÁO lỗi");
            }

        }

        private void vbButton_luuPhieuNhap_Click(object sender, EventArgs e)
        {


            try
            {
                string maNCC = comboBox_maNCC.Text;
                string timeLapPhieu = dateTimePicker_thoiGianLapPhieu.Value.ToString("yyyy/MM/dd  hh:mm:ss");
                string maNVNhap = textBox_maNhanVien.Text;
                string ghiCNhap = textBox_ghiChu.Text;

                int n = dataGridView_chiTietPhieuNhap.Rows.Count - 1;

                if (n <= 0)
                {
                    MessageBox.Show("chưa có thông tin trong phiếu nhập", "THÔNG BÁO lỗi");
                }
                else
                {
                    if (MessageBox.Show("sát nhận thêm phiếu nhập " + textBox_maPhieuNhap.Text, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        pnk.themPhieuNhap(maNCC, timeLapPhieu, maNVNhap, ghiCNhap);
                        for (int i = 0; i < n; i++)
                        {
                            string maloH = dataGridView_chiTietPhieuNhap.Rows[i].Cells["maSoLo"].Value.ToString();
                            string maThuoc = dataGridView_chiTietPhieuNhap.Rows[i].Cells["maThuoc"].Value.ToString();
                            string tenThuoc = dataGridView_chiTietPhieuNhap.Rows[i].Cells["tenThuoc"].Value.ToString();
                            string donViTinh = dataGridView_chiTietPhieuNhap.Rows[i].Cells["tenDVT"].Value.ToString();
                            string soluong = dataGridView_chiTietPhieuNhap.Rows[i].Cells["soluong"].Value.ToString();
                            string donGia = dataGridView_chiTietPhieuNhap.Rows[i].Cells["donGia"].Value.ToString();


                            if (kho.chekTonTaiChiTiet(maThuoc, maloH) == true)
                            {
                            pnk.themChiTietPhieuNhap(maPN, maloH, maThuoc, donViTinh, donGia.Replace(",", ""), soluong);
                            kho.themChiTietKho(maThuoc, maloH, soluong, maPN);
                            }
                            else
                            {
                                pnk.themChiTietPhieuNhap(maPN, maloH, maThuoc, donViTinh, donGia.Replace(",", ""), soluong);

                                int slKho = (int)kho.laySoLuongKhoTheoMaThuocvsMaLo(maThuoc, maloH);
                                int slNhapKho = slKho + int.Parse(soluong);
                                string strSLNhapKho = "" + slNhapKho;

                                kho.suaSoLuongTrongKho("1", strSLNhapKho, maThuoc, maloH);
                            }

                        }
                        MessageBox.Show("thêm thành công phiếu nhập ", "THÔNG BÁO");
                        lamMoiPhieuNhap();

                    }
                }

            }
            catch (Exception err)
            {

                MessageBox.Show("có lỗi chưa sát định " + err.Message, "THÔNG BÁO lỗi");
            }


        }

        private void dataGridView_chiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_donGia_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_donGia.Text, out double donGia))
            {
                textBox_donGia.Text = donGia.ToString("N0");
                textBox_donGia.SelectionStart = textBox_donGia.Text.Length;
            }
        }

        private void textBox_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void clearBang()
        {

            while ((dataGridView_chiTietPhieuNhap.Rows.Count - 1) > 0)
            {
                dataGridView_chiTietPhieuNhap.Rows.RemoveAt(0);
            }

        }

        public void lamMoiPhieuNhap()
        {
            layDanhSachNCC();
            layDanhSachLoThuoc();
            layDanhSachT();
            layDanhSachDVT();
            layThongTinNhanhVien();
            taoMaPhieuNhap();
            clearBang();
            textBox_soLuong.Text = "";
            textBox_donGia.Text = "";
            MessageBox.Show("đã làm mới phiếu nhập", "THÔNG BÁO");
        }

        private void vbButton_lamMoiPhieuNhap_Click(object sender, EventArgs e)
        {
            lamMoiPhieuNhap();
        }

        private void frm_QLNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox_soLuong_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_tenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

          //  laySoKMVaGiamGiaVSQuaTangTheoTen
        }
    }
}
