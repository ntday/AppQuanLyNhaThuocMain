
namespace appQLNhaThuoc.Form_view.Form_function_KhoHang
{
    partial class frm_QLTinhTrangHang
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
            this.textBox1_tenThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_maThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1_tableTinhTrang = new System.Windows.Forms.DataGridView();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangTonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangHangDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tableTinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1_tenThuoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1_maThuoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 105);
            this.panel1.TabIndex = 0;
            // 
            // textBox1_tenThuoc
            // 
            this.textBox1_tenThuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_tenThuoc.Location = new System.Drawing.Point(93, 59);
            this.textBox1_tenThuoc.Name = "textBox1_tenThuoc";
            this.textBox1_tenThuoc.Size = new System.Drawing.Size(165, 23);
            this.textBox1_tenThuoc.TabIndex = 3;
            this.textBox1_tenThuoc.TextChanged += new System.EventHandler(this.textBox1_tenThuoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên thuốc";
            // 
            // textBox1_maThuoc
            // 
            this.textBox1_maThuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_maThuoc.Location = new System.Drawing.Point(93, 18);
            this.textBox1_maThuoc.Name = "textBox1_maThuoc";
            this.textBox1_maThuoc.Size = new System.Drawing.Size(165, 23);
            this.textBox1_maThuoc.TabIndex = 1;
            this.textBox1_maThuoc.TextChanged += new System.EventHandler(this.textBox1_maThuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc";
            // 
            // dataGridView1_tableTinhTrang
            // 
            this.dataGridView1_tableTinhTrang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_tableTinhTrang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_tableTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_tableTinhTrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.tenThuoc,
            this.maSoLo,
            this.ngaySanXuat,
            this.ngayHetHang,
            this.tinhTrangTonHang,
            this.tenDVT,
            this.tinhTrangHangDung});
            this.dataGridView1_tableTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1_tableTinhTrang.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1_tableTinhTrang.Name = "dataGridView1_tableTinhTrang";
            this.dataGridView1_tableTinhTrang.Size = new System.Drawing.Size(1108, 510);
            this.dataGridView1_tableTinhTrang.TabIndex = 1;
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "maThuoc";
            this.maThuoc.HeaderText = "Mã thuốc";
            this.maThuoc.Name = "maThuoc";
            // 
            // tenThuoc
            // 
            this.tenThuoc.DataPropertyName = "tenThuoc";
            this.tenThuoc.HeaderText = "Tên thuốc";
            this.tenThuoc.Name = "tenThuoc";
            // 
            // maSoLo
            // 
            this.maSoLo.DataPropertyName = "maSoLo";
            this.maSoLo.HeaderText = "Mã số lô";
            this.maSoLo.Name = "maSoLo";
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
            // tinhTrangTonHang
            // 
            this.tinhTrangTonHang.DataPropertyName = "tinhTrangTonHang";
            this.tinhTrangTonHang.HeaderText = "Tình trạng tồn hàng";
            this.tinhTrangTonHang.Name = "tinhTrangTonHang";
            // 
            // tenDVT
            // 
            this.tenDVT.DataPropertyName = "tenDVT";
            this.tenDVT.HeaderText = "Đơn vị tính";
            this.tenDVT.Name = "tenDVT";
            // 
            // tinhTrangHangDung
            // 
            this.tinhTrangHangDung.DataPropertyName = "tinhTrangHangDung";
            this.tinhTrangHangDung.HeaderText = "Tình trạng hạng dùng";
            this.tinhTrangHangDung.Name = "tinhTrangHangDung";
            // 
            // frm_QLTinhTrangHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1108, 615);
            this.Controls.Add(this.dataGridView1_tableTinhTrang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLTinhTrangHang";
            this.Text = "Tình trạng hàng hóa";
            this.Load += new System.EventHandler(this.frm_QLTinhTrangHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tableTinhTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1_tableTinhTrang;
        private System.Windows.Forms.TextBox textBox1_maThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_tenThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangTonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangHangDung;
    }
}