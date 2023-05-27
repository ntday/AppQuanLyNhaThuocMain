
namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc.Form_child_function.Don_Gia_Hang
{
    partial class frm_childThemDGH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_maThuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_tenThuoc = new System.Windows.Forms.ComboBox();
            this.textBox_giaBan = new System.Windows.Forms.TextBox();
            this.textBox_ghiChu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_giaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_phanTramLoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú";
            // 
            // comboBox_maThuoc
            // 
            this.comboBox_maThuoc.FormattingEnabled = true;
            this.comboBox_maThuoc.Location = new System.Drawing.Point(132, 14);
            this.comboBox_maThuoc.Name = "comboBox_maThuoc";
            this.comboBox_maThuoc.Size = new System.Drawing.Size(182, 24);
            this.comboBox_maThuoc.TabIndex = 3;
            this.comboBox_maThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_maThuoc_SelectedIndexChanged);
            this.comboBox_maThuoc.EnabledChanged += new System.EventHandler(this.comboBox_maThuoc_EnabledChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên thuốc";
            // 
            // comboBox_tenThuoc
            // 
            this.comboBox_tenThuoc.FormattingEnabled = true;
            this.comboBox_tenThuoc.Location = new System.Drawing.Point(132, 55);
            this.comboBox_tenThuoc.Name = "comboBox_tenThuoc";
            this.comboBox_tenThuoc.Size = new System.Drawing.Size(182, 24);
            this.comboBox_tenThuoc.TabIndex = 5;
            // 
            // textBox_giaBan
            // 
            this.textBox_giaBan.Location = new System.Drawing.Point(132, 156);
            this.textBox_giaBan.Name = "textBox_giaBan";
            this.textBox_giaBan.Size = new System.Drawing.Size(161, 23);
            this.textBox_giaBan.TabIndex = 6;
            this.textBox_giaBan.Click += new System.EventHandler(this.textBox_giaBan_Click);
            this.textBox_giaBan.TextChanged += new System.EventHandler(this.textBox_giaBan_TextChanged);
            // 
            // textBox_ghiChu
            // 
            this.textBox_ghiChu.Location = new System.Drawing.Point(132, 194);
            this.textBox_ghiChu.Multiline = true;
            this.textBox_ghiChu.Name = "textBox_ghiChu";
            this.textBox_ghiChu.Size = new System.Drawing.Size(281, 67);
            this.textBox_ghiChu.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(114, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 77);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm giá bán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_giaNhap
            // 
            this.textBox_giaNhap.Location = new System.Drawing.Point(132, 89);
            this.textBox_giaNhap.Name = "textBox_giaNhap";
            this.textBox_giaNhap.ReadOnly = true;
            this.textBox_giaNhap.Size = new System.Drawing.Size(161, 23);
            this.textBox_giaNhap.TabIndex = 10;
            this.textBox_giaNhap.Click += new System.EventHandler(this.textBox_giaNhap_Click);
            this.textBox_giaNhap.TextChanged += new System.EventHandler(this.textBox_giaNhap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá nhập";
            // 
            // textBox_phanTramLoi
            // 
            this.textBox_phanTramLoi.Location = new System.Drawing.Point(132, 122);
            this.textBox_phanTramLoi.Name = "textBox_phanTramLoi";
            this.textBox_phanTramLoi.Size = new System.Drawing.Size(86, 23);
            this.textBox_phanTramLoi.TabIndex = 12;
            this.textBox_phanTramLoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phanTramLoi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thu lời";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "%";
            // 
            // frm_childThemDGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(466, 372);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_phanTramLoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_giaNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_ghiChu);
            this.Controls.Add(this.textBox_giaBan);
            this.Controls.Add(this.comboBox_tenThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_maThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemDGH";
            this.Text = "Thêm giá bán";
            this.Load += new System.EventHandler(this.frm_childThemDGH_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_maThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_tenThuoc;
        private System.Windows.Forms.TextBox textBox_giaBan;
        private System.Windows.Forms.TextBox textBox_ghiChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_giaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_phanTramLoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}