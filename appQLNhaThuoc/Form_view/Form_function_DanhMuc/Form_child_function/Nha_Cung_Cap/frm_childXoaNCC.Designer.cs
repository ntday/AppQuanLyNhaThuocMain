
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    partial class frm_childXoaNCC
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
            System.Windows.Forms.Label diaChiNhaCungCapLabel;
            System.Windows.Forms.Label emailNhaCungCapLabel;
            System.Windows.Forms.Label sdtNhaCungCapLabel;
            System.Windows.Forms.Label tenNhaCungCapLabel;
            System.Windows.Forms.Label maNhaCungCapLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhaCungCapThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhaCungCapThuocTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.nhaCungCapThuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diaChiNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.emailNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.sdtNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.tenNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.maNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            diaChiNhaCungCapLabel = new System.Windows.Forms.Label();
            emailNhaCungCapLabel = new System.Windows.Forms.Label();
            sdtNhaCungCapLabel = new System.Windows.Forms.Label();
            tenNhaCungCapLabel = new System.Windows.Forms.Label();
            maNhaCungCapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaChiNhaCungCapLabel
            // 
            diaChiNhaCungCapLabel.AutoSize = true;
            diaChiNhaCungCapLabel.Location = new System.Drawing.Point(66, 146);
            diaChiNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diaChiNhaCungCapLabel.Name = "diaChiNhaCungCapLabel";
            diaChiNhaCungCapLabel.Size = new System.Drawing.Size(94, 16);
            diaChiNhaCungCapLabel.TabIndex = 8;
            diaChiNhaCungCapLabel.Text = "Địa chỉ trụ sở";
            // 
            // emailNhaCungCapLabel
            // 
            emailNhaCungCapLabel.AutoSize = true;
            emailNhaCungCapLabel.Location = new System.Drawing.Point(521, 85);
            emailNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailNhaCungCapLabel.Name = "emailNhaCungCapLabel";
            emailNhaCungCapLabel.Size = new System.Drawing.Size(40, 16);
            emailNhaCungCapLabel.TabIndex = 6;
            emailNhaCungCapLabel.Text = "Email";
            // 
            // sdtNhaCungCapLabel
            // 
            sdtNhaCungCapLabel.AutoSize = true;
            sdtNhaCungCapLabel.Location = new System.Drawing.Point(469, 30);
            sdtNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sdtNhaCungCapLabel.Name = "sdtNhaCungCapLabel";
            sdtNhaCungCapLabel.Size = new System.Drawing.Size(92, 16);
            sdtNhaCungCapLabel.TabIndex = 4;
            sdtNhaCungCapLabel.Text = "Số điện thoại";
            // 
            // tenNhaCungCapLabel
            // 
            tenNhaCungCapLabel.AutoSize = true;
            tenNhaCungCapLabel.Location = new System.Drawing.Point(39, 85);
            tenNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenNhaCungCapLabel.Name = "tenNhaCungCapLabel";
            tenNhaCungCapLabel.Size = new System.Drawing.Size(121, 16);
            tenNhaCungCapLabel.TabIndex = 2;
            tenNhaCungCapLabel.Text = "Tên nhà cung cấp";
            // 
            // maNhaCungCapLabel
            // 
            maNhaCungCapLabel.AutoSize = true;
            maNhaCungCapLabel.Location = new System.Drawing.Point(43, 30);
            maNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maNhaCungCapLabel.Name = "maNhaCungCapLabel";
            maNhaCungCapLabel.Size = new System.Drawing.Size(117, 16);
            maNhaCungCapLabel.TabIndex = 0;
            maNhaCungCapLabel.Text = "Mã nhà cung cấp";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapThuocBindingSource
            // 
            this.nhaCungCapThuocBindingSource.DataMember = "nhaCungCapThuoc";
            this.nhaCungCapThuocBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // nhaCungCapThuocTableAdapter
            // 
            this.nhaCungCapThuocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = null;
            this.tableAdapterManager.hoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.khuyenMaiTableAdapter = null;
            this.tableAdapterManager.loThuocTableAdapter = null;
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = this.nhaCungCapThuocTableAdapter;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = null;
            this.tableAdapterManager.nhatKyHeThongTableAdapter = null;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhaCungCapThuocDataGridView
            // 
            this.nhaCungCapThuocDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhaCungCapThuocDataGridView.AutoGenerateColumns = false;
            this.nhaCungCapThuocDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhaCungCapThuocDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nhaCungCapThuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhaCungCapThuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nhaCungCapThuocDataGridView.DataSource = this.nhaCungCapThuocBindingSource;
            this.nhaCungCapThuocDataGridView.Location = new System.Drawing.Point(0, 212);
            this.nhaCungCapThuocDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.nhaCungCapThuocDataGridView.Name = "nhaCungCapThuocDataGridView";
            this.nhaCungCapThuocDataGridView.ReadOnly = true;
            this.nhaCungCapThuocDataGridView.Size = new System.Drawing.Size(909, 311);
            this.nhaCungCapThuocDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maNhaCungCap";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenNhaCungCap";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sdtNhaCungCap";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "emailNhaCungCap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diaChiNhaCungCap";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ trụ sở";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diaChiNhaCungCapTextBox);
            this.panel1.Controls.Add(this.emailNhaCungCapTextBox);
            this.panel1.Controls.Add(this.sdtNhaCungCapTextBox);
            this.panel1.Controls.Add(this.tenNhaCungCapTextBox);
            this.panel1.Controls.Add(this.maNhaCungCapTextBox);
            this.panel1.Controls.Add(diaChiNhaCungCapLabel);
            this.panel1.Controls.Add(emailNhaCungCapLabel);
            this.panel1.Controls.Add(sdtNhaCungCapLabel);
            this.panel1.Controls.Add(tenNhaCungCapLabel);
            this.panel1.Controls.Add(maNhaCungCapLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 199);
            this.panel1.TabIndex = 3;
            // 
            // diaChiNhaCungCapTextBox
            // 
            this.diaChiNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "diaChiNhaCungCap", true));
            this.diaChiNhaCungCapTextBox.Location = new System.Drawing.Point(195, 143);
            this.diaChiNhaCungCapTextBox.Name = "diaChiNhaCungCapTextBox";
            this.diaChiNhaCungCapTextBox.ReadOnly = true;
            this.diaChiNhaCungCapTextBox.Size = new System.Drawing.Size(375, 23);
            this.diaChiNhaCungCapTextBox.TabIndex = 14;
            // 
            // emailNhaCungCapTextBox
            // 
            this.emailNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "emailNhaCungCap", true));
            this.emailNhaCungCapTextBox.Location = new System.Drawing.Point(589, 82);
            this.emailNhaCungCapTextBox.Name = "emailNhaCungCapTextBox";
            this.emailNhaCungCapTextBox.ReadOnly = true;
            this.emailNhaCungCapTextBox.Size = new System.Drawing.Size(243, 23);
            this.emailNhaCungCapTextBox.TabIndex = 12;
            // 
            // sdtNhaCungCapTextBox
            // 
            this.sdtNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "sdtNhaCungCap", true));
            this.sdtNhaCungCapTextBox.Location = new System.Drawing.Point(589, 27);
            this.sdtNhaCungCapTextBox.Name = "sdtNhaCungCapTextBox";
            this.sdtNhaCungCapTextBox.ReadOnly = true;
            this.sdtNhaCungCapTextBox.Size = new System.Drawing.Size(182, 23);
            this.sdtNhaCungCapTextBox.TabIndex = 11;
            // 
            // tenNhaCungCapTextBox
            // 
            this.tenNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "tenNhaCungCap", true));
            this.tenNhaCungCapTextBox.Location = new System.Drawing.Point(195, 82);
            this.tenNhaCungCapTextBox.Name = "tenNhaCungCapTextBox";
            this.tenNhaCungCapTextBox.ReadOnly = true;
            this.tenNhaCungCapTextBox.Size = new System.Drawing.Size(308, 23);
            this.tenNhaCungCapTextBox.TabIndex = 10;
            // 
            // maNhaCungCapTextBox
            // 
            this.maNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "maNhaCungCap", true));
            this.maNhaCungCapTextBox.Location = new System.Drawing.Point(195, 27);
            this.maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            this.maNhaCungCapTextBox.ReadOnly = true;
            this.maNhaCungCapTextBox.Size = new System.Drawing.Size(190, 23);
            this.maNhaCungCapTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(359, 531);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 83);
            this.panel2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childXoaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(909, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nhaCungCapThuocDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaNCC";
            this.Text = "Xóa thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_childXoaNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhaCungCapThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.nhaCungCapThuocTableAdapter nhaCungCapThuocTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhaCungCapThuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox diaChiNhaCungCapTextBox;
        private System.Windows.Forms.TextBox emailNhaCungCapTextBox;
        private System.Windows.Forms.TextBox sdtNhaCungCapTextBox;
        private System.Windows.Forms.TextBox tenNhaCungCapTextBox;
        private System.Windows.Forms.TextBox maNhaCungCapTextBox;
    }
}