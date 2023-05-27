using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    public partial class frm_QLTinhTrangHang : Form
    {
        Kho kho = new Kho();
        public frm_QLTinhTrangHang()
        {
            InitializeComponent();
        }

        public void loadDSTinhTrang()
        {
            DataTable table = kho.layDanhSachTinhTrang();
            int n = table.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                string maThuoc = table.Rows[i]["maThuoc"].ToString();
                string tenThuoc = table.Rows[i]["tenThuoc"].ToString();
                string maSoLo = table.Rows[i]["maSoLo"].ToString();
                string ngaySanXuat = table.Rows[i]["ngaySanXuat"].ToString();
                string ngayHetHan = table.Rows[i]["ngayHetHang"].ToString();
                string soLuong = table.Rows[i]["soLuong"].ToString();
                string tenDVT = table.Rows[i]["tenDVT"].ToString();
                string tinhTrangTonHang, tinhTrangHangDung;

                try
                {
                    if (int.Parse(soLuong) <= 0 || soLuong.Length <= 0 || soLuong is null || soLuong == "") tinhTrangTonHang = "hàng đã hết ";
                    else if (int.Parse(soLuong) > 0 && int.Parse(soLuong) < 5) tinhTrangTonHang = "hàng sắp hết, còn lại " + soLuong;
                    else tinhTrangTonHang = "OK";
                }
                catch (Exception)
                {
                    tinhTrangTonHang = "chưa nhập hàng";
                }

                try
                {
                    DateTime ngayThang = DateTime.ParseExact(ngayHetHan, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    TimeSpan soNgayConLai = ngayThang.Subtract(DateTime.Now);
                    tinhTrangHangDung = "hạng dùng còn " + soNgayConLai.Days + " ngày" ;
                }
                catch (Exception)
                {
                    tinhTrangHangDung = "chưa nhập hàng";
                }

                dataGridView1_tableTinhTrang.Rows.Add(maThuoc, tenThuoc, maSoLo, ngaySanXuat, ngayHetHan, soLuong, tenDVT, tinhTrangHangDung, tinhTrangTonHang);
            }
        }

        private void frm_QLTinhTrangHang_Load(object sender, EventArgs e)
        {
            loadDSTinhTrang();
        }

        private void textBox1_maThuoc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1_tableTinhTrang.Rows.Clear();
            string textCheck = textBox1_maThuoc.Text.Trim();
            DataTable table = kho.layDanhSachTinhTrangTheoMa(textCheck);
            int n = table.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                string maThuoc = table.Rows[i]["maThuoc"].ToString();
                string tenThuoc = table.Rows[i]["tenThuoc"].ToString();
                string maSoLo = table.Rows[i]["maSoLo"].ToString();
                string ngaySanXuat = table.Rows[i]["ngaySanXuat"].ToString();
                string ngayHetHan = table.Rows[i]["ngayHetHang"].ToString();
                string soLuong = table.Rows[i]["soLuong"].ToString();
                string tenDVT = table.Rows[i]["tenDVT"].ToString();
                string tinhTrangTonHang, tinhTrangHangDung;


                try
                {
                    if (int.Parse(soLuong) <= 0 || soLuong.Length <= 0 || soLuong is null || soLuong == "") tinhTrangTonHang = "hàng đã hết ";
                    else if (int.Parse(soLuong) > 0 && int.Parse(soLuong) < 5) tinhTrangTonHang = "hàng sắp hết, còn lại " + soLuong;
                    else tinhTrangTonHang = "OK";
                }
                catch (Exception)
                {
                    tinhTrangTonHang = "chưa nhập hàng";
                }

                try
                {
                    DateTime ngayThang = DateTime.ParseExact(ngayHetHan, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    TimeSpan soNgayConLai = ngayThang.Subtract(DateTime.Now);
                    tinhTrangHangDung = "hạng dùng còn " + soNgayConLai.Days + " ngày";
                }
                catch (Exception)
                {
                    tinhTrangHangDung = "chưa nhập hàng";
                }

                dataGridView1_tableTinhTrang.Rows.Add(maThuoc, tenThuoc, maSoLo, ngaySanXuat, ngayHetHan, soLuong, tenDVT, tinhTrangHangDung, tinhTrangTonHang);
            }
        }

        private void textBox1_tenThuoc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1_tableTinhTrang.Rows.Clear();
            string textCheck = textBox1_tenThuoc.Text.Trim();
            DataTable table = kho.layDanhSachTinhTrangTheoTen (textCheck);
            int n = table.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                string maThuoc = table.Rows[i]["maThuoc"].ToString();
                string tenThuoc = table.Rows[i]["tenThuoc"].ToString();
                string maSoLo = table.Rows[i]["maSoLo"].ToString();
                string ngaySanXuat = table.Rows[i]["ngaySanXuat"].ToString();
                string ngayHetHan = table.Rows[i]["ngayHetHang"].ToString();
                string soLuong = table.Rows[i]["soLuong"].ToString();
                string tenDVT = table.Rows[i]["tenDVT"].ToString();
                string tinhTrangTonHang, tinhTrangHangDung;

                try
                {
                    if (int.Parse(soLuong) <= 0 || soLuong.Length <= 0 || soLuong is null || soLuong == "") tinhTrangTonHang = "hàng đã hết ";
                    else if (int.Parse(soLuong) > 0 && int.Parse(soLuong) < 5) tinhTrangTonHang = "hàng sắp hết, còn lại " + soLuong;
                    else tinhTrangTonHang = "OK";
                }
                catch (Exception)
                {
                    tinhTrangTonHang = "chưa nhập hàng";
                }

                try
                {
                    DateTime ngayThang = DateTime.ParseExact(ngayHetHan, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    TimeSpan soNgayConLai = ngayThang.Subtract(DateTime.Now);

                    if (soNgayConLai.Days <= 0)
                    {
                        tinhTrangHangDung = "đã hết hạng " + soNgayConLai.Days + " ngày";
                    }
                    else
                    {
                        tinhTrangHangDung = "hạng dùng còn " + soNgayConLai.Days + " ngày";
                    }

                }
                catch (Exception)
                {
                    tinhTrangHangDung = "chưa nhập hàng";
                }

                dataGridView1_tableTinhTrang.Rows.Add(maThuoc, tenThuoc, maSoLo, ngaySanXuat, ngayHetHan, soLuong, tenDVT, tinhTrangHangDung, tinhTrangTonHang);
            }
        }
    }
}
