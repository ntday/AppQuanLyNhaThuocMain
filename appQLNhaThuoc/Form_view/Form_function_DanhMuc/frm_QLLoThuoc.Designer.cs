
namespace appQLNhaThuoc.Form_view.Form_function
{
    partial class frm_QLLoThuoc
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
            this.dataGridView_loThuoc = new System.Windows.Forms.DataGridView();
            this.maSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViBaoGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDongGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbButton3 = new appQLNhaThuoc.VBButton();
            this.vbButton2 = new appQLNhaThuoc.VBButton();
            this.vbButton1 = new appQLNhaThuoc.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 77);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView_loThuoc
            // 
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
            this.dataGridView_loThuoc.Location = new System.Drawing.Point(0, 87);
            this.dataGridView_loThuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_loThuoc.Name = "dataGridView_loThuoc";
            this.dataGridView_loThuoc.Size = new System.Drawing.Size(1172, 579);
            this.dataGridView_loThuoc.TabIndex = 5;
            // 
            // maSoLo
            // 
            this.maSoLo.DataPropertyName = "maSoLo";
            this.maSoLo.HeaderText = "Mã lô";
            this.maSoLo.Name = "maSoLo";
            // 
            // tenHangDuoc
            // 
            this.tenHangDuoc.DataPropertyName = "tenHangDuoc";
            this.tenHangDuoc.HeaderText = "Tên hãng dược";
            this.tenHangDuoc.Name = "tenHangDuoc";
            // 
            // ngaySanXuat
            // 
            this.ngaySanXuat.DataPropertyName = "ngaySanXuat";
            this.ngaySanXuat.HeaderText = "Ngày sản xuất";
            this.ngaySanXuat.Name = "ngaySanXuat";
            // 
            // ngayHetHang
            // 
            this.ngayHetHang.DataPropertyName = "ngayHetHang";
            this.ngayHetHang.HeaderText = "Ngày hết hạng";
            this.ngayHetHang.Name = "ngayHetHang";
            // 
            // donViBaoGoi
            // 
            this.donViBaoGoi.DataPropertyName = "donViBaoGoi";
            this.donViBaoGoi.HeaderText = "Đơn vị bao gói";
            this.donViBaoGoi.Name = "donViBaoGoi";
            // 
            // donViDongGoi
            // 
            this.donViDongGoi.DataPropertyName = "donViDongGoi";
            this.donViDongGoi.HeaderText = "Đơn vị đống gói";
            this.donViDongGoi.Name = "donViDongGoi";
            // 
            // donViSanPham
            // 
            this.donViSanPham.DataPropertyName = "donViSanPham";
            this.donViSanPham.HeaderText = "Đơn vị sản phẩm";
            this.donViSanPham.Name = "donViSanPham";
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 20;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(307, 26);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(125, 36);
            this.vbButton3.TabIndex = 2;
            this.vbButton3.Text = "Xóa thông tin";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            this.vbButton3.Click += new System.EventHandler(this.vbButton3_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(168, 26);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(125, 36);
            this.vbButton2.TabIndex = 1;
            this.vbButton2.Text = "Chỉnh sửa";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(27, 26);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(125, 36);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "Thêm mới";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // frm_QLLoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1172, 667);
            this.Controls.Add(this.dataGridView_loThuoc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_QLLoThuoc";
            this.Text = "Quản lý lô thuốc";
            this.Load += new System.EventHandler(this.frm_QLLoThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VBButton vbButton3;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private System.Windows.Forms.DataGridView dataGridView_loThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViBaoGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDongGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}