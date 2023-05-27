
namespace appQLNhaThuoc.Form_view.Form_function
{
    partial class frm_QLNhomThuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton3 = new appQLNhaThuoc.VBButton();
            this.vbButton2 = new appQLNhaThuoc.VBButton();
            this.vbButton1 = new appQLNhaThuoc.VBButton();
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhomThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.nhomThuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.vbButton2);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 66);
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
            this.vbButton3.Location = new System.Drawing.Point(346, 17);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(4);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(156, 35);
            this.vbButton3.TabIndex = 2;
            this.vbButton3.Text = "Xóa";
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
            this.vbButton2.Location = new System.Drawing.Point(182, 17);
            this.vbButton2.Margin = new System.Windows.Forms.Padding(4);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(156, 35);
            this.vbButton2.TabIndex = 1;
            this.vbButton2.Text = "Chỉnh sửa";
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
            this.vbButton1.Location = new System.Drawing.Point(18, 17);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(4);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(156, 35);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.Text = "Thêm mới";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
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
            this.nhomThuocDataGridView.AutoGenerateColumns = false;
            this.nhomThuocDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhomThuocDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nhomThuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomThuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nhomThuocDataGridView.DataSource = this.nhomThuocBindingSource;
            this.nhomThuocDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomThuocDataGridView.Location = new System.Drawing.Point(0, 66);
            this.nhomThuocDataGridView.Name = "nhomThuocDataGridView";
            this.nhomThuocDataGridView.Size = new System.Drawing.Size(707, 340);
            this.nhomThuocDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maNhomThuoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhóm thuốc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenNhomThuoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên nhóm Thuốc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "moTa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frm_QLNhomThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(707, 406);
            this.Controls.Add(this.nhomThuocDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLNhomThuoc";
            this.Text = "Quản lý nhóm thuốc";
            this.Load += new System.EventHandler(this.frm_QLNhomThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VBButton vbButton3;
        private VBButton vbButton2;
        private VBButton vbButton1;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhomThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter nhomThuocTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhomThuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}