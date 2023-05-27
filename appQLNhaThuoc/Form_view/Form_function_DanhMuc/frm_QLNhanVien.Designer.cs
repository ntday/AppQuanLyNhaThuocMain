
namespace appQLNhaThuoc.Form_view.Form_function
{
    partial class frm_QLNhanVien
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
            this.label_ghichu = new System.Windows.Forms.Label();
            this.vbButton3 = new appQLNhaThuoc.VBButton();
            this.vbButton2 = new appQLNhaThuoc.VBButton();
            this.vbButton1 = new appQLNhaThuoc.VBButton();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ghichu);
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 81);
            this.panel1.TabIndex = 1;
            // 
            // label_ghichu
            // 
            this.label_ghichu.AutoSize = true;
            this.label_ghichu.Location = new System.Drawing.Point(752, 35);
            this.label_ghichu.Name = "label_ghichu";
            this.label_ghichu.Size = new System.Drawing.Size(0, 16);
            this.label_ghichu.TabIndex = 3;
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
            this.vbButton3.Location = new System.Drawing.Point(461, 21);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(5);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(208, 43);
            this.vbButton3.TabIndex = 2;
            this.vbButton3.Text = "Xóa";
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
            this.vbButton2.Location = new System.Drawing.Point(243, 21);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(5);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(208, 43);
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
            this.vbButton1.Location = new System.Drawing.Point(24, 21);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(5);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(208, 43);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "Thêm mới";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoVaTen,
            this.sdtNV,
            this.ngaySinhNV,
            this.tenDN,
            this.tenQH});
            this.dataGridViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(1044, 500);
            this.dataGridViewNhanVien.TabIndex = 2;
            this.dataGridViewNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellContentClick);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            // 
            // hoVaTen
            // 
            this.hoVaTen.DataPropertyName = "hoVaTen";
            this.hoVaTen.HeaderText = "Họ và tên";
            this.hoVaTen.Name = "hoVaTen";
            // 
            // sdtNV
            // 
            this.sdtNV.DataPropertyName = "sdtNV";
            this.sdtNV.HeaderText = "Số điện thoại";
            this.sdtNV.Name = "sdtNV";
            // 
            // ngaySinhNV
            // 
            this.ngaySinhNV.DataPropertyName = "ngaySinhNV";
            this.ngaySinhNV.HeaderText = "Ngày Sinh";
            this.ngaySinhNV.Name = "ngaySinhNV";
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "tenDN";
            this.tenDN.HeaderText = "Tên đang nhập";
            this.tenDN.Name = "tenDN";
            // 
            // tenQH
            // 
            this.tenQH.DataPropertyName = "tenQH";
            this.tenQH.HeaderText = "Quyền hạn";
            this.tenQH.Name = "tenQH";
            // 
            // frm_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frm_QLNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VBButton vbButton3;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQH;
        private System.Windows.Forms.Label label_ghichu;
    }
}