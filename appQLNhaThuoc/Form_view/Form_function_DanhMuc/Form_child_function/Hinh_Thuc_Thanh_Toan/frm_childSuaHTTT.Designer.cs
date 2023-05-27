
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.hinhThucThanhToan
{
    partial class frm_childSuaHTTT
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
            System.Windows.Forms.Label maDangTTLabel;
            System.Windows.Forms.Label tenDangTTLabel;
            System.Windows.Forms.Label soTaiKhoangLabel;
            System.Windows.Forms.Label tenNganHangLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.dangThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.maDangTTTextBox = new System.Windows.Forms.TextBox();
            this.soTaiKhoangTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenNganHangTextBox = new System.Windows.Forms.TextBox();
            this.tenDangTTTextBox = new System.Windows.Forms.TextBox();
            maDangTTLabel = new System.Windows.Forms.Label();
            tenDangTTLabel = new System.Windows.Forms.Label();
            soTaiKhoangLabel = new System.Windows.Forms.Label();
            tenNganHangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDangTTLabel
            // 
            maDangTTLabel.AutoSize = true;
            maDangTTLabel.Location = new System.Drawing.Point(13, 27);
            maDangTTLabel.Name = "maDangTTLabel";
            maDangTTLabel.Size = new System.Drawing.Size(153, 18);
            maDangTTLabel.TabIndex = 0;
            maDangTTLabel.Text = "Mã dạng thanh toán";
            // 
            // tenDangTTLabel
            // 
            tenDangTTLabel.AutoSize = true;
            tenDangTTLabel.Location = new System.Drawing.Point(8, 88);
            tenDangTTLabel.Name = "tenDangTTLabel";
            tenDangTTLabel.Size = new System.Drawing.Size(158, 18);
            tenDangTTLabel.TabIndex = 2;
            tenDangTTLabel.Text = "Tên dạng thanh toán";
            // 
            // soTaiKhoangLabel
            // 
            soTaiKhoangLabel.AutoSize = true;
            soTaiKhoangLabel.Location = new System.Drawing.Point(427, 88);
            soTaiKhoangLabel.Name = "soTaiKhoangLabel";
            soTaiKhoangLabel.Size = new System.Drawing.Size(100, 18);
            soTaiKhoangLabel.TabIndex = 6;
            soTaiKhoangLabel.Text = "Số tài khoản";
            soTaiKhoangLabel.Click += new System.EventHandler(this.soTaiKhoangLabel_Click);
            // 
            // tenNganHangLabel
            // 
            tenNganHangLabel.AutoSize = true;
            tenNganHangLabel.Location = new System.Drawing.Point(330, 27);
            tenNganHangLabel.Name = "tenNganHangLabel";
            tenNganHangLabel.Size = new System.Drawing.Size(115, 18);
            tenNganHangLabel.TabIndex = 4;
            tenNganHangLabel.Text = "Tên ngân hàng";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangThanhToanBindingSource
            // 
            this.dangThanhToanBindingSource.DataMember = "dangThanhToan";
            this.dangThanhToanBindingSource.DataSource = this.qLNhaThuocDataSet;
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
            this.dangThanhToanDataGridView.Location = new System.Drawing.Point(0, 131);
            this.dangThanhToanDataGridView.Name = "dangThanhToanDataGridView";
            this.dangThanhToanDataGridView.Size = new System.Drawing.Size(774, 292);
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
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tenNganHang";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên ngân hàng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "soTaiKhoang";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số tài khoản";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(247, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 87);
            this.panel2.TabIndex = 3;
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
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maDangTTTextBox
            // 
            this.maDangTTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "maDangTT", true));
            this.maDangTTTextBox.Location = new System.Drawing.Point(172, 23);
            this.maDangTTTextBox.Name = "maDangTTTextBox";
            this.maDangTTTextBox.ReadOnly = true;
            this.maDangTTTextBox.Size = new System.Drawing.Size(99, 26);
            this.maDangTTTextBox.TabIndex = 1;
            // 
            // soTaiKhoangTextBox
            // 
            this.soTaiKhoangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "soTaiKhoang", true));
            this.soTaiKhoangTextBox.Location = new System.Drawing.Point(533, 84);
            this.soTaiKhoangTextBox.Name = "soTaiKhoangTextBox";
            this.soTaiKhoangTextBox.Size = new System.Drawing.Size(205, 26);
            this.soTaiKhoangTextBox.TabIndex = 7;
            this.soTaiKhoangTextBox.TextChanged += new System.EventHandler(this.soTaiKhoangTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(soTaiKhoangLabel);
            this.panel1.Controls.Add(this.soTaiKhoangTextBox);
            this.panel1.Controls.Add(tenNganHangLabel);
            this.panel1.Controls.Add(this.tenNganHangTextBox);
            this.panel1.Controls.Add(tenDangTTLabel);
            this.panel1.Controls.Add(this.tenDangTTTextBox);
            this.panel1.Controls.Add(maDangTTLabel);
            this.panel1.Controls.Add(this.maDangTTTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 131);
            this.panel1.TabIndex = 0;
            // 
            // tenNganHangTextBox
            // 
            this.tenNganHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "tenNganHang", true));
            this.tenNganHangTextBox.Location = new System.Drawing.Point(461, 23);
            this.tenNganHangTextBox.Name = "tenNganHangTextBox";
            this.tenNganHangTextBox.ReadOnly = true;
            this.tenNganHangTextBox.Size = new System.Drawing.Size(277, 26);
            this.tenNganHangTextBox.TabIndex = 5;
            // 
            // tenDangTTTextBox
            // 
            this.tenDangTTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dangThanhToanBindingSource, "tenDangTT", true));
            this.tenDangTTTextBox.Location = new System.Drawing.Point(172, 84);
            this.tenDangTTTextBox.Name = "tenDangTTTextBox";
            this.tenDangTTTextBox.Size = new System.Drawing.Size(206, 26);
            this.tenDangTTTextBox.TabIndex = 3;
            // 
            // frm_childSuaHTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(774, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dangThanhToanDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaHTTT";
            this.Text = "Sữa hình thức thanh toán";
            this.Load += new System.EventHandler(this.frm_childSuaHTTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TextBox maDangTTTextBox;
        private System.Windows.Forms.TextBox soTaiKhoangTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tenNganHangTextBox;
        private System.Windows.Forms.TextBox tenDangTTTextBox;
    }
}