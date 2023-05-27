
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai
{
    partial class frm_childSuaKM
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
            this.dataGridView_khuyenMai = new System.Windows.Forms.DataGridView();
            this.maKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_dangKhuyenMai = new System.Windows.Forms.ComboBox();
            this.dangKhuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
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
            this.dangKhuyenMaiTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khuyenMai)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_khuyenMai
            // 
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
            this.dataGridView_khuyenMai.Location = new System.Drawing.Point(2, 149);
            this.dataGridView_khuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_khuyenMai.Name = "dataGridView_khuyenMai";
            this.dataGridView_khuyenMai.Size = new System.Drawing.Size(906, 454);
            this.dataGridView_khuyenMai.TabIndex = 5;
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 142);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox_dangKhuyenMai
            // 
            this.comboBox_dangKhuyenMai.DataSource = this.dangKhuyenMaiBindingSource;
            this.comboBox_dangKhuyenMai.DisplayMember = "tenDangKM";
            this.comboBox_dangKhuyenMai.FormattingEnabled = true;
            this.comboBox_dangKhuyenMai.Location = new System.Drawing.Point(771, 84);
            this.comboBox_dangKhuyenMai.Name = "comboBox_dangKhuyenMai";
            this.comboBox_dangKhuyenMai.Size = new System.Drawing.Size(121, 24);
            this.comboBox_dangKhuyenMai.TabIndex = 11;
            this.comboBox_dangKhuyenMai.ValueMember = "tenDangKM";
            this.comboBox_dangKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.comboBox_dangKhuyenMai_SelectedIndexChanged);
            // 
            // dangKhuyenMaiBindingSource
            // 
            this.dangKhuyenMaiBindingSource.DataMember = "DangKhuyenMai";
            this.dangKhuyenMaiBindingSource.DataSource = this.qLNhaThuocDataSet;
            this.dangKhuyenMaiBindingSource.CurrentChanged += new System.EventHandler(this.dangKhuyenMaiBindingSource_CurrentChanged);
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.Location = new System.Drawing.Point(779, 13);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(106, 23);
            this.textBox_soLuong.TabIndex = 10;
            this.textBox_soLuong.TextChanged += new System.EventHandler(this.textBox_soLuong_TextChanged);
            // 
            // textBox_tenKhuyenMai
            // 
            this.textBox_tenKhuyenMai.Location = new System.Drawing.Point(469, 13);
            this.textBox_tenKhuyenMai.Name = "textBox_tenKhuyenMai";
            this.textBox_tenKhuyenMai.Size = new System.Drawing.Size(145, 23);
            this.textBox_tenKhuyenMai.TabIndex = 9;
            this.textBox_tenKhuyenMai.TextChanged += new System.EventHandler(this.textBox_tenKhuyenMai_TextChanged);
            // 
            // dateTimePicker_ngayKetThuc
            // 
            this.dateTimePicker_ngayKetThuc.Location = new System.Drawing.Point(469, 83);
            this.dateTimePicker_ngayKetThuc.Name = "dateTimePicker_ngayKetThuc";
            this.dateTimePicker_ngayKetThuc.Size = new System.Drawing.Size(156, 23);
            this.dateTimePicker_ngayKetThuc.TabIndex = 8;
            this.dateTimePicker_ngayKetThuc.ValueChanged += new System.EventHandler(this.dateTimePicker_ngayKetThuc_ValueChanged);
            // 
            // dateTimePicker_ngayBatDau
            // 
            this.dateTimePicker_ngayBatDau.Location = new System.Drawing.Point(150, 83);
            this.dateTimePicker_ngayBatDau.Name = "dateTimePicker_ngayBatDau";
            this.dateTimePicker_ngayBatDau.Size = new System.Drawing.Size(156, 23);
            this.dateTimePicker_ngayBatDau.TabIndex = 7;
            this.dateTimePicker_ngayBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker_ngayBatDau_ValueChanged);
            // 
            // textBox_maDonKM
            // 
            this.textBox_maDonKM.Location = new System.Drawing.Point(150, 13);
            this.textBox_maDonKM.Name = "textBox_maDonKM";
            this.textBox_maDonKM.ReadOnly = true;
            this.textBox_maDonKM.Size = new System.Drawing.Size(100, 23);
            this.textBox_maDonKM.TabIndex = 6;
            this.textBox_maDonKM.TextChanged += new System.EventHandler(this.textBox_maDonKM_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "dạng khuyến mãi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng giới hạng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian kết thúc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian bắt đầu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đợt khuyến mãi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt khuyến mãi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dangKhuyenMaiTableAdapter
            // 
            this.dangKhuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(329, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 90);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childSuaKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(908, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_khuyenMai);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaKM";
            this.Text = "Sửa thông tin khuyến mãi";
            this.Load += new System.EventHandler(this.frm_childSuaKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khuyenMai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_khuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangKM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_dangKhuyenMai;
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
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangKhuyenMaiBindingSource;
        private QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter dangKhuyenMaiTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}