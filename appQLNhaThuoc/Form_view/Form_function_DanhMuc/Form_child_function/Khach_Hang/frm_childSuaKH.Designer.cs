
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang
{
    partial class frm_childSuaKH
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
            System.Windows.Forms.Label namSinhLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label hoHoLotKHLabel;
            System.Windows.Forms.Label sdtKHLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.khachHangDataGridView = new System.Windows.Forms.DataGridView();
            this.sdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoHoLotKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.namSinhTextBox = new System.Windows.Forms.TextBox();
            this.tenKHTextBox = new System.Windows.Forms.TextBox();
            this.hoHoLotKHTextBox = new System.Windows.Forms.TextBox();
            this.sdtKHTextBox = new System.Windows.Forms.TextBox();
            namSinhLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            hoHoLotKHLabel = new System.Windows.Forms.Label();
            sdtKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namSinhLabel
            // 
            namSinhLabel.AutoSize = true;
            namSinhLabel.Location = new System.Drawing.Point(488, 101);
            namSinhLabel.Name = "namSinhLabel";
            namSinhLabel.Size = new System.Drawing.Size(77, 18);
            namSinhLabel.TabIndex = 15;
            namSinhLabel.Text = "Năm sinh";
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Location = new System.Drawing.Point(442, 33);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(123, 18);
            tenKHLabel.TabIndex = 13;
            tenKHLabel.Text = "Tên khách hàng";
            // 
            // hoHoLotKHLabel
            // 
            hoHoLotKHLabel.AutoSize = true;
            hoHoLotKHLabel.Location = new System.Drawing.Point(138, 101);
            hoHoLotKHLabel.Name = "hoHoLotKHLabel";
            hoHoLotKHLabel.Size = new System.Drawing.Size(74, 18);
            hoHoLotKHLabel.TabIndex = 11;
            hoHoLotKHLabel.Text = "Họ họ lót";
            // 
            // sdtKHLabel
            // 
            sdtKHLabel.AutoSize = true;
            sdtKHLabel.Location = new System.Drawing.Point(107, 33);
            sdtKHLabel.Name = "sdtKHLabel";
            sdtKHLabel.Size = new System.Drawing.Size(105, 18);
            sdtKHLabel.TabIndex = 9;
            sdtKHLabel.Text = "Số điện thoại";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
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
            // khachHangDataGridView
            // 
            this.khachHangDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachHangDataGridView.AutoGenerateColumns = false;
            this.khachHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachHangDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.khachHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdtKH,
            this.hoHoLotKH,
            this.tenKH,
            this.namSinh});
            this.khachHangDataGridView.DataSource = this.khachHangBindingSource;
            this.khachHangDataGridView.Location = new System.Drawing.Point(0, 159);
            this.khachHangDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.khachHangDataGridView.Name = "khachHangDataGridView";
            this.khachHangDataGridView.Size = new System.Drawing.Size(839, 313);
            this.khachHangDataGridView.TabIndex = 1;
            this.khachHangDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachHangDataGridView_CellClick);
            this.khachHangDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachHangDataGridView_CellContentClick);
            // 
            // sdtKH
            // 
            this.sdtKH.DataPropertyName = "sdtKH";
            this.sdtKH.HeaderText = "Số điện thoại KH";
            this.sdtKH.Name = "sdtKH";
            // 
            // hoHoLotKH
            // 
            this.hoHoLotKH.DataPropertyName = "hoHoLotKH";
            this.hoHoLotKH.HeaderText = "Họ lót KH";
            this.hoHoLotKH.Name = "hoHoLotKH";
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "Tên KH";
            this.tenKH.Name = "tenKH";
            // 
            // namSinh
            // 
            this.namSinh.DataPropertyName = "namSinh";
            this.namSinh.HeaderText = "Năm sinh";
            this.namSinh.Name = "namSinh";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(323, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 87);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(namSinhLabel);
            this.panel1.Controls.Add(this.namSinhTextBox);
            this.panel1.Controls.Add(tenKHLabel);
            this.panel1.Controls.Add(this.tenKHTextBox);
            this.panel1.Controls.Add(hoHoLotKHLabel);
            this.panel1.Controls.Add(this.hoHoLotKHTextBox);
            this.panel1.Controls.Add(sdtKHLabel);
            this.panel1.Controls.Add(this.sdtKHTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 152);
            this.panel1.TabIndex = 10;
            // 
            // namSinhTextBox
            // 
            this.namSinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "namSinh", true));
            this.namSinhTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namSinhTextBox.Location = new System.Drawing.Point(591, 97);
            this.namSinhTextBox.MaxLength = 4;
            this.namSinhTextBox.Name = "namSinhTextBox";
            this.namSinhTextBox.Size = new System.Drawing.Size(100, 26);
            this.namSinhTextBox.TabIndex = 16;
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "tenKH", true));
            this.tenKHTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKHTextBox.Location = new System.Drawing.Point(591, 29);
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Size = new System.Drawing.Size(143, 26);
            this.tenKHTextBox.TabIndex = 14;
            // 
            // hoHoLotKHTextBox
            // 
            this.hoHoLotKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "hoHoLotKH", true));
            this.hoHoLotKHTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoHoLotKHTextBox.Location = new System.Drawing.Point(224, 97);
            this.hoHoLotKHTextBox.Name = "hoHoLotKHTextBox";
            this.hoHoLotKHTextBox.Size = new System.Drawing.Size(165, 26);
            this.hoHoLotKHTextBox.TabIndex = 12;
            // 
            // sdtKHTextBox
            // 
            this.sdtKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "sdtKH", true));
            this.sdtKHTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtKHTextBox.Location = new System.Drawing.Point(224, 29);
            this.sdtKHTextBox.MaxLength = 11;
            this.sdtKHTextBox.Name = "sdtKHTextBox";
            this.sdtKHTextBox.Size = new System.Drawing.Size(150, 26);
            this.sdtKHTextBox.TabIndex = 10;
            // 
            // frm_childSuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(840, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.khachHangDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaKH";
            this.Text = "Sửa thông tin khách hàng";
            this.Load += new System.EventHandler(this.frm_childSuaKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QLNhaThuocDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView khachHangDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox namSinhTextBox;
        private System.Windows.Forms.TextBox tenKHTextBox;
        private System.Windows.Forms.TextBox hoHoLotKHTextBox;
        private System.Windows.Forms.TextBox sdtKHTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoHoLotKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
    }
}