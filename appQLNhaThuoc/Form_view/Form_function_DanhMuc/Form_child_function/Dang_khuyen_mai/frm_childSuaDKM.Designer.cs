
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Dang_khuyen_mai
{
    partial class frm_childSuaDKM
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
            System.Windows.Forms.Label maDangKMLabel;
            System.Windows.Forms.Label giamGiaLabel;
            System.Windows.Forms.Label tenDangKMLabel;
            System.Windows.Forms.Label quaTangLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.dangKhuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangKhuyenMaiTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.dangKhuyenMaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maDangKMTextBox = new System.Windows.Forms.TextBox();
            this.giamGiaTextBox = new System.Windows.Forms.TextBox();
            this.tenDangKMTextBox = new System.Windows.Forms.TextBox();
            this.quaTangTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            maDangKMLabel = new System.Windows.Forms.Label();
            giamGiaLabel = new System.Windows.Forms.Label();
            tenDangKMLabel = new System.Windows.Forms.Label();
            quaTangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = this.dangKhuyenMaiTableAdapter;
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = null;
            this.tableAdapterManager.hoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.khuyenMaiTableAdapter = null;
            this.tableAdapterManager.loThuocTableAdapter = null;
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = null;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dangKhuyenMaiDataGridView
            // 
            this.dangKhuyenMaiDataGridView.AutoGenerateColumns = false;
            this.dangKhuyenMaiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dangKhuyenMaiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dangKhuyenMaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dangKhuyenMaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dangKhuyenMaiDataGridView.DataSource = this.dangKhuyenMaiBindingSource;
            this.dangKhuyenMaiDataGridView.Location = new System.Drawing.Point(0, 140);
            this.dangKhuyenMaiDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dangKhuyenMaiDataGridView.Name = "dangKhuyenMaiDataGridView";
            this.dangKhuyenMaiDataGridView.Size = new System.Drawing.Size(773, 280);
            this.dangKhuyenMaiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maDangKM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã dạng khuyến mãi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tenDangKM";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên dạng khuyến mãi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "giamGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giảm giá \"%\"";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quaTang";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quà tặng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(quaTangLabel);
            this.panel1.Controls.Add(this.quaTangTextBox);
            this.panel1.Controls.Add(tenDangKMLabel);
            this.panel1.Controls.Add(this.tenDangKMTextBox);
            this.panel1.Controls.Add(giamGiaLabel);
            this.panel1.Controls.Add(this.giamGiaTextBox);
            this.panel1.Controls.Add(maDangKMLabel);
            this.panel1.Controls.Add(this.maDangKMTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 133);
            this.panel1.TabIndex = 2;
            // 
            // maDangKMLabel
            // 
            maDangKMLabel.AutoSize = true;
            maDangKMLabel.Location = new System.Drawing.Point(26, 18);
            maDangKMLabel.Name = "maDangKMLabel";
            maDangKMLabel.Size = new System.Drawing.Size(140, 16);
            maDangKMLabel.TabIndex = 0;
            maDangKMLabel.Text = "Mã dạng khuyến mãi";
            // 
            // maDangKMTextBox
            // 
            this.maDangKMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangKhuyenMaiBindingSource, "maDangKM", true));
            this.maDangKMTextBox.Location = new System.Drawing.Point(172, 15);
            this.maDangKMTextBox.Name = "maDangKMTextBox";
            this.maDangKMTextBox.ReadOnly = true;
            this.maDangKMTextBox.Size = new System.Drawing.Size(100, 23);
            this.maDangKMTextBox.TabIndex = 1;
            // 
            // giamGiaLabel
            // 
            giamGiaLabel.AutoSize = true;
            giamGiaLabel.Location = new System.Drawing.Point(26, 75);
            giamGiaLabel.Name = "giamGiaLabel";
            giamGiaLabel.Size = new System.Drawing.Size(61, 16);
            giamGiaLabel.TabIndex = 2;
            giamGiaLabel.Text = "Giảm giá";
            // 
            // giamGiaTextBox
            // 
            this.giamGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangKhuyenMaiBindingSource, "giamGia", true));
            this.giamGiaTextBox.Location = new System.Drawing.Point(93, 72);
            this.giamGiaTextBox.Name = "giamGiaTextBox";
            this.giamGiaTextBox.Size = new System.Drawing.Size(73, 23);
            this.giamGiaTextBox.TabIndex = 3;
            // 
            // tenDangKMLabel
            // 
            tenDangKMLabel.AutoSize = true;
            tenDangKMLabel.Location = new System.Drawing.Point(334, 18);
            tenDangKMLabel.Name = "tenDangKMLabel";
            tenDangKMLabel.Size = new System.Drawing.Size(143, 16);
            tenDangKMLabel.TabIndex = 4;
            tenDangKMLabel.Text = "tên dạng khuyến mãi";
            tenDangKMLabel.Click += new System.EventHandler(this.tenDangKMLabel_Click);
            // 
            // tenDangKMTextBox
            // 
            this.tenDangKMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangKhuyenMaiBindingSource, "tenDangKM", true));
            this.tenDangKMTextBox.Location = new System.Drawing.Point(483, 15);
            this.tenDangKMTextBox.Name = "tenDangKMTextBox";
            this.tenDangKMTextBox.Size = new System.Drawing.Size(193, 23);
            this.tenDangKMTextBox.TabIndex = 5;
            this.tenDangKMTextBox.TextChanged += new System.EventHandler(this.tenDangKMTextBox_TextChanged);
            // 
            // quaTangLabel
            // 
            quaTangLabel.AutoSize = true;
            quaTangLabel.Location = new System.Drawing.Point(222, 75);
            quaTangLabel.Name = "quaTangLabel";
            quaTangLabel.Size = new System.Drawing.Size(67, 16);
            quaTangLabel.TabIndex = 6;
            quaTangLabel.Text = "Quà tặng";
            // 
            // quaTangTextBox
            // 
            this.quaTangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangKhuyenMaiBindingSource, "quaTang", true));
            this.quaTangTextBox.Location = new System.Drawing.Point(300, 72);
            this.quaTangTextBox.Name = "quaTangTextBox";
            this.quaTangTextBox.Size = new System.Drawing.Size(177, 23);
            this.quaTangTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "%";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(260, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 75);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_childSuaDKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(773, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dangKhuyenMaiDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_childSuaDKM";
            this.Text = "Sửa dạng khuyến mãi";
            this.Load += new System.EventHandler(this.frm_childSuaDKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKhuyenMaiDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangKhuyenMaiBindingSource;
        private QLNhaThuocDataSetTableAdapters.DangKhuyenMaiTableAdapter dangKhuyenMaiTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dangKhuyenMaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox quaTangTextBox;
        private System.Windows.Forms.TextBox tenDangKMTextBox;
        private System.Windows.Forms.TextBox giamGiaTextBox;
        private System.Windows.Forms.TextBox maDangKMTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}