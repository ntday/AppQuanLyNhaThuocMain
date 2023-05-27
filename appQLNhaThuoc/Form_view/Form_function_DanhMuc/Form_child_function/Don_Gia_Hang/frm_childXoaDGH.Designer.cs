
namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc.Form_child_function.Don_Gia_Hang
{
    partial class frm_childXoaDGH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ghiChu = new System.Windows.Forms.TextBox();
            this.comboBox_maThuoc = new System.Windows.Forms.ComboBox();
            this.comboBox_thenThuoc = new System.Windows.Forms.ComboBox();
            this.textBox_giaBan = new System.Windows.Forms.TextBox();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_giaBan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_ghiChu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_maThuoc);
            this.panel1.Controls.Add(this.textBox_giaBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_thenThuoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 142);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên thuốc";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(214, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 74);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa thông tin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_ghiChu
            // 
            this.textBox_ghiChu.Location = new System.Drawing.Point(352, 16);
            this.textBox_ghiChu.Multiline = true;
            this.textBox_ghiChu.Name = "textBox_ghiChu";
            this.textBox_ghiChu.ReadOnly = true;
            this.textBox_ghiChu.Size = new System.Drawing.Size(281, 67);
            this.textBox_ghiChu.TabIndex = 15;
            // 
            // comboBox_maThuoc
            // 
            this.comboBox_maThuoc.FormattingEnabled = true;
            this.comboBox_maThuoc.Location = new System.Drawing.Point(89, 12);
            this.comboBox_maThuoc.Name = "comboBox_maThuoc";
            this.comboBox_maThuoc.Size = new System.Drawing.Size(182, 24);
            this.comboBox_maThuoc.TabIndex = 11;
            // 
            // comboBox_thenThuoc
            // 
            this.comboBox_thenThuoc.FormattingEnabled = true;
            this.comboBox_thenThuoc.Location = new System.Drawing.Point(89, 52);
            this.comboBox_thenThuoc.Name = "comboBox_thenThuoc";
            this.comboBox_thenThuoc.Size = new System.Drawing.Size(182, 24);
            this.comboBox_thenThuoc.TabIndex = 13;
            // 
            // textBox_giaBan
            // 
            this.textBox_giaBan.Location = new System.Drawing.Point(89, 99);
            this.textBox_giaBan.Name = "textBox_giaBan";
            this.textBox_giaBan.ReadOnly = true;
            this.textBox_giaBan.Size = new System.Drawing.Size(161, 23);
            this.textBox_giaBan.TabIndex = 14;
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // donGiaBan
            // 
            this.donGiaBan.HeaderText = "Đơn giá bán";
            this.donGiaBan.Name = "donGiaBan";
            // 
            // maThuoc
            // 
            this.maThuoc.HeaderText = "Mã Thuốc";
            this.maThuoc.Name = "maThuoc";
            // 
            // dataGridView_giaBan
            // 
            this.dataGridView_giaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_giaBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_giaBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_giaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_giaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.donGiaBan,
            this.ghiChu});
            this.dataGridView_giaBan.Location = new System.Drawing.Point(0, 144);
            this.dataGridView_giaBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_giaBan.Name = "dataGridView_giaBan";
            this.dataGridView_giaBan.Size = new System.Drawing.Size(655, 339);
            this.dataGridView_giaBan.TabIndex = 19;
            // 
            // frm_childXoaDGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(655, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_giaBan);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaDGH";
            this.Text = "Xóa thông tin giá";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ghiChu;
        private System.Windows.Forms.ComboBox comboBox_maThuoc;
        private System.Windows.Forms.TextBox textBox_giaBan;
        private System.Windows.Forms.ComboBox comboBox_thenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridView dataGridView_giaBan;
    }
}