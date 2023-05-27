
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham
{
    partial class frm_childXoaHDP
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
            System.Windows.Forms.Label diaChiHangDuocLabel;
            System.Windows.Forms.Label emailHangDuocLabel;
            System.Windows.Forms.Label sdtHangDuocLabel;
            System.Windows.Forms.Label tenHangDuocLabel;
            System.Windows.Forms.Label maHangDuocLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.diaChiHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.hangDuocPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.emailHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.sdtHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.tenHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.maHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.hangDuocPhamTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.hangDuocPhamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            diaChiHangDuocLabel = new System.Windows.Forms.Label();
            emailHangDuocLabel = new System.Windows.Forms.Label();
            sdtHangDuocLabel = new System.Windows.Forms.Label();
            tenHangDuocLabel = new System.Windows.Forms.Label();
            maHangDuocLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaChiHangDuocLabel
            // 
            diaChiHangDuocLabel.AutoSize = true;
            diaChiHangDuocLabel.Location = new System.Drawing.Point(24, 124);
            diaChiHangDuocLabel.Name = "diaChiHangDuocLabel";
            diaChiHangDuocLabel.Size = new System.Drawing.Size(94, 16);
            diaChiHangDuocLabel.TabIndex = 8;
            diaChiHangDuocLabel.Text = "Địa chỉ trụ sở";
            // 
            // emailHangDuocLabel
            // 
            emailHangDuocLabel.AutoSize = true;
            emailHangDuocLabel.Location = new System.Drawing.Point(480, 71);
            emailHangDuocLabel.Name = "emailHangDuocLabel";
            emailHangDuocLabel.Size = new System.Drawing.Size(40, 16);
            emailHangDuocLabel.TabIndex = 6;
            emailHangDuocLabel.Text = "Email";
            // 
            // sdtHangDuocLabel
            // 
            sdtHangDuocLabel.AutoSize = true;
            sdtHangDuocLabel.Location = new System.Drawing.Point(428, 17);
            sdtHangDuocLabel.Name = "sdtHangDuocLabel";
            sdtHangDuocLabel.Size = new System.Drawing.Size(92, 16);
            sdtHangDuocLabel.TabIndex = 4;
            sdtHangDuocLabel.Text = "Số điện thoại";
            // 
            // tenHangDuocLabel
            // 
            tenHangDuocLabel.AutoSize = true;
            tenHangDuocLabel.Location = new System.Drawing.Point(15, 71);
            tenHangDuocLabel.Name = "tenHangDuocLabel";
            tenHangDuocLabel.Size = new System.Drawing.Size(103, 16);
            tenHangDuocLabel.TabIndex = 2;
            tenHangDuocLabel.Text = "Tên hãng dược";
            // 
            // maHangDuocLabel
            // 
            maHangDuocLabel.AutoSize = true;
            maHangDuocLabel.Location = new System.Drawing.Point(19, 17);
            maHangDuocLabel.Name = "maHangDuocLabel";
            maHangDuocLabel.Size = new System.Drawing.Size(99, 16);
            maHangDuocLabel.TabIndex = 0;
            maHangDuocLabel.Text = "Mã hãng dược";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diaChiHangDuocTextBox);
            this.panel2.Controls.Add(this.emailHangDuocTextBox);
            this.panel2.Controls.Add(this.sdtHangDuocTextBox);
            this.panel2.Controls.Add(this.tenHangDuocTextBox);
            this.panel2.Controls.Add(this.maHangDuocTextBox);
            this.panel2.Controls.Add(diaChiHangDuocLabel);
            this.panel2.Controls.Add(emailHangDuocLabel);
            this.panel2.Controls.Add(sdtHangDuocLabel);
            this.panel2.Controls.Add(tenHangDuocLabel);
            this.panel2.Controls.Add(maHangDuocLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 168);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // diaChiHangDuocTextBox
            // 
            this.diaChiHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "diaChiHangDuoc", true));
            this.diaChiHangDuocTextBox.Location = new System.Drawing.Point(138, 121);
            this.diaChiHangDuocTextBox.Name = "diaChiHangDuocTextBox";
            this.diaChiHangDuocTextBox.ReadOnly = true;
            this.diaChiHangDuocTextBox.Size = new System.Drawing.Size(325, 23);
            this.diaChiHangDuocTextBox.TabIndex = 14;
            // 
            // hangDuocPhamBindingSource
            // 
            this.hangDuocPhamBindingSource.DataMember = "hangDuocPham";
            this.hangDuocPhamBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailHangDuocTextBox
            // 
            this.emailHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "emailHangDuoc", true));
            this.emailHangDuocTextBox.Location = new System.Drawing.Point(545, 68);
            this.emailHangDuocTextBox.Name = "emailHangDuocTextBox";
            this.emailHangDuocTextBox.ReadOnly = true;
            this.emailHangDuocTextBox.Size = new System.Drawing.Size(221, 23);
            this.emailHangDuocTextBox.TabIndex = 12;
            this.emailHangDuocTextBox.TextChanged += new System.EventHandler(this.emailHangDuocTextBox_TextChanged);
            // 
            // sdtHangDuocTextBox
            // 
            this.sdtHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "sdtHangDuoc", true));
            this.sdtHangDuocTextBox.Location = new System.Drawing.Point(545, 14);
            this.sdtHangDuocTextBox.Name = "sdtHangDuocTextBox";
            this.sdtHangDuocTextBox.ReadOnly = true;
            this.sdtHangDuocTextBox.Size = new System.Drawing.Size(186, 23);
            this.sdtHangDuocTextBox.TabIndex = 11;
            // 
            // tenHangDuocTextBox
            // 
            this.tenHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "tenHangDuoc", true));
            this.tenHangDuocTextBox.Location = new System.Drawing.Point(138, 68);
            this.tenHangDuocTextBox.Name = "tenHangDuocTextBox";
            this.tenHangDuocTextBox.ReadOnly = true;
            this.tenHangDuocTextBox.Size = new System.Drawing.Size(244, 23);
            this.tenHangDuocTextBox.TabIndex = 10;
            // 
            // maHangDuocTextBox
            // 
            this.maHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "maHangDuoc", true));
            this.maHangDuocTextBox.Location = new System.Drawing.Point(138, 14);
            this.maHangDuocTextBox.Name = "maHangDuocTextBox";
            this.maHangDuocTextBox.ReadOnly = true;
            this.maHangDuocTextBox.Size = new System.Drawing.Size(144, 23);
            this.maHangDuocTextBox.TabIndex = 9;
            this.maHangDuocTextBox.TextChanged += new System.EventHandler(this.maHangDuocTextBox_TextChanged);
            // 
            // hangDuocPhamTableAdapter
            // 
            this.hangDuocPhamTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.giaDonHangTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = this.hangDuocPhamTableAdapter;
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
            // hangDuocPhamDataGridView
            // 
            this.hangDuocPhamDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hangDuocPhamDataGridView.AutoGenerateColumns = false;
            this.hangDuocPhamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hangDuocPhamDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.hangDuocPhamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangDuocPhamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hangDuocPhamDataGridView.DataSource = this.hangDuocPhamBindingSource;
            this.hangDuocPhamDataGridView.Location = new System.Drawing.Point(0, 174);
            this.hangDuocPhamDataGridView.Name = "hangDuocPhamDataGridView";
            this.hangDuocPhamDataGridView.Size = new System.Drawing.Size(815, 296);
            this.hangDuocPhamDataGridView.TabIndex = 18;
            this.hangDuocPhamDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hangDuocPhamDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maHangDuoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hãng dược";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenHangDuoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hãng dược";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sdtHangDuoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "emailHangDuoc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diaChiHangDuoc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ trụ sở";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(279, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 76);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childXoaHDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(815, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hangDuocPhamDataGridView);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaHDP";
            this.Text = "Xóa thông tin hảng dược";
            this.Load += new System.EventHandler(this.frm_childXoaHDP_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource hangDuocPhamBindingSource;
        private QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter hangDuocPhamTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maHangDuocTextBox;
        private System.Windows.Forms.TextBox diaChiHangDuocTextBox;
        private System.Windows.Forms.TextBox emailHangDuocTextBox;
        private System.Windows.Forms.TextBox sdtHangDuocTextBox;
        private System.Windows.Forms.TextBox tenHangDuocTextBox;
        private System.Windows.Forms.DataGridView hangDuocPhamDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}