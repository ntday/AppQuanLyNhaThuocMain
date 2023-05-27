
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhan_Vien
{
    partial class frm_childXoaNV
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timePicker_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.text_soDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_hoVaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_maNV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_tenDangNhap
            // 
            this.text_tenDangNhap.Location = new System.Drawing.Point(403, 80);
            this.text_tenDangNhap.Name = "text_tenDangNhap";
            this.text_tenDangNhap.ReadOnly = true;
            this.text_tenDangNhap.Size = new System.Drawing.Size(132, 23);
            this.text_tenDangNhap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên đăng nhập";
            // 
            // timePicker_ngaySinh
            // 
            this.timePicker_ngaySinh.Location = new System.Drawing.Point(113, 78);
            this.timePicker_ngaySinh.Name = "timePicker_ngaySinh";
            this.timePicker_ngaySinh.Size = new System.Drawing.Size(154, 23);
            this.timePicker_ngaySinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // text_soDienThoai
            // 
            this.text_soDienThoai.Location = new System.Drawing.Point(688, 22);
            this.text_soDienThoai.Name = "text_soDienThoai";
            this.text_soDienThoai.ReadOnly = true;
            this.text_soDienThoai.Size = new System.Drawing.Size(187, 23);
            this.text_soDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // text_hoVaTen
            // 
            this.text_hoVaTen.Location = new System.Drawing.Point(316, 22);
            this.text_hoVaTen.Name = "text_hoVaTen";
            this.text_hoVaTen.ReadOnly = true;
            this.text_hoVaTen.Size = new System.Drawing.Size(266, 23);
            this.text_hoVaTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // text_maNV
            // 
            this.text_maNV.Location = new System.Drawing.Point(113, 22);
            this.text_maNV.Name = "text_maNV";
            this.text_maNV.ReadOnly = true;
            this.text_maNV.Size = new System.Drawing.Size(100, 23);
            this.text_maNV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(403, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 72);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(0, 141);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(988, 422);
            this.dataGridViewNhanVien.TabIndex = 6;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // hoVaTen
            // 
            this.hoVaTen.DataPropertyName = "hoVaTen";
            this.hoVaTen.HeaderText = "Họ và tên";
            this.hoVaTen.Name = "hoVaTen";
            this.hoVaTen.ReadOnly = true;
            // 
            // sdtNV
            // 
            this.sdtNV.DataPropertyName = "sdtNV";
            this.sdtNV.HeaderText = "Số điện thoại";
            this.sdtNV.Name = "sdtNV";
            this.sdtNV.ReadOnly = true;
            // 
            // ngaySinhNV
            // 
            this.ngaySinhNV.DataPropertyName = "ngaySinhNV";
            this.ngaySinhNV.HeaderText = "Ngày Sinh";
            this.ngaySinhNV.Name = "ngaySinhNV";
            this.ngaySinhNV.ReadOnly = true;
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "tenDN";
            this.tenDN.HeaderText = "Tên đang nhập";
            this.tenDN.Name = "tenDN";
            this.tenDN.ReadOnly = true;
            // 
            // tenQH
            // 
            this.tenQH.DataPropertyName = "tenQH";
            this.tenQH.HeaderText = "Quyền hạn";
            this.tenQH.Name = "tenQH";
            this.tenQH.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_tenDangNhap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timePicker_ngaySinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.text_soDienThoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text_hoVaTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_maNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 136);
            this.panel1.TabIndex = 5;
            // 
            // frm_childXoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(988, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaNV";
            this.Text = "xóa thông tin nhân viên";
            this.Load += new System.EventHandler(this.frm_childXoaNV_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_tenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timePicker_ngaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_soDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_hoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_maNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQH;
    }
}