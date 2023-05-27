
namespace appQLNhaThuoc.Form_view.Form_function_KhoHang.Form_child_function
{
    partial class frm_childChiTietNhap
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
            this.vbButton1 = new appQLNhaThuoc.VBButton();
            this.dataGridView_chiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.maSoLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(12, 12);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(185, 40);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "In báo cáo";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // dataGridView_chiTietPhieuNhap
            // 
            this.dataGridView_chiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSoLo,
            this.maThuoc,
            this.tenThuoc,
            this.tenDVT,
            this.donGia,
            this.soLuong,
            this.thanhTien});
            this.dataGridView_chiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_chiTietPhieuNhap.Location = new System.Drawing.Point(0, 63);
            this.dataGridView_chiTietPhieuNhap.Name = "dataGridView_chiTietPhieuNhap";
            this.dataGridView_chiTietPhieuNhap.Size = new System.Drawing.Size(1200, 618);
            this.dataGridView_chiTietPhieuNhap.TabIndex = 2;
            this.dataGridView_chiTietPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_chiTietPhieuNhap_CellContentClick);
            // 
            // maSoLo
            // 
            this.maSoLo.DataPropertyName = "maSoLo";
            this.maSoLo.HeaderText = "Mã số lô";
            this.maSoLo.Name = "maSoLo";
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "maThuoc";
            this.maThuoc.HeaderText = "Mã Thuốc";
            this.maThuoc.Name = "maThuoc";
            // 
            // tenThuoc
            // 
            this.tenThuoc.DataPropertyName = "tenThuoc";
            this.tenThuoc.HeaderText = "Tên Thuốc";
            this.tenThuoc.Name = "tenThuoc";
            // 
            // tenDVT
            // 
            this.tenDVT.DataPropertyName = "tenDVT";
            this.tenDVT.HeaderText = "Đơn vị tính";
            this.tenDVT.Name = "tenDVT";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá nhập";
            this.donGia.Name = "donGia";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng nhập";
            this.soLuong.Name = "soLuong";
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            // 
            // frm_childChiTietNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1200, 681);
            this.Controls.Add(this.dataGridView_chiTietPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childChiTietNhap";
            this.Text = "Chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.frm_childChiTietNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_chiTietPhieuNhap;
        private VBButton vbButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}