
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Thuoc_child
{
    partial class frm_childXoaThuoc
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_nhomThuoc = new System.Windows.Forms.ComboBox();
            this.textBox_congDung = new System.Windows.Forms.TextBox();
            this.tenNhomThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congDungChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhanChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_thuoc = new System.Windows.Forms.DataGridView();
            this.textBox_thanhPhan = new System.Windows.Forms.TextBox();
            this.textBox_tenThuoc = new System.Windows.Forms.TextBox();
            this.textBox_maThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(475, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 69);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_nhomThuoc
            // 
            this.comboBox_nhomThuoc.FormattingEnabled = true;
            this.comboBox_nhomThuoc.Location = new System.Drawing.Point(107, 96);
            this.comboBox_nhomThuoc.Name = "comboBox_nhomThuoc";
            this.comboBox_nhomThuoc.Size = new System.Drawing.Size(165, 24);
            this.comboBox_nhomThuoc.TabIndex = 20;
            // 
            // textBox_congDung
            // 
            this.textBox_congDung.Location = new System.Drawing.Point(783, 13);
            this.textBox_congDung.Multiline = true;
            this.textBox_congDung.Name = "textBox_congDung";
            this.textBox_congDung.ReadOnly = true;
            this.textBox_congDung.Size = new System.Drawing.Size(241, 64);
            this.textBox_congDung.TabIndex = 19;
            // 
            // tenNhomThuoc
            // 
            this.tenNhomThuoc.DataPropertyName = "tenNhomThuoc";
            this.tenNhomThuoc.HeaderText = "Nhóm thuốc";
            this.tenNhomThuoc.Name = "tenNhomThuoc";
            this.tenNhomThuoc.ReadOnly = true;
            // 
            // congDungChinh
            // 
            this.congDungChinh.DataPropertyName = "congDungChinh";
            this.congDungChinh.HeaderText = "Công dụng chính";
            this.congDungChinh.Name = "congDungChinh";
            this.congDungChinh.ReadOnly = true;
            // 
            // thanhPhanChinh
            // 
            this.thanhPhanChinh.DataPropertyName = "thanhPhanChinh";
            this.thanhPhanChinh.HeaderText = "Thanh phần chính";
            this.thanhPhanChinh.Name = "thanhPhanChinh";
            this.thanhPhanChinh.ReadOnly = true;
            // 
            // tenThuoc
            // 
            this.tenThuoc.DataPropertyName = "tenThuoc";
            this.tenThuoc.HeaderText = "Tên Thuốc";
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.ReadOnly = true;
            // 
            // maThuoc
            // 
            this.maThuoc.DataPropertyName = "maThuoc";
            this.maThuoc.HeaderText = "Mã Thuốc";
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.ReadOnly = true;
            // 
            // dataGridView_thuoc
            // 
            this.dataGridView_thuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_thuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuoc,
            this.tenThuoc,
            this.thanhPhanChinh,
            this.congDungChinh,
            this.tenNhomThuoc});
            this.dataGridView_thuoc.Location = new System.Drawing.Point(0, 146);
            this.dataGridView_thuoc.Name = "dataGridView_thuoc";
            this.dataGridView_thuoc.ReadOnly = true;
            this.dataGridView_thuoc.Size = new System.Drawing.Size(1081, 400);
            this.dataGridView_thuoc.TabIndex = 13;
            this.dataGridView_thuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_thuoc_CellClick);
            // 
            // textBox_thanhPhan
            // 
            this.textBox_thanhPhan.Location = new System.Drawing.Point(415, 13);
            this.textBox_thanhPhan.Multiline = true;
            this.textBox_thanhPhan.Name = "textBox_thanhPhan";
            this.textBox_thanhPhan.ReadOnly = true;
            this.textBox_thanhPhan.Size = new System.Drawing.Size(241, 64);
            this.textBox_thanhPhan.TabIndex = 18;
            // 
            // textBox_tenThuoc
            // 
            this.textBox_tenThuoc.Location = new System.Drawing.Point(107, 49);
            this.textBox_tenThuoc.Name = "textBox_tenThuoc";
            this.textBox_tenThuoc.ReadOnly = true;
            this.textBox_tenThuoc.Size = new System.Drawing.Size(165, 23);
            this.textBox_tenThuoc.TabIndex = 14;
            // 
            // textBox_maThuoc
            // 
            this.textBox_maThuoc.Location = new System.Drawing.Point(107, 10);
            this.textBox_maThuoc.Name = "textBox_maThuoc";
            this.textBox_maThuoc.ReadOnly = true;
            this.textBox_maThuoc.Size = new System.Drawing.Size(165, 23);
            this.textBox_maThuoc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Công dụng chính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Thành phần chính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nhóm thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_nhomThuoc);
            this.panel1.Controls.Add(this.textBox_congDung);
            this.panel1.Controls.Add(this.textBox_thanhPhan);
            this.panel1.Controls.Add(this.textBox_tenThuoc);
            this.panel1.Controls.Add(this.textBox_maThuoc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 134);
            this.panel1.TabIndex = 12;
            // 
            // frm_childXoaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1081, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_thuoc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaThuoc";
            this.Text = "Xóa thông tin thuốc";
            this.Load += new System.EventHandler(this.frm_childXoaThuoc_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_nhomThuoc;
        private System.Windows.Forms.TextBox textBox_congDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn congDungChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhanChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridView dataGridView_thuoc;
        private System.Windows.Forms.TextBox textBox_thanhPhan;
        private System.Windows.Forms.TextBox textBox_tenThuoc;
        private System.Windows.Forms.TextBox textBox_maThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}