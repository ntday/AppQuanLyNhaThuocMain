using appQLNhaThuoc.Obj_Model;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace appQLNhaThuoc.Form_view.Form_function_BanHang
{
    public partial class frm_QLHoaDonBanLe : Form
    {

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
        NhanVien nv = new NhanVien();

        string maNhanVienDN;
        string hoTenNVDN;


        public frm_QLHoaDonBanLe()
        {
            InitializeComponent();
        }



        public void layThongTinNhanhVien()
        {

            DataTable table = nv.layDanhSachNhanVien();
            comboBox1_maNhanVien.DataSource = table;
            comboBox1_maNhanVien.DisplayMember = "maNV";
            comboBox1_maNhanVien.ValueMember = "maNV";

            comboBox2_tenNhanVien.DataSource = table;
            comboBox2_tenNhanVien.DisplayMember = "hoVaTen";
            comboBox2_tenNhanVien.ValueMember = "hoVaTen";



        }

        public void layThongTinKhach()
        {
            DataTable tableKH = kh.layDangSachKhachHang();
            comboBox4_sdtKhach.DataSource = tableKH;
            comboBox4_sdtKhach.DisplayMember = "sdtKH";
            comboBox4_sdtKhach.ValueMember = "sdtKH";

            comboBox3_tenKhach.DataSource = tableKH;
            comboBox3_tenKhach.DisplayMember = "tenKH";
            comboBox3_tenKhach.ValueMember = "tenKH";
        }

        public void layDanhSachHoaDon()
        {
            DataTable table = hoadon.layDanhSachHoaDon();
            DataTable tableTam = new DataTable();
            // dataGridView1_hoaDon.DataSource = hoadon.layDanhSachHoaDon();
            int n = table.Rows.Count ;

            tableTam.Columns.AddRange(new DataColumn[] {
    new DataColumn("maHoaDon"),
    new DataColumn("ngayLapHoaDon"),
    new DataColumn("maNV"),
    new DataColumn("hoVaTen"),
    new DataColumn("sdtKH"),
    new DataColumn("tenKH"),
    new DataColumn("TenDangTT"),
    new DataColumn("TenKM"),
    new DataColumn("ghiChu"),
    new DataColumn("TongHoaDon") });

            for (int i = 0; i < n; i++)
            {

                string maHoaDon = table.Rows[i]["maHoaDon"].ToString();
                string ngayLapHoaDon = table.Rows[i]["ngayLapHoaDon"].ToString();
                string maNV = table.Rows[i]["maNV"].ToString();
                string hoVaTen = table.Rows[i]["hoVaTen"].ToString();
                string sdtKH = table.Rows[i]["sdtKH"].ToString();
                string tenKH = table.Rows[i]["tenKH"].ToString();
                string TenDangTT = table.Rows[i]["TenDangTT"].ToString();
                string TenKM = table.Rows[i]["TenKM"].ToString();
                string ghiChu = table.Rows[i]["ghiChu"].ToString();
                string TongHoaDon = hoadon.layDanhSachTongGiaTheoHoaDon(table.Rows[i]["maHoaDon"].ToString());

                if (TenKM.Length <= 0) TenKM = "";

                tableTam.Rows.Add(maHoaDon, ngayLapHoaDon, maNV, hoVaTen, sdtKH, tenKH, TenDangTT, TenKM, ghiChu, TongHoaDon);
            }
            dataGridView1_hoaDon.DataSource = tableTam;

            int m = dataGridView1_hoaDon.Rows.Count;
            double sum=0;
            for (int i = 0; i<m; i++)
            {

                sum = sum + double.Parse(tableTam.Rows[i]["TongHoaDon"].ToString());
            }

            string didangChuoi = sum.ToString("N3").Remove(sum.ToString("N3").IndexOf('.'));
            label10_sum.Text = didangChuoi;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable table = hoadon.layDanhSachHoaDon();
            DataTable tableTam = new DataTable();
            // dataGridView1_hoaDon.DataSource = hoadon.layDanhSachHoaDon();
            int n = table.Rows.Count - 1;
            string textMHD = textBox1_maHoaDon.Text;
            tableTam.Columns.AddRange(new DataColumn[] {
    new DataColumn("maHoaDon"),
    new DataColumn("ngayLapHoaDon"),
    new DataColumn("maNV"),
    new DataColumn("hoVaTen"),
    new DataColumn("sdtKH"),
    new DataColumn("tenKH"),
    new DataColumn("TenDangTT"),
    new DataColumn("TenKM"),
    new DataColumn("ghiChu"),
    new DataColumn("TongHoaDon") });

            for (int i = 0; i < n; i++)
            {
                if (table.Rows[i]["maHoaDon"].ToString().ToLower().IndexOf(textMHD.ToLower()) >= 1)
                {
                    string maHoaDon = table.Rows[i]["maHoaDon"].ToString();
                    string ngayLapHoaDon = table.Rows[i]["ngayLapHoaDon"].ToString();
                    string maNV = table.Rows[i]["maNV"].ToString();
                    string hoVaTen = table.Rows[i]["hoVaTen"].ToString();
                    string sdtKH = table.Rows[i]["sdtKH"].ToString();
                    string tenKH = table.Rows[i]["tenKH"].ToString();
                    string TenDangTT = table.Rows[i]["TenDangTT"].ToString();
                    string TenKM = table.Rows[i]["TenKM"].ToString();
                    string ghiChu = table.Rows[i]["TenKM"].ToString();
                    string TongHoaDon = hoadon.layDanhSachTongGiaTheoHoaDon(table.Rows[i]["maHoaDon"].ToString());

                    tableTam.Rows.Add(maHoaDon, ngayLapHoaDon, maNV, hoVaTen, sdtKH, tenKH, TenDangTT, TenKM, ghiChu, TongHoaDon);
                }
                else if (textMHD.Length <= 0 || textMHD == "")
                {
                    string maHoaDon = table.Rows[i]["maHoaDon"].ToString();
                    string ngayLapHoaDon = table.Rows[i]["ngayLapHoaDon"].ToString();
                    string maNV = table.Rows[i]["maNV"].ToString();
                    string hoVaTen = table.Rows[i]["hoVaTen"].ToString();
                    string sdtKH = table.Rows[i]["sdtKH"].ToString();
                    string tenKH = table.Rows[i]["tenKH"].ToString();
                    string TenDangTT = table.Rows[i]["TenDangTT"].ToString();
                    string TenKM = table.Rows[i]["TenKM"].ToString();
                    string ghiChu = table.Rows[i]["TenKM"].ToString();
                    string TongHoaDon = hoadon.layDanhSachTongGiaTheoHoaDon(table.Rows[i]["maHoaDon"].ToString());

                    tableTam.Rows.Add(maHoaDon, ngayLapHoaDon, maNV, hoVaTen, sdtKH, tenKH, TenDangTT, TenKM, ghiChu, TongHoaDon);
                }

            }
            dataGridView1_hoaDon.DataSource = tableTam;

        }

        private void frm_QLHoaDonBanLe_Load(object sender, EventArgs e)
        {
            layThongTinKhach();
            layThongTinNhanhVien();
            layDanhSachHoaDon();
        }

        private void comboBox1_maNhanVien_TextChanged(object sender, EventArgs e)
        {
            DataTable table = hoadon.layDanhSachHoaDon();
            // dataGridView1_hoaDon.DataSource = hoadon.layDanhSachHoaDon();
            int n = dataGridView1_hoaDon.Rows.Count - 1;
            string textCheck = comboBox1_maNhanVien.Text;

            for (int i = 0; i < n; i++)
            {
                if (table.Rows[i]["maNV"].ToString() != textCheck)
                {
                    dataGridView1_hoaDon.Rows.RemoveAt(i);
                }
                else if (textCheck.Length <= 0 || textCheck == "")
                {
                    layDanhSachHoaDon();
                }

            }
        }

        private void comboBox1_maNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_tenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            layThongTinKhach();
            layThongTinNhanhVien();
            layDanhSachHoaDon();
            textBox1_maHoaDon.Text = "";
        }

        private void comboBox1_maNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_sdtKhach_TextChanged(object sender, EventArgs e)
        {

            DataTable table = hoadon.layDanhSachHoaDon();

            int n = dataGridView1_hoaDon.Rows.Count - 1;
            string textCheck = comboBox4_sdtKhach.Text;



        }

        private void comboBox4_sdtKhach_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


             DateTime startDate = DateTime.ParseExact(dateTimePicker1_tuNgay.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
             DateTime endDate = DateTime.ParseExact(dateTimePicker2_denNgay.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Console.WriteLine(date.ToString("dd/MM/yyyy"));
            DataTable table = hoadon.layDanhSachHoaDon();
            DataTable tableTam = new DataTable();
            // dataGridView1_hoaDon.DataSource = hoadon.layDanhSachHoaDon();
            int n = table.Rows.Count - 1;
            string textCheck = comboBox4_sdtKhach.Text;
            tableTam.Columns.AddRange(new DataColumn[] {
                new DataColumn("maHoaDon"),
                new DataColumn("ngayLapHoaDon"),
                new DataColumn("maNV"),
                new DataColumn("hoVaTen"),
                new DataColumn("sdtKH"),
                new DataColumn("tenKH"),
                new DataColumn("TenDangTT"),
                new DataColumn("TenKM"),
                new DataColumn("ghiChu"),
                new DataColumn("TongHoaDon") });


            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {

                for (int i = 0; i < n; i++)
                {
                    string tamdate = table.Rows[i]["ngayLapHoaDon"].ToString();


                    DateTime dateTam = DateTime.ParseExact(tamdate, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    string ngay = dateTam.ToString("dd/MM/yyyy");

                    DateTime date1 = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                   // DateTime date2 = DateTime.ParseExact(date.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    int result = DateTime.Compare(date1, date);

                    if (result==0)
                    {
                        string maHoaDon = table.Rows[i]["maHoaDon"].ToString();
                        string ngayLapHoaDon = table.Rows[i]["ngayLapHoaDon"].ToString();
                        string maNV = table.Rows[i]["maNV"].ToString();
                        string hoVaTen = table.Rows[i]["hoVaTen"].ToString();
                        string sdtKH = table.Rows[i]["sdtKH"].ToString();
                        string tenKH = table.Rows[i]["tenKH"].ToString();
                        string TenDangTT = table.Rows[i]["TenDangTT"].ToString();
                        string TenKM = table.Rows[i]["TenKM"].ToString();
                        string ghiChu = table.Rows[i]["TenKM"].ToString();
                        string TongHoaDon = hoadon.layDanhSachTongGiaTheoHoaDon(table.Rows[i]["maHoaDon"].ToString());

                        tableTam.Rows.Add(maHoaDon, ngayLapHoaDon, maNV, hoVaTen, sdtKH, tenKH, TenDangTT, TenKM, ghiChu, TongHoaDon);
                    }
                }
            }
            dataGridView1_hoaDon.DataSource = tableTam;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
