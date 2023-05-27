
namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    partial class frm_PhanQuyen
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label tenDNLabel;
            System.Windows.Forms.Label hoVaTenLabel;
            System.Windows.Forms.Label sdtNVLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhanVienTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox_manv = new System.Windows.Forms.ComboBox();
            this.comboBox_tenNV = new System.Windows.Forms.ComboBox();
            this.comboBox_hoTenNV = new System.Windows.Forms.ComboBox();
            this.comboBox_sdtNV = new System.Windows.Forms.ComboBox();
            maNVLabel = new System.Windows.Forms.Label();
            tenDNLabel = new System.Windows.Forms.Label();
            hoVaTenLabel = new System.Windows.Forms.Label();
            sdtNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "nhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bangSoLuongTamTableAdapter = null;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietKhoTableAdapter = null;
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
            this.tableAdapterManager.nhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.nhomThuocTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.phieuXuatThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(35, 22);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(99, 16);
            maNVLabel.TabIndex = 1;
            maNVLabel.Text = "Mã nhân viên:";
            // 
            // tenDNLabel
            // 
            tenDNLabel.AutoSize = true;
            tenDNLabel.Location = new System.Drawing.Point(31, 70);
            tenDNLabel.Name = "tenDNLabel";
            tenDNLabel.Size = new System.Drawing.Size(103, 16);
            tenDNLabel.TabIndex = 2;
            tenDNLabel.Text = "Tên đăng nhập";
            // 
            // hoVaTenLabel
            // 
            hoVaTenLabel.AutoSize = true;
            hoVaTenLabel.Location = new System.Drawing.Point(63, 118);
            hoVaTenLabel.Name = "hoVaTenLabel";
            hoVaTenLabel.Size = new System.Drawing.Size(71, 16);
            hoVaTenLabel.TabIndex = 4;
            hoVaTenLabel.Text = "Họ và tên";
            // 
            // sdtNVLabel
            // 
            sdtNVLabel.AutoSize = true;
            sdtNVLabel.Location = new System.Drawing.Point(42, 166);
            sdtNVLabel.Name = "sdtNVLabel";
            sdtNVLabel.Size = new System.Drawing.Size(92, 16);
            sdtNVLabel.TabIndex = 6;
            sdtNVLabel.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 174);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền Hạ quyền";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(41, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quản lý \"Admin\"";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(41, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nhân viên \"User\"";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lưu thay đổi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(41, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Chặn truy cập";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox_manv
            // 
            this.comboBox_manv.FormattingEnabled = true;
            this.comboBox_manv.Location = new System.Drawing.Point(141, 22);
            this.comboBox_manv.Name = "comboBox_manv";
            this.comboBox_manv.Size = new System.Drawing.Size(152, 24);
            this.comboBox_manv.TabIndex = 11;
            this.comboBox_manv.SelectedIndexChanged += new System.EventHandler(this.comboBox_manv_SelectedIndexChanged);
            this.comboBox_manv.SelectionChangeCommitted += new System.EventHandler(this.comboBox_manv_SelectionChangeCommitted);
            this.comboBox_manv.ValueMemberChanged += new System.EventHandler(this.comboBox_manv_ValueMemberChanged);
            // 
            // comboBox_tenNV
            // 
            this.comboBox_tenNV.FormattingEnabled = true;
            this.comboBox_tenNV.Location = new System.Drawing.Point(141, 67);
            this.comboBox_tenNV.Name = "comboBox_tenNV";
            this.comboBox_tenNV.Size = new System.Drawing.Size(152, 24);
            this.comboBox_tenNV.TabIndex = 12;
            this.comboBox_tenNV.SelectionChangeCommitted += new System.EventHandler(this.comboBox_tenNV_SelectionChangeCommitted);
            // 
            // comboBox_hoTenNV
            // 
            this.comboBox_hoTenNV.FormattingEnabled = true;
            this.comboBox_hoTenNV.Location = new System.Drawing.Point(141, 112);
            this.comboBox_hoTenNV.Name = "comboBox_hoTenNV";
            this.comboBox_hoTenNV.Size = new System.Drawing.Size(152, 24);
            this.comboBox_hoTenNV.TabIndex = 13;
            this.comboBox_hoTenNV.SelectionChangeCommitted += new System.EventHandler(this.comboBox_hoTenNV_SelectionChangeCommitted);
            // 
            // comboBox_sdtNV
            // 
            this.comboBox_sdtNV.FormattingEnabled = true;
            this.comboBox_sdtNV.Location = new System.Drawing.Point(141, 157);
            this.comboBox_sdtNV.Name = "comboBox_sdtNV";
            this.comboBox_sdtNV.Size = new System.Drawing.Size(152, 24);
            this.comboBox_sdtNV.TabIndex = 14;
            this.comboBox_sdtNV.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sdtNV_SelectionChangeCommitted);
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 286);
            this.Controls.Add(this.comboBox_sdtNV);
            this.Controls.Add(this.comboBox_hoTenNV);
            this.Controls.Add(this.comboBox_tenNV);
            this.Controls.Add(this.comboBox_manv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(sdtNVLabel);
            this.Controls.Add(hoVaTenLabel);
            this.Controls.Add(tenDNLabel);
            this.Controls.Add(maNVLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PhanQuyen";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNhaThuocDataSetTableAdapters.nhanVienTableAdapter nhanVienTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_manv;
        private System.Windows.Forms.ComboBox comboBox_tenNV;
        private System.Windows.Forms.ComboBox comboBox_hoTenNV;
        private System.Windows.Forms.ComboBox comboBox_sdtNV;
    }
}