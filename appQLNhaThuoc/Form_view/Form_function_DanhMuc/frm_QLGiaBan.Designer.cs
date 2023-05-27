
namespace appQLNhaThuoc.Form_view.Form_function_DanhMuc
{
    partial class frm_QLGiaBan
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
            this.vbButton3 = new appQLNhaThuoc.VBButton();
            this.vbButton2 = new appQLNhaThuoc.VBButton();
            this.vbButton1 = new appQLNhaThuoc.VBButton();
            this.dataGridView_giaBan = new System.Windows.Forms.DataGridView();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 85);
            this.panel1.TabIndex = 5;
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
            this.vbButton3.Location = new System.Drawing.Point(395, 18);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(167, 44);
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
            this.vbButton2.Location = new System.Drawing.Point(209, 18);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(167, 44);
            this.vbButton2.TabIndex = 1;
            this.vbButton2.Text = "Cập nhật giá";
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
            this.vbButton1.Location = new System.Drawing.Point(21, 18);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(167, 44);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "Thêm mới giá";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // dataGridView_giaBan
            // 
            this.dataGridView_giaBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_giaBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_giaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_giaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.donGiaBan,
            this.ghiChu});
            this.dataGridView_giaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_giaBan.Location = new System.Drawing.Point(0, 85);
            this.dataGridView_giaBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_giaBan.Name = "dataGridView_giaBan";
            this.dataGridView_giaBan.Size = new System.Drawing.Size(600, 598);
            this.dataGridView_giaBan.TabIndex = 6;
            this.dataGridView_giaBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_giaBan_CellContentClick);
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "maThuoc";
            this.maThuoc.HeaderText = "Mã Thuốc";
            this.maThuoc.Name = "maThuoc";
            // 
            // donGiaBan
            // 
            this.donGiaBan.DataPropertyName = "donGiaBan";
            this.donGiaBan.HeaderText = "Đơn giá bán";
            this.donGiaBan.Name = "donGiaBan";
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // frm_QLGiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(600, 683);
            this.Controls.Add(this.dataGridView_giaBan);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLGiaBan";
            this.Text = "Quản lý giá bán";
            this.Load += new System.EventHandler(this.frm_QLGiaBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VBButton vbButton3;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private System.Windows.Forms.DataGridView dataGridView_giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}