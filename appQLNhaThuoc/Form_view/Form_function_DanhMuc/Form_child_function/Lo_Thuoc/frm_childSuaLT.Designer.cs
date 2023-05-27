
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Lo_Thuoc
{
    partial class frm_childSuaLT
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
            this.textBox_maSoLo = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngayHH = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngaySX = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.tenHangDuocComboBox = new System.Windows.Forms.ComboBox();
            this.hangDuocPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.textBox_dvSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dvDongGoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dvBaoGo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDongGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViBaoGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_loThuoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loThuoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_maSoLo);
            this.panel1.Controls.Add(this.dateTimePicker_ngayHH);
            this.panel1.Controls.Add(this.dateTimePicker_ngaySX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_GhiChu);
            this.panel1.Controls.Add(this.tenHangDuocComboBox);
            this.panel1.Controls.Add(this.textBox_dvSanPham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_dvDongGoi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_dvBaoGo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 163);
            this.panel1.TabIndex = 0;
            // 
            // textBox_maSoLo
            // 
            this.textBox_maSoLo.Location = new System.Drawing.Point(122, 12);
            this.textBox_maSoLo.Name = "textBox_maSoLo";
            this.textBox_maSoLo.Size = new System.Drawing.Size(146, 23);
            this.textBox_maSoLo.TabIndex = 8;
            // 
            // dateTimePicker_ngayHH
            // 
            this.dateTimePicker_ngayHH.Location = new System.Drawing.Point(432, 56);
            this.dateTimePicker_ngayHH.Name = "dateTimePicker_ngayHH";
            this.dateTimePicker_ngayHH.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker_ngayHH.TabIndex = 19;
            // 
            // dateTimePicker_ngaySX
            // 
            this.dateTimePicker_ngaySX.Location = new System.Drawing.Point(432, 12);
            this.dateTimePicker_ngaySX.Name = "dateTimePicker_ngaySX";
            this.dateTimePicker_ngaySX.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker_ngaySX.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số lô";
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GhiChu.Location = new System.Drawing.Point(122, 87);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(242, 58);
            this.textBox_GhiChu.TabIndex = 15;
            // 
            // tenHangDuocComboBox
            // 
            this.tenHangDuocComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "tenHangDuoc", true));
            this.tenHangDuocComboBox.FormattingEnabled = true;
            this.tenHangDuocComboBox.Location = new System.Drawing.Point(122, 55);
            this.tenHangDuocComboBox.Name = "tenHangDuocComboBox";
            this.tenHangDuocComboBox.Size = new System.Drawing.Size(146, 24);
            this.tenHangDuocComboBox.TabIndex = 17;
            // 
            // hangDuocPhamBindingSource
            // 
            this.hangDuocPhamBindingSource.DataMember = "hangDuocPham";
            this.hangDuocPhamBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_dvSanPham
            // 
            this.textBox_dvSanPham.Location = new System.Drawing.Point(745, 106);
            this.textBox_dvSanPham.Name = "textBox_dvSanPham";
            this.textBox_dvSanPham.Size = new System.Drawing.Size(146, 23);
            this.textBox_dvSanPham.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hãng dược";
            // 
            // textBox_dvDongGoi
            // 
            this.textBox_dvDongGoi.Location = new System.Drawing.Point(745, 59);
            this.textBox_dvDongGoi.Name = "textBox_dvDongGoi";
            this.textBox_dvDongGoi.Size = new System.Drawing.Size(146, 23);
            this.textBox_dvDongGoi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sản xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_dvBaoGo
            // 
            this.textBox_dvBaoGo.Location = new System.Drawing.Point(745, 12);
            this.textBox_dvBaoGo.Name = "textBox_dvBaoGo";
            this.textBox_dvBaoGo.Size = new System.Drawing.Size(146, 23);
            this.textBox_dvBaoGo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hết hạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn vị bao gói";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn vị đống gói";
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // donViSanPham
            // 
            this.donViSanPham.DataPropertyName = "donViSanPham";
            this.donViSanPham.HeaderText = "Đơn vị sản phẩm";
            this.donViSanPham.Name = "donViSanPham";
            // 
            // donViDongGoi
            // 
            this.donViDongGoi.DataPropertyName = "donViDongGoi";
            this.donViDongGoi.HeaderText = "Đơn vị đống gói";
            this.donViDongGoi.Name = "donViDongGoi";
            // 
            // donViBaoGoi
            // 
            this.donViBaoGoi.DataPropertyName = "donViBaoGoi";
            this.donViBaoGoi.HeaderText = "Đơn vị bao gói";
            this.donViBaoGoi.Name = "donViBaoGoi";
            // 
            // ngayHetHang
            // 
            this.ngayHetHang.DataPropertyName = "ngayHetHang";
            this.ngayHetHang.HeaderText = "Ngày hết hạng";
            this.ngayHetHang.Name = "ngayHetHang";
            // 
            // ngaySanXuat
            // 
            this.ngaySanXuat.DataPropertyName = "ngaySanXuat";
            this.ngaySanXuat.HeaderText = "Ngày sản xuất";
            this.ngaySanXuat.Name = "ngaySanXuat";
            // 
            // tenHangDuoc
            // 
            this.tenHangDuoc.DataPropertyName = "tenHangDuoc";
            this.tenHangDuoc.HeaderText = "Tên hãng dược";
            this.tenHangDuoc.Name = "tenHangDuoc";
            // 
            // maSoLo
            // 
            this.maSoLo.DataPropertyName = "maSoLo";
            this.maSoLo.HeaderText = "Mã lô";
            this.maSoLo.Name = "maSoLo";
            // 
            // dataGridView_loThuoc
            // 
            this.dataGridView_loThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_loThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_loThuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_loThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoLo,
            this.tenHangDuoc,
            this.ngaySanXuat,
            this.ngayHetHang,
            this.donViBaoGoi,
            this.donViDongGoi,
            this.donViSanPham,
            this.ghiChu});
            this.dataGridView_loThuoc.Location = new System.Drawing.Point(0, 170);
            this.dataGridView_loThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_loThuoc.Name = "dataGridView_loThuoc";
            this.dataGridView_loThuoc.Size = new System.Drawing.Size(936, 404);
            this.dataGridView_loThuoc.TabIndex = 6;
            this.dataGridView_loThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_loThuoc_CellClick);
            this.dataGridView_loThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_loThuoc_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(356, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 71);
            this.panel2.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 21);
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
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childSuaLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(936, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_loThuoc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaLT";
            this.Text = "Sửa thông tin lô thuốc";
            this.Load += new System.EventHandler(this.frm_childSuaLT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loThuoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDongGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViBaoGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoLo;
        private System.Windows.Forms.DataGridView dataGridView_loThuoc;
        private System.Windows.Forms.TextBox textBox_maSoLo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tenHangDuocComboBox;
        private System.Windows.Forms.BindingSource hangDuocPhamBindingSource;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayHH;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaySX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dvSanPham;
        private System.Windows.Forms.TextBox textBox_dvDongGoi;
        private System.Windows.Forms.TextBox textBox_dvBaoGo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}