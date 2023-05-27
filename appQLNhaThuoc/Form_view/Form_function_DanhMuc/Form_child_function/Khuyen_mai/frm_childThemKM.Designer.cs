
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khuyen_mai
{
    partial class frm_childThemKM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenKhuyenMai = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.comboBox_dangKhuyenMai = new System.Windows.Forms.ComboBox();
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.dangKhuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangKhuyenMaiTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng giới hạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dạng khuyến mãi";
            // 
            // textBox_tenKhuyenMai
            // 
            this.textBox_tenKhuyenMai.Location = new System.Drawing.Point(196, 29);
            this.textBox_tenKhuyenMai.Name = "textBox_tenKhuyenMai";
            this.textBox_tenKhuyenMai.Size = new System.Drawing.Size(128, 26);
            this.textBox_tenKhuyenMai.TabIndex = 5;
            // 
            // dateTimePicker_ngayBatDau
            // 
            this.dateTimePicker_ngayBatDau.Location = new System.Drawing.Point(196, 99);
            this.dateTimePicker_ngayBatDau.Name = "dateTimePicker_ngayBatDau";
            this.dateTimePicker_ngayBatDau.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker_ngayBatDau.TabIndex = 6;
            // 
            // dateTimePicker_ngayKetThuc
            // 
            this.dateTimePicker_ngayKetThuc.Location = new System.Drawing.Point(196, 172);
            this.dateTimePicker_ngayKetThuc.Name = "dateTimePicker_ngayKetThuc";
            this.dateTimePicker_ngayKetThuc.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker_ngayKetThuc.TabIndex = 7;
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.Location = new System.Drawing.Point(196, 242);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(75, 26);
            this.textBox_soLuong.TabIndex = 8;
            // 
            // comboBox_dangKhuyenMai
            // 
            this.comboBox_dangKhuyenMai.DataSource = this.dangKhuyenMaiBindingSource;
            this.comboBox_dangKhuyenMai.DisplayMember = "tenDangKM";
            this.comboBox_dangKhuyenMai.FormattingEnabled = true;
            this.comboBox_dangKhuyenMai.Location = new System.Drawing.Point(196, 309);
            this.comboBox_dangKhuyenMai.Name = "comboBox_dangKhuyenMai";
            this.comboBox_dangKhuyenMai.Size = new System.Drawing.Size(121, 26);
            this.comboBox_dangKhuyenMai.TabIndex = 9;
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
            // dangKhuyenMaiTableAdapter
            // 
            this.dangKhuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(73, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 90);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frm_childThemKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_dangKhuyenMai);
            this.Controls.Add(this.textBox_soLuong);
            this.Controls.Add(this.dateTimePicker_ngayKetThuc);
            this.Controls.Add(this.dateTimePicker_ngayBatDau);
            this.Controls.Add(this.textBox_tenKhuyenMai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_childThemKM";
            this.Text = "Thêm thông tin khuyến mãi";
            this.Load += new System.EventHandler(this.frm_childThemKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenKhuyenMai;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayKetThuc;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.ComboBox comboBox_dangKhuyenMai;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangKhuyenMaiBindingSource;
        private QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter dangKhuyenMaiTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}