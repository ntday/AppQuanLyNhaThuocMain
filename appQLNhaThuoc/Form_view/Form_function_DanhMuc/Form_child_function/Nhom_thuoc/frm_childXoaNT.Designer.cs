﻿
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nhom_thuoc
{
    partial class frm_childXoaNT
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
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label tenNhomThuocLabel;
            System.Windows.Forms.Label maNhomThuocLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhomThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.nhomThuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moTaTextBox = new System.Windows.Forms.TextBox();
            this.tenNhomThuocTextBox = new System.Windows.Forms.TextBox();
            this.maNhomThuocTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            moTaLabel = new System.Windows.Forms.Label();
            tenNhomThuocLabel = new System.Windows.Forms.Label();
            maNhomThuocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(311, 19);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(51, 16);
            moTaLabel.TabIndex = 7;
            moTaLabel.Text = "mo Ta:";
            // 
            // tenNhomThuocLabel
            // 
            tenNhomThuocLabel.AutoSize = true;
            tenNhomThuocLabel.Location = new System.Drawing.Point(24, 65);
            tenNhomThuocLabel.Name = "tenNhomThuocLabel";
            tenNhomThuocLabel.Size = new System.Drawing.Size(111, 16);
            tenNhomThuocLabel.TabIndex = 6;
            tenNhomThuocLabel.Text = "Tên nhóm thuốc";
            // 
            // maNhomThuocLabel
            // 
            maNhomThuocLabel.AutoSize = true;
            maNhomThuocLabel.Location = new System.Drawing.Point(28, 19);
            maNhomThuocLabel.Name = "maNhomThuocLabel";
            maNhomThuocLabel.Size = new System.Drawing.Size(107, 16);
            maNhomThuocLabel.TabIndex = 5;
            maNhomThuocLabel.Text = "Mã nhóm thuốc";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomThuocBindingSource
            // 
            this.nhomThuocBindingSource.DataMember = "nhomThuoc";
            this.nhomThuocBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // nhomThuocTableAdapter
            // 
            this.nhomThuocTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.nhomThuocTableAdapter = this.nhomThuocTableAdapter;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.phieuXuatThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhomThuocDataGridView
            // 
            this.nhomThuocDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhomThuocDataGridView.AutoGenerateColumns = false;
            this.nhomThuocDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhomThuocDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nhomThuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomThuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nhomThuocDataGridView.DataSource = this.nhomThuocBindingSource;
            this.nhomThuocDataGridView.Location = new System.Drawing.Point(3, 128);
            this.nhomThuocDataGridView.Name = "nhomThuocDataGridView";
            this.nhomThuocDataGridView.Size = new System.Drawing.Size(644, 264);
            this.nhomThuocDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maNhomThuoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "maNhomThuoc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenNhomThuoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "tenNhomThuoc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "moTa";
            this.dataGridViewTextBoxColumn4.HeaderText = "moTa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.moTaTextBox);
            this.panel1.Controls.Add(this.tenNhomThuocTextBox);
            this.panel1.Controls.Add(this.maNhomThuocTextBox);
            this.panel1.Controls.Add(moTaLabel);
            this.panel1.Controls.Add(tenNhomThuocLabel);
            this.panel1.Controls.Add(maNhomThuocLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 122);
            this.panel1.TabIndex = 2;
            // 
            // moTaTextBox
            // 
            this.moTaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomThuocBindingSource, "moTa", true));
            this.moTaTextBox.Location = new System.Drawing.Point(368, 19);
            this.moTaTextBox.Multiline = true;
            this.moTaTextBox.Name = "moTaTextBox";
            this.moTaTextBox.Size = new System.Drawing.Size(260, 69);
            this.moTaTextBox.TabIndex = 10;
            // 
            // tenNhomThuocTextBox
            // 
            this.tenNhomThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomThuocBindingSource, "tenNhomThuoc", true));
            this.tenNhomThuocTextBox.Location = new System.Drawing.Point(141, 65);
            this.tenNhomThuocTextBox.Name = "tenNhomThuocTextBox";
            this.tenNhomThuocTextBox.Size = new System.Drawing.Size(195, 23);
            this.tenNhomThuocTextBox.TabIndex = 9;
            // 
            // maNhomThuocTextBox
            // 
            this.maNhomThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomThuocBindingSource, "maNhomThuoc", true));
            this.maNhomThuocTextBox.Location = new System.Drawing.Point(141, 16);
            this.maNhomThuocTextBox.Name = "maNhomThuocTextBox";
            this.maNhomThuocTextBox.Size = new System.Drawing.Size(100, 23);
            this.maNhomThuocTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(275, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 79);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childXoaNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(647, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nhomThuocDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childXoaNT";
            this.Text = "Xóa thông tin nhóm thuốc";
            this.Load += new System.EventHandler(this.frm_childXoaNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhomThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter nhomThuocTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhomThuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox moTaTextBox;
        private System.Windows.Forms.TextBox tenNhomThuocTextBox;
        private System.Windows.Forms.TextBox maNhomThuocTextBox;
    }
}