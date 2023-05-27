
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc
{
    partial class frm_childThemLT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.hangDuocPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangDuocPhamTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker_ngaySX = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngayHH = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tenHangDuocComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_maSoLo = new System.Windows.Forms.TextBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.donViTinhTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_dvBaoGo = new System.Windows.Forms.ComboBox();
            this.textBox_dvDongGoi = new System.Windows.Forms.ComboBox();
            this.textBox_dvSanPham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hãng dược";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sản xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn vị bao gói";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn vị đống gói";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị sản phẩm";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangDuocPhamBindingSource
            // 
            this.hangDuocPhamBindingSource.DataMember = "hangDuocPham";
            this.hangDuocPhamBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // hangDuocPhamTableAdapter
            // 
            this.hangDuocPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = this.hangDuocPhamTableAdapter;
            this.tableAdapterManager.hoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.khuyenMaiTableAdapter = null;
            this.tableAdapterManager.loThuocTableAdapter = null;
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = null;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.nhomThuocTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker_ngaySX
            // 
            this.dateTimePicker_ngaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaySX.Location = new System.Drawing.Point(130, 107);
            this.dateTimePicker_ngaySX.Name = "dateTimePicker_ngaySX";
            this.dateTimePicker_ngaySX.Size = new System.Drawing.Size(117, 23);
            this.dateTimePicker_ngaySX.TabIndex = 18;
            // 
            // dateTimePicker_ngayHH
            // 
            this.dateTimePicker_ngayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayHH.Location = new System.Drawing.Point(130, 154);
            this.dateTimePicker_ngayHH.Name = "dateTimePicker_ngayHH";
            this.dateTimePicker_ngayHH.Size = new System.Drawing.Size(117, 23);
            this.dateTimePicker_ngayHH.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(98, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 71);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tenHangDuocComboBox
            // 
            this.tenHangDuocComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "tenHangDuoc", true));
            this.tenHangDuocComboBox.FormattingEnabled = true;
            this.tenHangDuocComboBox.Location = new System.Drawing.Point(130, 59);
            this.tenHangDuocComboBox.Name = "tenHangDuocComboBox";
            this.tenHangDuocComboBox.Size = new System.Drawing.Size(168, 24);
            this.tenHangDuocComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số lô";
            // 
            // textBox_maSoLo
            // 
            this.textBox_maSoLo.Location = new System.Drawing.Point(130, 12);
            this.textBox_maSoLo.Name = "textBox_maSoLo";
            this.textBox_maSoLo.Size = new System.Drawing.Size(168, 23);
            this.textBox_maSoLo.TabIndex = 8;
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GhiChu.Location = new System.Drawing.Point(130, 341);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(242, 58);
            this.textBox_GhiChu.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ghi chú";
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "donViTinh";
            this.donViTinhBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 118);
            this.button3.TabIndex = 26;
            this.button3.Text = "Thêm nhanh đơn vị tính";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_dvBaoGo
            // 
            this.textBox_dvBaoGo.FormattingEnabled = true;
            this.textBox_dvBaoGo.Location = new System.Drawing.Point(128, 204);
            this.textBox_dvBaoGo.Name = "textBox_dvBaoGo";
            this.textBox_dvBaoGo.Size = new System.Drawing.Size(130, 24);
            this.textBox_dvBaoGo.TabIndex = 27;
            this.textBox_dvBaoGo.SelectedIndexChanged += new System.EventHandler(this.textBox_dvBaoGo_SelectedIndexChanged);
            // 
            // textBox_dvDongGoi
            // 
            this.textBox_dvDongGoi.FormattingEnabled = true;
            this.textBox_dvDongGoi.Location = new System.Drawing.Point(128, 249);
            this.textBox_dvDongGoi.Name = "textBox_dvDongGoi";
            this.textBox_dvDongGoi.Size = new System.Drawing.Size(130, 24);
            this.textBox_dvDongGoi.TabIndex = 28;
            // 
            // textBox_dvSanPham
            // 
            this.textBox_dvSanPham.FormattingEnabled = true;
            this.textBox_dvSanPham.Location = new System.Drawing.Point(128, 295);
            this.textBox_dvSanPham.Name = "textBox_dvSanPham";
            this.textBox_dvSanPham.Size = new System.Drawing.Size(130, 24);
            this.textBox_dvSanPham.TabIndex = 29;
            // 
            // frm_childThemLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 516);
            this.Controls.Add(this.textBox_dvSanPham);
            this.Controls.Add(this.textBox_dvDongGoi);
            this.Controls.Add(this.textBox_dvBaoGo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_GhiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_ngayHH);
            this.Controls.Add(this.dateTimePicker_ngaySX);
            this.Controls.Add(this.tenHangDuocComboBox);
            this.Controls.Add(this.textBox_maSoLo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemLT";
            this.Text = "Thêm thông tin lô thuốc";
            this.Load += new System.EventHandler(this.frm_childThemLT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource hangDuocPhamBindingSource;
        private QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter hangDuocPhamTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaySX;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayHH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tenHangDuocComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_maSoLo;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private QLNhaThuocDataSetTableAdapters.donViTinhTableAdapter donViTinhTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox textBox_dvBaoGo;
        private System.Windows.Forms.ComboBox textBox_dvDongGoi;
        private System.Windows.Forms.ComboBox textBox_dvSanPham;
    }
}