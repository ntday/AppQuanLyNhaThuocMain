
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.hinhThucThanhToan
{
    partial class frm_childXoaHTTT
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
            System.Windows.Forms.Label soTaiKhoangLabel;
            System.Windows.Forms.Label tenNganHangLabel;
            System.Windows.Forms.Label tenDangTTLabel;
            System.Windows.Forms.Label maDangTTLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.soTaiKhoangTextBox = new System.Windows.Forms.TextBox();
            this.dangThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.tenNganHangTextBox = new System.Windows.Forms.TextBox();
            this.tenDangTTTextBox = new System.Windows.Forms.TextBox();
            this.maDangTTTextBox = new System.Windows.Forms.TextBox();
            this.dangThanhToanTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.dangThanhToanTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.dangThanhToanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            soTaiKhoangLabel = new System.Windows.Forms.Label();
            tenNganHangLabel = new System.Windows.Forms.Label();
            tenDangTTLabel = new System.Windows.Forms.Label();
            maDangTTLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // soTaiKhoangLabel
            // 
            soTaiKhoangLabel.AutoSize = true;
            soTaiKhoangLabel.Location = new System.Drawing.Point(376, 76);
            soTaiKhoangLabel.Name = "soTaiKhoangLabel";
            soTaiKhoangLabel.Size = new System.Drawing.Size(88, 16);
            soTaiKhoangLabel.TabIndex = 11;
            soTaiKhoangLabel.Text = "Số tài khoản";
            // 
            // tenNganHangLabel
            // 
            tenNganHangLabel.AutoSize = true;
            tenNganHangLabel.Location = new System.Drawing.Point(326, 19);
            tenNganHangLabel.Name = "tenNganHangLabel";
            tenNganHangLabel.Size = new System.Drawing.Size(103, 16);
            tenNganHangLabel.TabIndex = 10;
            tenNganHangLabel.Text = "Tên ngân hàng";
            // 
            // tenDangTTLabel
            // 
            tenDangTTLabel.AutoSize = true;
            tenDangTTLabel.Location = new System.Drawing.Point(8, 66);
            tenDangTTLabel.Name = "tenDangTTLabel";
            tenDangTTLabel.Size = new System.Drawing.Size(143, 16);
            tenDangTTLabel.TabIndex = 9;
            tenDangTTLabel.Text = "Tên dạng thanh toán";
            // 
            // maDangTTLabel
            // 
            maDangTTLabel.AutoSize = true;
            maDangTTLabel.Location = new System.Drawing.Point(12, 19);
            maDangTTLabel.Name = "maDangTTLabel";
            maDangTTLabel.Size = new System.Drawing.Size(139, 16);
            maDangTTLabel.TabIndex = 8;
            maDangTTLabel.Text = "Mã dạng thanh toán";
            maDangTTLabel.Click += new System.EventHandler(this.maDangTTLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(soTaiKhoangLabel);
            this.panel1.Controls.Add(tenNganHangLabel);
            this.panel1.Controls.Add(tenDangTTLabel);
            this.panel1.Controls.Add(maDangTTLabel);
            this.panel1.Controls.Add(this.soTaiKhoangTextBox);
            this.panel1.Controls.Add(this.tenNganHangTextBox);
            this.panel1.Controls.Add(this.tenDangTTTextBox);
            this.panel1.Controls.Add(this.maDangTTTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 119);
            this.panel1.TabIndex = 0;
            // 
            // soTaiKhoangTextBox
            // 
            this.soTaiKhoangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "soTaiKhoang", true));
            this.soTaiKhoangTextBox.Location = new System.Drawing.Point(470, 73);
            this.soTaiKhoangTextBox.Name = "soTaiKhoangTextBox";
            this.soTaiKhoangTextBox.ReadOnly = true;
            this.soTaiKhoangTextBox.Size = new System.Drawing.Size(222, 23);
            this.soTaiKhoangTextBox.TabIndex = 7;
            this.soTaiKhoangTextBox.TextChanged += new System.EventHandler(this.soTaiKhoangTextBox_TextChanged);
            // 
            // dangThanhToanBindingSource
            // 
            this.dangThanhToanBindingSource.DataMember = "dangThanhToan";
            this.dangThanhToanBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenNganHangTextBox
            // 
            this.tenNganHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "tenNganHang", true));
            this.tenNganHangTextBox.Location = new System.Drawing.Point(435, 16);
            this.tenNganHangTextBox.Name = "tenNganHangTextBox";
            this.tenNganHangTextBox.ReadOnly = true;
            this.tenNganHangTextBox.Size = new System.Drawing.Size(257, 23);
            this.tenNganHangTextBox.TabIndex = 5;
            // 
            // tenDangTTTextBox
            // 
            this.tenDangTTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "tenDangTT", true));
            this.tenDangTTTextBox.Location = new System.Drawing.Point(168, 66);
            this.tenDangTTTextBox.Name = "tenDangTTTextBox";
            this.tenDangTTTextBox.ReadOnly = true;
            this.tenDangTTTextBox.Size = new System.Drawing.Size(180, 23);
            this.tenDangTTTextBox.TabIndex = 3;
            // 
            // maDangTTTextBox
            // 
            this.maDangTTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "maDangTT", true));
            this.maDangTTTextBox.Location = new System.Drawing.Point(168, 16);
            this.maDangTTTextBox.Name = "maDangTTTextBox";
            this.maDangTTTextBox.ReadOnly = true;
            this.maDangTTTextBox.Size = new System.Drawing.Size(100, 23);
            this.maDangTTTextBox.TabIndex = 1;
            // 
            // dangThanhToanTableAdapter
            // 
            this.dangThanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bangSoLuongTamTableAdapter = null;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietKhoTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepXuatTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = this.dangThanhToanTableAdapter;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.giaDonHangTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = null;
            this.tableAdapterManager.hoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.khoTableAdapter = null;
            this.tableAdapterManager.khuyenMaiTableAdapter = null;
            this.tableAdapterManager.loThuocTableAdapter = null;
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = null;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.nhomThuocTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.phieuXuatThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dangThanhToanDataGridView
            // 
            this.dangThanhToanDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dangThanhToanDataGridView.AutoGenerateColumns = false;
            this.dangThanhToanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dangThanhToanDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dangThanhToanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dangThanhToanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dangThanhToanDataGridView.DataSource = this.dangThanhToanBindingSource;
            this.dangThanhToanDataGridView.Location = new System.Drawing.Point(0, 118);
            this.dangThanhToanDataGridView.Name = "dangThanhToanDataGridView";
            this.dangThanhToanDataGridView.ReadOnly = true;
            this.dangThanhToanDataGridView.Size = new System.Drawing.Size(737, 227);
            this.dangThanhToanDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maDangTT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã dạng thanh toán";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenDangTT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên dạng thanh toán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tenNganHang";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên ngân hàng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "soTaiKhoang";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số tài khoảng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(227, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 87);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childXoaHTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dangThanhToanDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaHTTT";
            this.Text = "Xóa hình thước thanh toán";
            this.Load += new System.EventHandler(this.frm_childXoaHTTT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangThanhToanBindingSource;
        private QLNhaThuocDataSetTableAdapters.dangThanhToanTableAdapter dangThanhToanTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dangThanhToanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox soTaiKhoangTextBox;
        private System.Windows.Forms.TextBox tenNganHangTextBox;
        private System.Windows.Forms.TextBox tenDangTTTextBox;
        private System.Windows.Forms.TextBox maDangTTTextBox;
    }
}