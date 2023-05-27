
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai
{
    partial class frm_childXoaKM
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
            this.button2 = new System.Windows.Forms.Button();
            this.dangKhuyenMaiTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.dangKhuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_dangKhuyenMai = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.textBox_tenKhuyenMai = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.textBox_maDonKM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_khuyenMai = new System.Windows.Forms.DataGridView();
            this.maKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dangKhuyenMaiTableAdapter
            // 
            this.dangKhuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(370, 540);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 92);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangKhuyenMaiBindingSource
            // 
            this.dangKhuyenMaiBindingSource.DataMember = "DangKhuyenMai";
            this.dangKhuyenMaiBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // comboBox_dangKhuyenMai
            // 
            this.comboBox_dangKhuyenMai.DataSource = this.dangKhuyenMaiBindingSource;
            this.comboBox_dangKhuyenMai.DisplayMember = "tenDangKM";
            this.comboBox_dangKhuyenMai.FormattingEnabled = true;
            this.comboBox_dangKhuyenMai.Location = new System.Drawing.Point(799, 104);
            this.comboBox_dangKhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_dangKhuyenMai.Name = "comboBox_dangKhuyenMai";
            this.comboBox_dangKhuyenMai.Size = new System.Drawing.Size(127, 24);
            this.comboBox_dangKhuyenMai.TabIndex = 11;
            this.comboBox_dangKhuyenMai.ValueMember = "tenDangKM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_dangKhuyenMai);
            this.panel1.Controls.Add(this.textBox_soLuong);
            this.panel1.Controls.Add(this.textBox_tenKhuyenMai);
            this.panel1.Controls.Add(this.dateTimePicker_ngayKetThuc);
            this.panel1.Controls.Add(this.dateTimePicker_ngayBatDau);
            this.panel1.Controls.Add(this.textBox_maDonKM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 146);
            this.panel1.TabIndex = 13;
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.Location = new System.Drawing.Point(810, 17);
            this.textBox_soLuong.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(107, 23);
            this.textBox_soLuong.TabIndex = 10;
            // 
            // textBox_tenKhuyenMai
            // 
            this.textBox_tenKhuyenMai.Location = new System.Drawing.Point(472, 17);
            this.textBox_tenKhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tenKhuyenMai.Name = "textBox_tenKhuyenMai";
            this.textBox_tenKhuyenMai.Size = new System.Drawing.Size(159, 23);
            this.textBox_tenKhuyenMai.TabIndex = 9;
            // 
            // dateTimePicker_ngayKetThuc
            // 
            this.dateTimePicker_ngayKetThuc.Location = new System.Drawing.Point(472, 105);
            this.dateTimePicker_ngayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_ngayKetThuc.Name = "dateTimePicker_ngayKetThuc";
            this.dateTimePicker_ngayKetThuc.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker_ngayKetThuc.TabIndex = 8;
            // 
            // dateTimePicker_ngayBatDau
            // 
            this.dateTimePicker_ngayBatDau.Location = new System.Drawing.Point(143, 105);
            this.dateTimePicker_ngayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_ngayBatDau.Name = "dateTimePicker_ngayBatDau";
            this.dateTimePicker_ngayBatDau.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker_ngayBatDau.TabIndex = 7;
            // 
            // textBox_maDonKM
            // 
            this.textBox_maDonKM.Location = new System.Drawing.Point(143, 17);
            this.textBox_maDonKM.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_maDonKM.Name = "textBox_maDonKM";
            this.textBox_maDonKM.ReadOnly = true;
            this.textBox_maDonKM.Size = new System.Drawing.Size(99, 23);
            this.textBox_maDonKM.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "dạng khuyến mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng giới hạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đợt khuyến mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt khuyến mãi";
            // 
            // dataGridView_khuyenMai
            // 
            this.dataGridView_khuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_khuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_khuyenMai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_khuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKM,
            this.TenKM,
            this.ngayBatDau,
            this.ngayKetThuc,
            this.soLuong,
            this.tenDangKM});
            this.dataGridView_khuyenMai.Location = new System.Drawing.Point(-1, 151);
            this.dataGridView_khuyenMai.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_khuyenMai.Name = "dataGridView_khuyenMai";
            this.dataGridView_khuyenMai.Size = new System.Drawing.Size(962, 376);
            this.dataGridView_khuyenMai.TabIndex = 12;
            this.dataGridView_khuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khuyenMai_CellClick);
            this.dataGridView_khuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khuyenMai_CellContentClick);
            // 
            // maKM
            // 
            this.maKM.DataPropertyName = "maKM";
            this.maKM.HeaderText = "Mã đợt khuyến mãi";
            this.maKM.Name = "maKM";
            // 
            // TenKM
            // 
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.HeaderText = "Tên đợt khuyến mãi";
            this.TenKM.Name = "TenKM";
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            this.ngayBatDau.HeaderText = "Thời gian bắt đầu";
            this.ngayBatDau.Name = "ngayBatDau";
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.DataPropertyName = "ngayKetThuc";
            this.ngayKetThuc.HeaderText = "Thời gian kết thúc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "số lượng giới hạn";
            this.soLuong.Name = "soLuong";
            // 
            // tenDangKM
            // 
            this.tenDangKM.DataPropertyName = "tenDangKM";
            this.tenDangKM.HeaderText = "Dạng khuyến mãi";
            this.tenDangKM.Name = "tenDangKM";
            // 
            // frm_childXoaKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(962, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_khuyenMai);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaKM";
            this.Text = "frm_childXoaKM";
            this.Load += new System.EventHandler(this.frm_childXoaKM_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khuyenMai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter dangKhuyenMaiTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangKhuyenMaiBindingSource;
        private System.Windows.Forms.ComboBox comboBox_dangKhuyenMai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.TextBox textBox_tenKhuyenMai;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayBatDau;
        private System.Windows.Forms.TextBox textBox_maDonKM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_khuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangKM;
    }
}