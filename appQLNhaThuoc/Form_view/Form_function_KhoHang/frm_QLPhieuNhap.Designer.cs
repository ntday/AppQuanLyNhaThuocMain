﻿
namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    partial class frm_QLPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_nhanVien = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.comboBox_nhaCungCap = new System.Windows.Forms.ComboBox();
            this.comboBox_maPhieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.chiTietKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietKhoTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.chiTietKhoTableAdapter();
            this.phieuNhapThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.phieuNhapThuocTableAdapter();
            this.dataGridView_phieuNhap = new System.Windows.Forms.DataGridView();
            this.maPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapPhieuNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox_nhanVien);
            this.panel1.Controls.Add(this.dateTimePicker_ngayLap);
            this.panel1.Controls.Add(this.comboBox_nhaCungCap);
            this.panel1.Controls.Add(this.comboBox_maPhieu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 113);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(19, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem chi tiết PN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_nhanVien
            // 
            this.comboBox_nhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nhanVien.FormattingEnabled = true;
            this.comboBox_nhanVien.Location = new System.Drawing.Point(1095, 22);
            this.comboBox_nhanVien.Name = "comboBox_nhanVien";
            this.comboBox_nhanVien.Size = new System.Drawing.Size(137, 24);
            this.comboBox_nhanVien.TabIndex = 7;
            // 
            // dateTimePicker_ngayLap
            // 
            this.dateTimePicker_ngayLap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayLap.Location = new System.Drawing.Point(757, 22);
            this.dateTimePicker_ngayLap.Name = "dateTimePicker_ngayLap";
            this.dateTimePicker_ngayLap.Size = new System.Drawing.Size(158, 23);
            this.dateTimePicker_ngayLap.TabIndex = 6;
            // 
            // comboBox_nhaCungCap
            // 
            this.comboBox_nhaCungCap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nhaCungCap.FormattingEnabled = true;
            this.comboBox_nhaCungCap.Location = new System.Drawing.Point(409, 22);
            this.comboBox_nhaCungCap.Name = "comboBox_nhaCungCap";
            this.comboBox_nhaCungCap.Size = new System.Drawing.Size(206, 24);
            this.comboBox_nhaCungCap.TabIndex = 5;
            // 
            // comboBox_maPhieu
            // 
            this.comboBox_maPhieu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maPhieu.FormattingEnabled = true;
            this.comboBox_maPhieu.Location = new System.Drawing.Point(131, 22);
            this.comboBox_maPhieu.Name = "comboBox_maPhieu";
            this.comboBox_maPhieu.Size = new System.Drawing.Size(150, 24);
            this.comboBox_maPhieu.TabIndex = 4;
            this.comboBox_maPhieu.SelectedIndexChanged += new System.EventHandler(this.comboBox_maPhieu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietKhoBindingSource
            // 
            this.chiTietKhoBindingSource.DataMember = "chiTietKho";
            this.chiTietKhoBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // chiTietKhoTableAdapter
            // 
            this.chiTietKhoTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapThuocBindingSource
            // 
            this.phieuNhapThuocBindingSource.DataMember = "phieuNhapThuoc";
            this.phieuNhapThuocBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // phieuNhapThuocTableAdapter
            // 
            this.phieuNhapThuocTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_phieuNhap
            // 
            this.dataGridView_phieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_phieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_phieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNT,
            this.tenNhaCungCap,
            this.ngayLapPhieuNT,
            this.maNV,
            this.hoVaTen,
            this.ghiChu});
            this.dataGridView_phieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_phieuNhap.Location = new System.Drawing.Point(0, 113);
            this.dataGridView_phieuNhap.Name = "dataGridView_phieuNhap";
            this.dataGridView_phieuNhap.Size = new System.Drawing.Size(1280, 620);
            this.dataGridView_phieuNhap.TabIndex = 1;
            this.dataGridView_phieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_phieuNhap_CellClick);
            this.dataGridView_phieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_phieuNhap_CellContentClick);
            // 
            // maPNT
            // 
            this.maPNT.DataPropertyName = "maPNT";
            this.maPNT.HeaderText = "Mã phiếu nhập";
            this.maPNT.Name = "maPNT";
            // 
            // tenNhaCungCap
            // 
            this.tenNhaCungCap.DataPropertyName = "tenNhaCungCap";
            this.tenNhaCungCap.HeaderText = "Nhà cung cấp";
            this.tenNhaCungCap.Name = "tenNhaCungCap";
            // 
            // ngayLapPhieuNT
            // 
            this.ngayLapPhieuNT.DataPropertyName = "ngayLapPhieuNT";
            this.ngayLapPhieuNT.HeaderText = "Ngày lập phiếu";
            this.ngayLapPhieuNT.Name = "ngayLapPhieuNT";
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // hoVaTen
            // 
            this.hoVaTen.DataPropertyName = "hoVaTen";
            this.hoVaTen.HeaderText = "Họ và tên nv";
            this.hoVaTen.Name = "hoVaTen";
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bangSoLuongTamTableAdapter = null;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietKhoTableAdapter = this.chiTietKhoTableAdapter;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepXuatTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.giaDonHangTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = null;
            this.tableAdapterManager.hoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.khoTableAdapter = null;
            this.tableAdapterManager.khuyenMaiTableAdapter = null;
            this.tableAdapterManager.loThuocTableAdapter = null;
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = null;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.nhomThuocTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = this.phieuNhapThuocTableAdapter;
            this.tableAdapterManager.phieuXuatThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_QLPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1280, 733);
            this.Controls.Add(this.dataGridView_phieuNhap);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLPhieuNhap";
            this.Text = "Quản lý phiếu nhập";
            this.Load += new System.EventHandler(this.frm_QLPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_nhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayLap;
        private System.Windows.Forms.ComboBox comboBox_nhaCungCap;
        private System.Windows.Forms.ComboBox comboBox_maPhieu;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource chiTietKhoBindingSource;
        private QLNhaThuocDataSetTableAdapters.chiTietKhoTableAdapter chiTietKhoTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.phieuNhapThuocTableAdapter phieuNhapThuocTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_phieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapPhieuNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.Button button1;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}