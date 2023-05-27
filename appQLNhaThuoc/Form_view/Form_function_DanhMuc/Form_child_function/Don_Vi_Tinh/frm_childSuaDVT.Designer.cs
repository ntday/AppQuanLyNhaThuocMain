
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh
{
    partial class frm_childSuaDVT
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
            System.Windows.Forms.Label maDVTLabel;
            System.Windows.Forms.Label tenDVTLabel;
            System.Windows.Forms.Label moTaDVTLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.donViTinhTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.donViTinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maDVTTextBox = new System.Windows.Forms.TextBox();
            this.tenDVTTextBox = new System.Windows.Forms.TextBox();
            this.moTaDVTTextBox = new System.Windows.Forms.TextBox();
            maDVTLabel = new System.Windows.Forms.Label();
            tenDVTLabel = new System.Windows.Forms.Label();
            moTaDVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDVTLabel
            // 
            maDVTLabel.AutoSize = true;
            maDVTLabel.Location = new System.Drawing.Point(31, 18);
            maDVTLabel.Name = "maDVTLabel";
            maDVTLabel.Size = new System.Drawing.Size(112, 18);
            maDVTLabel.TabIndex = 2;
            maDVTLabel.Text = "Mã đơn vị tính";
            // 
            // tenDVTLabel
            // 
            tenDVTLabel.AutoSize = true;
            tenDVTLabel.Location = new System.Drawing.Point(326, 18);
            tenDVTLabel.Name = "tenDVTLabel";
            tenDVTLabel.Size = new System.Drawing.Size(117, 18);
            tenDVTLabel.TabIndex = 4;
            tenDVTLabel.Text = "Tên đơn vị tính";
            // 
            // moTaDVTLabel
            // 
            moTaDVTLabel.AutoSize = true;
            moTaDVTLabel.Location = new System.Drawing.Point(12, 70);
            moTaDVTLabel.Name = "moTaDVTLabel";
            moTaDVTLabel.Size = new System.Drawing.Size(131, 18);
            moTaDVTLabel.TabIndex = 6;
            moTaDVTLabel.Text = "Mô tả đơn vị tính";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "donViTinh";
            this.donViTinhBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.donViTinhTableAdapter = this.donViTinhTableAdapter;
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
            // donViTinhDataGridView
            // 
            this.donViTinhDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donViTinhDataGridView.AutoGenerateColumns = false;
            this.donViTinhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.donViTinhDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.donViTinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donViTinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.donViTinhDataGridView.DataSource = this.donViTinhBindingSource;
            this.donViTinhDataGridView.Location = new System.Drawing.Point(1, 104);
            this.donViTinhDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.donViTinhDataGridView.Name = "donViTinhDataGridView";
            this.donViTinhDataGridView.Size = new System.Drawing.Size(619, 289);
            this.donViTinhDataGridView.TabIndex = 1;
            this.donViTinhDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donViTinhDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maDVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã đơn vị tính";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenDVT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên đơn vị tính";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "moTaDVT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mô tả đơn vị tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(237, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 76);
            this.panel1.TabIndex = 2;
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
            this.button1.Location = new System.Drawing.Point(0, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "LƯU THAY ĐỔI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maDVTTextBox
            // 
            this.maDVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donViTinhBindingSource, "maDVT", true));
            this.maDVTTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDVTTextBox.Location = new System.Drawing.Point(149, 15);
            this.maDVTTextBox.Name = "maDVTTextBox";
            this.maDVTTextBox.ReadOnly = true;
            this.maDVTTextBox.Size = new System.Drawing.Size(157, 26);
            this.maDVTTextBox.TabIndex = 3;
            this.maDVTTextBox.TextChanged += new System.EventHandler(this.maDVTTextBox_TextChanged);
            // 
            // tenDVTTextBox
            // 
            this.tenDVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donViTinhBindingSource, "tenDVT", true));
            this.tenDVTTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDVTTextBox.Location = new System.Drawing.Point(449, 15);
            this.tenDVTTextBox.Name = "tenDVTTextBox";
            this.tenDVTTextBox.Size = new System.Drawing.Size(126, 26);
            this.tenDVTTextBox.TabIndex = 5;
            // 
            // moTaDVTTextBox
            // 
            this.moTaDVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donViTinhBindingSource, "moTaDVT", true));
            this.moTaDVTTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTaDVTTextBox.Location = new System.Drawing.Point(149, 67);
            this.moTaDVTTextBox.Name = "moTaDVTTextBox";
            this.moTaDVTTextBox.Size = new System.Drawing.Size(426, 26);
            this.moTaDVTTextBox.TabIndex = 7;
            // 
            // frm_childSuaDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(620, 509);
            this.Controls.Add(moTaDVTLabel);
            this.Controls.Add(this.moTaDVTTextBox);
            this.Controls.Add(tenDVTLabel);
            this.Controls.Add(this.tenDVTTextBox);
            this.Controls.Add(maDVTLabel);
            this.Controls.Add(this.maDVTTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.donViTinhDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaDVT";
            this.Text = "Chỉnh sửa thông đơn vị tính";
            this.Load += new System.EventHandler(this.frm_childSuaDVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private QLNhaThuocDataSetTableAdapters.donViTinhTableAdapter donViTinhTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView donViTinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox maDVTTextBox;
        private System.Windows.Forms.TextBox tenDVTTextBox;
        private System.Windows.Forms.TextBox moTaDVTTextBox;
    }
}