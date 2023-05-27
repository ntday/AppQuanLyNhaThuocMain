using appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang;
using appQLNhaThuoc.Form_view.Form_function_BanHang.Form_child_function;
using appQLNhaThuoc.Obj_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_BanHang
{
    public partial class frm_mangHinhTinhTien : Form
    {
        string maHoaDon;

        HoaDon hoadon = new HoaDon();
        User us = new User();
        KhachHang kh = new KhachHang();
        DangThanhToan dtt = new DangThanhToan();
        KhuyenMai kmai = new KhuyenMai();
        Thuoc thuoc = new Thuoc();
        GiaDonHang gdh = new GiaDonHang();
        Kho kho = new Kho();
        BangTam bt = new BangTam();
        NhaThuoc nt = new NhaThuoc();
        NhomThuoc nhomThuoc = new NhomThuoc();

        bool statusLuuBill = false;
        string maNhanVienDN;
        string hoTenNVDN;

        string tenMayin;
        int soBanIn;


        int maXoaDong;

        string maHoaDNIN;
        string ngayLapHoaDonIN;
        string tenNTIN;
        string diaChiNTIN;
        string sdtNTIN;
        string chietKhauIn;
        string tenKHIN;
        string sdtKHIN;


        public frm_mangHinhTinhTien()
        {
            InitializeComponent();
        }

        public void taoMaHD()
        {
            maHoaDon = hoadon.layGiaTriIDENTITYHoaDon();
            string str = "0000";
            int num = int.Parse(maHoaDon);
            string result = "HD-" + num.ToString().PadLeft(str.Length, '0');

            label_mabill.Text = result;
        }

        public void layThongTinNhanhVien()
        {
            string tenDN = Properties.Settings.Default.UserName;
            hoTenNVDN = us.layTenNV(tenDN);
            maNhanVienDN = us.layMaNhanhVienTheoTen(tenDN);

            label_maNV.Text = maNhanVienDN;
            label_tenNV.Text = hoTenNVDN;
        }

        public void layThongTinKhach()
        {
            DataTable tableKH = kh.layDangSachKhachHang();
            comboBox_SDTKhach.DataSource = tableKH;
            comboBox_SDTKhach.DisplayMember = "sdtKH";
            comboBox_SDTKhach.ValueMember = "sdtKH";

            comboBox_tenKhach.DataSource = tableKH;
            comboBox_tenKhach.DisplayMember = "tenKH";
            comboBox_tenKhach.ValueMember = "tenKH";
        }

        public void layDangThanhToan()
        {
            DataTable tableDtt = dtt.layDanhSachDangThanhToan();
            comboBox_dangThanhToan.DataSource = tableDtt;
            comboBox_dangThanhToan.DisplayMember = "tenDangTT";
            comboBox_dangThanhToan.ValueMember = "tenDangTT";
        }

        public void layDSKhuyenMai()
        {
            DataTable tableDKM = kmai.danhSachKhuyenMai();
            comboBox_dangKM.DataSource = tableDKM;
            comboBox_dangKM.DisplayMember = "TenKM";
            comboBox_dangKM.ValueMember = "TenKM";
        }

        public void layDSThuoc()
        {
            DataTable tableThuoc = thuoc.layDanhSachThuoc();
            comboBox_maThuoc.DataSource = tableThuoc;
            comboBox_maThuoc.DisplayMember = "maThuoc";
            comboBox_maThuoc.ValueMember = "maThuoc";

            comboBox_tenThuoc.DataSource = tableThuoc;
            comboBox_tenThuoc.DisplayMember = "tenThuoc";
            comboBox_tenThuoc.ValueMember = "tenThuoc";
        }

        public void showListView()
        {
            DataTable tableNhomThuoc = nhomThuoc.layDanhSachNhomThuoc();
            int n = tableNhomThuoc.Rows.Count;


            DataTable[] tableThuocTheoNhom = new DataTable[n]; ;
            List<string> listNhomThuoc = new List<string>();



            for (int i = 0; i < n; i++)
            {
                listNhomThuoc.Add(tableNhomThuoc.Rows[i]["tenNhomThuoc"].ToString());


            }
            string[] array = listNhomThuoc.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                ListViewGroup gr = new ListViewGroup(array[i]);
                listView1_dsThuoc.Groups.Add(gr);

                tableThuocTheoNhom[i] = thuoc.layDanhSachThuocTheoNhom(array[i]);
            }


            for (int i = 0; i < tableThuocTheoNhom.Length - 1; i++)
            {

            }

        }

        public bool IsPrinterOnline(string printerName)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = printerName;
            bool isOnline = printDoc.PrinterSettings.IsValid;
            return isOnline;
            // true sài được
            // false không sài được
        }

        private void frm_mangHinhTinhTien_Load(object sender, EventArgs e)
        {
            taoMaHD();
            layThongTinNhanhVien();
            layThongTinKhach();
            layDangThanhToan();
            showListView();
            layDSThuoc();


            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboBox_tenMayIn.Items.Add(printer);

            }

            if (comboBox_tenMayIn.Items.Count > 0)
            {
                comboBox_tenMayIn.SelectedIndex = 0;
                comboBox_tenMayIn.Text = comboBox_tenMayIn.Items[0].ToString();
            }

            //comboBox_tenMayIn.Text = comboBox_tenMayIn.Items[0];

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            label_thoiGianTaoHD.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_childThemKH frmThemKH = new frm_childThemKH();
            if (frmThemKH.ShowDialog() == DialogResult.OK) layThongTinKhach();
        }

        private void comboBox_maThuoc_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_maThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_maThuoc_TextChanged(object sender, EventArgs e)
        {
            string maThuoc = comboBox_maThuoc.Text;

        }


        private void AddDataToDataGridView(string maT, string tenT, string donVT, string soL, string donG, string ghiChu)
        {
            bool isDrugCodeExist = false;
            string thanhTien;
            int SoLuongThuoc;
            double donGia;
            double tongThanhTien;
            ghiChu = "";
            foreach (DataGridViewRow row in dataGridView_danhSachChiTiet.Rows)
            {
                if (row.Cells["maThuoc"].Value != null && row.Cells["maThuoc"].Value.ToString() == maT)
                {
                    row.Cells["soLuongMua"].Value = "" + (int.Parse(row.Cells["soLuongMua"].Value.ToString()) + int.Parse(soL));

                    SoLuongThuoc = int.Parse(row.Cells["soLuongMua"].Value.ToString());
                    donGia = double.Parse(row.Cells["donGia"].Value.ToString());

                    tongThanhTien = SoLuongThuoc * donGia;
                    thanhTien = "" + tongThanhTien;
                    row.Cells["thanhTien"].Value = thanhTien;
                    isDrugCodeExist = true;
                    break;
                }
            }
            if (!isDrugCodeExist)
            {
                thanhTien = "" + (int.Parse(soL) * double.Parse(donG));
                dataGridView_danhSachChiTiet.Rows.Add(maT, tenT, donVT, soL, donG, thanhTien, ghiChu);
            }
        }

        public double tinhTongTienSauGiam(double giaTien, int phanTramGiamGia)
        {
            return giaTien * (100 - phanTramGiamGia) / 100;
        }
        private void tinhTien(double tongT, int chietKhau)
        {
            textBox_thanhTienTrietKhau.Text = "" + (tongT - tinhTongTienSauGiam(tongT, chietKhau));

            textBox_tongHoaDon.Text = "" + tinhTongTienSauGiam(tongT, chietKhau);
        }

        private void tinhTienKhachDua(double giaPhaiTra, double khachDua)
        {
            double tienTraKhach;
            if (khachDua == 0)
            {
                tienTraKhach = 0;
            }
            else
            {
                tienTraKhach = khachDua - giaPhaiTra;

            }
            textBox_tienThuaTraKhach.Text = "" + Math.Round(tienTraKhach, 0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string maTH = comboBox_maThuoc.Text;
                string tenTH = comboBox_tenThuoc.Text;
                string soL = textBox_soLuong.Text;
                string dvt = kho.layDonViTinhTheoMaThuoc(maTH);
                string donGiaBanRa = gdh.layGiaBan(maTH);



                int slKho = kho.laySoLuongKhoTheoMaThuoc(maTH);

                string soLConLai = "" + (slKho - int.Parse(soL));

                if (donGiaBanRa == "null") MessageBox.Show("Hàng chưa thêm giá bán", "THÔNG BÁO lỗi");
                else
                {
                    if (dvt == "null" || dvt is null) MessageBox.Show("Hàng chưa thêm đơn vị tính ", "THÔNG BÁO lỗi");
                    else
                    {
                        if (soL.Length <= 0 || int.Parse(soL) <= 0) MessageBox.Show("chưa chọn số lượng mặt hàng ", "THÔNG BÁO lỗi");
                        else
                        {
                            if ((int.Parse(soL) - slKho) > 0) MessageBox.Show("Hàng không đủ cung cấp " + (int.Parse(soL) - slKho), "THÔNG BÁO lỗi");
                            else
                            {
                                if (bt.checkDaCoBangtamTheoMaThuoc(maTH) == true)
                                {


                                    if (int.Parse(soLConLai) < 0) MessageBox.Show("Hàng không còn đủ ", "THÔNG BÁO");
                                    else
                                    {
                                        //thêm thuốc vào bản tạm
                                        bt.themBangTam(maTH, soLConLai);

                                        AddDataToDataGridView(maTH, tenTH, dvt, soL, donGiaBanRa, "");
                                        double sum = 0;
                                        for (int i = 0; i < dataGridView_danhSachChiTiet.Rows.Count; ++i)
                                        {
                                            sum += Convert.ToInt32(dataGridView_danhSachChiTiet.Rows[i].Cells["thanhTien"].Value);
                                        }

                                        textBox_tongDon.Text = "" + sum;

                                        int chietKhau = int.Parse(textBox_phanTramTrietKhau.Text);
                                        double tongT = double.Parse(textBox_tongDon.Text);

                                        textBox_tongHoaDon.Text = "" + tinhTongTienSauGiam(tongT, chietKhau);
                                        textBox_tienKhachDua.Text = "";
                                    }
                                }
                                else
                                {

                                    int soBangTam = bt.laySoLuongBangTamTheoMa(maTH);
                                    soLConLai = "" + (soBangTam - int.Parse(soL));

                                    if (int.Parse(soLConLai) < 0) MessageBox.Show("Hàng không còn đủ ", "THÔNG BÁO");
                                    else
                                    {
                                        //cập nhật số lượng thuốc
                                        bt.suaSoLuongBangTam(soLConLai, maTH);

                                        AddDataToDataGridView(maTH, tenTH, dvt, soL, donGiaBanRa, "");
                                        double sum = 0;
                                        for (int i = 0; i < dataGridView_danhSachChiTiet.Rows.Count; ++i)
                                        {
                                            sum += Convert.ToInt32(dataGridView_danhSachChiTiet.Rows[i].Cells["thanhTien"].Value);
                                        }

                                        textBox_tongDon.Text = "" + sum;

                                        int chietKhau = int.Parse(textBox_phanTramTrietKhau.Text);
                                        double tongT = double.Parse(textBox_tongDon.Text);

                                        textBox_tongHoaDon.Text = "" + tinhTongTienSauGiam(tongT, chietKhau);
                                        textBox_tienKhachDua.Text = "";


                                    }


                                }


                            }
                        }
                    }
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi chưa sát định " + err.Message, "THÔNG BÁO lỗi");
            }
        }



        private void dataGridView_danhSachChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_danhSachChiTiet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /*if (e.RowIndex % 2 == 0)
            {
                dataGridView_danhSachChiTiet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                dataGridView_danhSachChiTiet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }*/
        }

        private void dataGridView_danhSachChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            //row = dataGridView_danhSachChiTiet.Rows[e.RowIndex];
            maXoaDong = e.RowIndex;
            //maSua = comboBox_maThuoc.Text = Convert.ToString(row.Cells["maThuoc"].Value);
        }




        public void themPhayTextBox(TextBox text)
        {
            if (double.TryParse(text.Text, out double donGia))
            {
                text.Text = donGia.ToString("N0");
                text.SelectionStart = text.Text.Length;
            }
        }



        private void textBox_tongDon_TextChanged(object sender, EventArgs e)
        {
            themPhayTextBox(textBox_tongDon);
        }

        private void textBox_thanhTienTrietKhau_TextChanged(object sender, EventArgs e)
        {
            themPhayTextBox(textBox_thanhTienTrietKhau);
        }

        private void textBox_tongHoaDon_TextChanged(object sender, EventArgs e)
        {
            themPhayTextBox(textBox_tongHoaDon);
        }

        private void textBox_tienKhachDua_TextChanged(object sender, EventArgs e)
        {
            themPhayTextBox(textBox_tienKhachDua);
        }

        private void textBox_tienThuaTraKhach_TextChanged(object sender, EventArgs e)
        {
            themPhayTextBox(textBox_tienThuaTraKhach);
        }

        private void textBox_thanhTienTrietKhau_Click(object sender, EventArgs e)
        {
            int chietKhau = int.Parse(textBox_phanTramTrietKhau.Text);
            double tongT = double.Parse(textBox_tongDon.Text);
            tinhTien(tongT, chietKhau);
        }

        private void textBox_tongHoaDon_Click(object sender, EventArgs e)
        {
            int chietKhau = int.Parse(textBox_phanTramTrietKhau.Text);
            double tongT = double.Parse(textBox_tongDon.Text);
            tinhTien(tongT, chietKhau);
        }


        /* private void luuHoaDon()
         {

             try
             {
                 string

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
        */


        public void clearBang()
        {
            while ((dataGridView_danhSachChiTiet.Rows.Count - 1) > 0)
            {
                dataGridView_danhSachChiTiet.Rows.RemoveAt(0);
            }
        }


        private void lamMoiHoaDon()
        {
            taoMaHD();
            layThongTinNhanhVien();
            layThongTinKhach();
            layDangThanhToan();
            //layDSKhuyenMai();
            showListView();
            clearBang();
            bt.xoaBangTam();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (statusLuuBill == false) MessageBox.Show("bill chưa được in không thể lưu", "THÔNG BÁO NHẮC NHỞ ");
            else
            {

                if ((dataGridView_danhSachChiTiet.Rows.Count - 1) <= 0) MessageBox.Show("chưa có thông tin đơn hàng ", "THÔNG BÁO NHẮC NHỞ ");
                else
                {
                    try
                    {

                        string tenDangTT = comboBox_dangThanhToan.Text;
                        string tenDangKM = comboBox_dangKM.Text;

                        string soMaNV = maNhanVienDN;
                        string sdtKH = comboBox_SDTKhach.Text;

                        DateTime now = DateTime.Now;

                        string ngayLapHoaDon = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                        string soMaDangTT = dtt.layMaDangThanhToanTheoTen(tenDangTT);
                        string maNhaThuoc = "NT001";
                        string soKM;
                        string ghiChu = textBox_ghiChuHoaDon.Text;


                        int mahd = int.Parse(maHoaDon);

                        string maDH = "" + mahd;

                        if (comboBox_dangKM.Text.Length <= 0 || comboBox_dangKM.Text is null) soKM = "";
                        else soKM = kmai.laySoKMVTheoTen(tenDangKM);



                        hoadon.luuHoaDon(soMaNV, sdtKH, ngayLapHoaDon, soMaDangTT, maNhaThuoc, soKM, ghiChu);

                        int n = dataGridView_danhSachChiTiet.Rows.Count - 1;


                        for (int i = 0; i < n; i++)
                        {

                            string maThuoc = dataGridView_danhSachChiTiet.Rows[i].Cells["maThuoc"].Value.ToString();
                            string donViTinh = dataGridView_danhSachChiTiet.Rows[i].Cells["tenDVT"].Value.ToString();
                            string soluongMua = dataGridView_danhSachChiTiet.Rows[i].Cells["soLuongMua"].Value.ToString();
                            string donGiaBan = dataGridView_danhSachChiTiet.Rows[i].Cells["donGia"].Value.ToString();
                            string ghiChuChiTiet = dataGridView_danhSachChiTiet.Rows[i].Cells["ghiChu"].Value.ToString();

                            // hoadon them chi tiết
                            hoadon.themChiTietHoaDon(maDH, maThuoc, donViTinh, soluongMua, donGiaBan, ghiChuChiTiet);

                            int slKho = (int)kho.laySoLuongKhoTheoMaThuoc(maThuoc);
                            int slNhapKho = slKho - int.Parse(soluongMua);
                            string strSLNhapKho = "" + slNhapKho;

                            kho.suaSoLuongTrongKhoTheoMaThuoc("1", strSLNhapKho, maThuoc);
                        }

                        MessageBox.Show("lưu thành công hóa đơn ", "THÔNG BÁO");
                        lamMoiHoaDon();


                    }
                    catch (Exception err)
                    {

                        MessageBox.Show("có lỗi chưa sác định " + err, "THÔNG BÁO LỖI ");
                    }
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((dataGridView_danhSachChiTiet.Rows.Count - 1) <= 0) MessageBox.Show("chưa có thông tin đơn hàng ", "THÔNG BÁO NHẮC NHỞ ");
            else
            {
                string str = "0000";
                int num = int.Parse(maHoaDon);
                string result = "HD-" + num.ToString().PadLeft(str.Length, '0');

                try
                {
                    DataTable tableNhaT = nt.layThongTinNhaThuoc();
                    tenNTIN = tableNhaT.Rows[0]["tenNhaThuoc"].ToString();
                    diaChiNTIN = tableNhaT.Rows[0]["diaChiNhaThuoc"].ToString();
                    sdtNTIN = tableNhaT.Rows[0]["sdtNhaThuoc"].ToString();
                    ngayLapHoaDonIN = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                    maHoaDNIN = result;
                    chietKhauIn = textBox_thanhTienTrietKhau.Text;
                    sdtKHIN = comboBox_SDTKhach.Text;
                    tenKHIN = comboBox_tenKhach.Text;


                }
                catch (Exception err)
                {

                    MessageBox.Show("có lỗi chưa sác định khi lấy dữ liệu nạp bill" + err, "THÔNG BÁO LỖI ");
                }


                try
                {
                    //printPreviewDialog1.Document = printDocument1;
                    //printPreviewDialog1.ShowDialog();
                    //tenMayin = "POS-80C";

                    int soin;
                    if (radioButton1.Checked == true) soin = 1;
                    else soin = 2;

                    printDocument1.PrinterSettings.PrinterName = comboBox_tenMayIn.Text;  //Tên máy in của bạn
                    printDocument1.PrinterSettings.Copies = (short)soin; // Số lượng bản in
                    printDocument1.PrinterSettings.Collate = true;
                    //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                    printDocument1.Print();


                    statusLuuBill = true;

                }
                catch (Exception err)
                {

                    MessageBox.Show("có lỗi chưa sác định khi in bill" + err, "THÔNG BÁO LỖI ");
                }
            }



        }

        private void textBox_tienThuaTraKhach_Click(object sender, EventArgs e)
        {
            double tongHoaDon = double.Parse(textBox_tongHoaDon.Text.Replace(",", ""));
            double khachDua;
            if (textBox_tienKhachDua.Text.Length <= 0)
            {
                khachDua = 0;
            }
            else khachDua = double.Parse(textBox_tienKhachDua.Text.Replace(",", ""));

            tinhTienKhachDua(tongHoaDon, khachDua);
        }

        private void comboBox_dangKM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dangKM_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dangKM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string tenkm = comboBox_dangKM.Text;
            DataTable dtKM = kmai.layMaGiamGiaVSQuaTangTheoTen(tenkm);

            string giamGia = dtKM.Rows[0]["giamGia"].ToString();
            string quaTang = dtKM.Rows[0]["quaTang"].ToString();

            string formatGhiChu1 = "hóa đơn được áp dụng khuyến mãi " + tenkm + " được giảm giá " + giamGia + "%";
            string formatGhiChu2 = "hóa đơn được áp dụng khuyến mãi " + tenkm + " được tặng" + quaTang;
            if (giamGia.Length <= 0 || giamGia is null) textBox_ghiChuHoaDon.Text = formatGhiChu2;
            else if (quaTang.Length <= 0 || quaTang is null)
            {
                textBox_ghiChuHoaDon.Text = formatGhiChu1;
                textBox_phanTramTrietKhau.Text = giamGia;
            }
            else
            {
                textBox_ghiChuHoaDon.Text = formatGhiChu1 + " kèm quà tặng " + quaTang;
            }

        }

        private void label_thoiGianTaoHD_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_dangKM_Click(object sender, EventArgs e)
        {
            layDSKhuyenMai();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) layDSKhuyenMai();
            else comboBox_dangKM.Text = "";
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lamMoiHoaDon();
                MessageBox.Show("tạo mới bill thành công", "THÔNG BÁO");
            }
            catch (Exception)
            {
                MessageBox.Show("tạo mới bill không thành công", "THÔNG BÁO LỖI");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_moRong frmMoRong = new frm_moRong();
            frmMoRong.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            StringFormat drawFormat = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            e.Graphics.DrawString("Mã hóa đơn: " + maHoaDNIN, new Font("Tahoma", 7, FontStyle.Italic), Brushes.Black, new Point(0, 5));
            e.Graphics.DrawString("ngày lập hóa đơn:" + ngayLapHoaDonIN, new Font("Tahoma", 7, FontStyle.Italic), Brushes.Black, new Point(120, 5));

            e.Graphics.DrawString(tenNTIN, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(60, 30));
            e.Graphics.DrawString(diaChiNTIN, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString(sdtNTIN, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(90, 80));

            e.Graphics.DrawString("PHIẾU THANH TOÁN", new Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new Point(40, 110));

            e.Graphics.DrawString("Nhân viên: " + hoTenNVDN, new Font("Tahoma", 7, FontStyle.Regular), Brushes.Black, new Point(0, 140));
            e.Graphics.DrawString("in lúc: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), new Font("Tahoma", 7, FontStyle.Regular), Brushes.Black, new Point(150, 140));

            e.Graphics.DrawString("--  --  --  --  --  --  --  --  --  --  --  --  --  --  ", new Font("Tahoma", 10, FontStyle.Regular), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("Khách hàng: " + tenKHIN, new Font("Tahoma", 7, FontStyle.Regular), Brushes.Black, new Point(0, 190));
            e.Graphics.DrawString("SDT: " + sdtKHIN, new Font("Tahoma", 7, FontStyle.Regular), Brushes.Black, new Point(180, 190));


            Font Tahoma5 = new Font("Tahoma", 7, FontStyle.Bold);
            Font TahomaChiTien = new Font("Tahoma", 7, FontStyle.Italic);

            string text1 = "Mã thuốc";
            string text2 = "số lượng";
            string text3 = "Đơn giá";
            string text4 = "Thanh tiền";
            /*SizeF size1 = e.Graphics.MeasureString(text1, Tahoma5);
            SizeF size2 = e.Graphics.MeasureString(text2, Tahoma5);
            SizeF size3 = e.Graphics.MeasureString(text3, Tahoma5);
            SizeF size4 = e.Graphics.MeasureString(text4, Tahoma5);
            SizeF size5 = e.Graphics.MeasureString(text5, Tahoma5);*/
            float x1 = 0;
            float y1 = 210;
            float x2 = x1 + 90;
            float x3 = x2 + 60;
            float x4 = x3 + 70;
            e.Graphics.DrawString(text1, Tahoma5, Brushes.Black, x1, y1);
            e.Graphics.DrawString(text2, Tahoma5, Brushes.Black, x2, y1);
            e.Graphics.DrawString(text3, Tahoma5, Brushes.Black, x3, y1);
            e.Graphics.DrawString(text4, Tahoma5, Brushes.Black, x4, y1);



            // này là mãng dùng vòng lập for duyệt
            /*string textCT1 = "Mã thuốc";
            string textCT2 = "số lượng";
            string textCT3 = "Đơn vị";
            string textCT4 = "Đơn giá";
            string textCT5 = "Thanh tiền";*/


            float y1CT = 230;




            int n = dataGridView_danhSachChiTiet.Rows.Count - 1;


            for (int i = 0; i < n; i++)
            {


                string maThuoc = dataGridView_danhSachChiTiet.Rows[i].Cells["maThuoc"].Value.ToString();
                string tenThuocin = dataGridView_danhSachChiTiet.Rows[i].Cells["tenThuoc"].Value.ToString();
                string soluongMua = dataGridView_danhSachChiTiet.Rows[i].Cells["soLuongMua"].Value.ToString();
                string dvmua = dataGridView_danhSachChiTiet.Rows[i].Cells["tenDVT"].Value.ToString();
                string donGiaBan = dataGridView_danhSachChiTiet.Rows[i].Cells["donGia"].Value.ToString();
                string thanhTien = dataGridView_danhSachChiTiet.Rows[i].Cells["thanhTien"].Value.ToString();

                e.Graphics.DrawString(maThuoc, TahomaChiTien, Brushes.Black, x1, y1CT);
                e.Graphics.DrawString(tenThuocin, TahomaChiTien, Brushes.Black, x1, y1CT + 10);
                e.Graphics.DrawString(soluongMua + " " + dvmua, TahomaChiTien, Brushes.Black, x2, y1CT);

                string chuoi = int.Parse(donGiaBan).ToString("N3");
                string didangChuoi = chuoi.Remove(chuoi.IndexOf('.'));

                e.Graphics.DrawString(didangChuoi, TahomaChiTien, Brushes.Black, x3, y1CT);

                string chuoi1 = int.Parse(thanhTien).ToString("N3");
                string didang1 = chuoi1.Remove(chuoi1.IndexOf('.'));


                e.Graphics.DrawString(didang1, TahomaChiTien, Brushes.Black, x4, y1CT);

                y1CT = y1CT + 25;
            }



            /* // CHI TIẾT 1
             e.Graphics.DrawString(textCT1, TahomaChiTien, Brushes.Black, x1, y1CT);
             e.Graphics.DrawString(textCT2, TahomaChiTien, Brushes.Black, x2, y1CT);
             e.Graphics.DrawString(textCT3, TahomaChiTien, Brushes.Black, x3, y1CT);
             e.Graphics.DrawString(textCT4, TahomaChiTien, Brushes.Black, x4, y1CT);

             // CHI TIẾT 2
             e.Graphics.DrawString(textCT1, TahomaChiTien, Brushes.Black, x1, y2CTArr);
             e.Graphics.DrawString(textCT2, TahomaChiTien, Brushes.Black, x2, y2CTArr);
             e.Graphics.DrawString(textCT3, TahomaChiTien, Brushes.Black, x3, y2CTArr);
             e.Graphics.DrawString(textCT4, TahomaChiTien, Brushes.Black, x4, y2CTArr);
            */


            float yTong = y1CT + 18;
            float xTong = 85;


            string textCTTong = "TỔNG HÓA ĐƠN: " + textBox_tongDon.Text + " VND";
            e.Graphics.DrawString(textCTTong, Tahoma5, Brushes.Black, xTong, yTong);

            if (textBox_phanTramTrietKhau.Text.Length < 0 || int.Parse(textBox_phanTramTrietKhau.Text) == 0)
            {

                string textDangTT = "Thanh toán: " + comboBox_dangThanhToan.Text;
                e.Graphics.DrawString(textDangTT, Tahoma5, Brushes.Black, xTong, yTong + 15);

                float loiCO = yTong + 20 + 12;
                string loiCamOn = "Cảm ơn quý khách đã tin tưởng sử dụng sản phẩm của chúng tôi!";
                e.Graphics.DrawString(loiCamOn, TahomaChiTien, Brushes.Black, 0, loiCO);
                e.Graphics.DrawString("hóa đơn chỉ có giá trị trong ngày!", TahomaChiTien, Brushes.Black, 0, loiCO + 10);
            }
            else
            {
                string textCTChietKhauPhanTramT = "giảm giá " + textBox_phanTramTrietKhau.Text + "%";
                e.Graphics.DrawString(textCTChietKhauPhanTramT, Tahoma5, Brushes.Black, xTong, yTong + 15);

                string textCTThanh = "Tổng thanh toán: " + textBox_tongHoaDon.Text + " VND";
                e.Graphics.DrawString(textCTThanh, Tahoma5, Brushes.Black, xTong, yTong + 15 + 15);

                string textDangTT = "Thanh toán: " + comboBox_dangThanhToan.Text;
                e.Graphics.DrawString(textDangTT, Tahoma5, Brushes.Black, xTong, yTong + 15 + 15 + 15);


                float loiCO = yTong + 20 + 15 + 15 + 15 + 12;
                string loiCamOn = "Cảm ơn quý khách đã tin tưởng sử dụng sản phẩm của chúng tôi!";
                e.Graphics.DrawString(loiCamOn, TahomaChiTien, Brushes.Black, 0, loiCO);
                e.Graphics.DrawString("hóa đơn chỉ có giá trị trong ngày!", TahomaChiTien, Brushes.Black, 0, loiCO + 10);
            }

        }

        private void textBox_phanTramTrietKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void comboBox_tenMayIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void comboBox_SDTKhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SDTKhach_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_maThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_maNV_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_danhSachChiTiet.SelectedRows.Count > 0)
            {
                dataGridView_danhSachChiTiet.Rows.RemoveAt(this.dataGridView_danhSachChiTiet.SelectedRows[0].Index);
            }
        }
    }
}
