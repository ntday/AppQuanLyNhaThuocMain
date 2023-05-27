
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    partial class frm_childSuaNCC
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
            System.Windows.Forms.Label maNhaCungCapLabel;
            System.Windows.Forms.Label tenNhaCungCapLabel;
            System.Windows.Forms.Label sdtNhaCungCapLabel;
            System.Windows.Forms.Label emailNhaCungCapLabel;
            System.Windows.Forms.Label diaChiNhaCungCapLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhaCungCapThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhaCungCapThuocTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.nhaCungCapThuocDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diaChiNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.emailNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.sdtNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.tenNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.maNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhaCungCapLabel = new System.Windows.Forms.Label();
            tenNhaCungCapLabel = new System.Windows.Forms.Label();
            sdtNhaCungCapLabel = new System.Windows.Forms.Label();
            emailNhaCungCapLabel = new System.Windows.Forms.Label();
            diaChiNhaCungCapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNhaCungCapLabel
            // 
            maNhaCungCapLabel.AutoSize = true;
            maNhaCungCapLabel.Location = new System.Drawing.Point(32, 24);
            maNhaCungCapLabel.Name = "maNhaCungCapLabel";
            maNhaCungCapLabel.Size = new System.Drawing.Size(130, 18);
            maNhaCungCapLabel.TabIndex = 0;
            maNhaCungCapLabel.Text = "Mã nhà cung cấp";
            // 
            // tenNhaCungCapLabel
            // 
            tenNhaCungCapLabel.AutoSize = true;
            tenNhaCungCapLabel.Location = new System.Drawing.Point(27, 69);
            tenNhaCungCapLabel.Name = "tenNhaCungCapLabel";
            tenNhaCungCapLabel.Size = new System.Drawing.Size(135, 18);
            tenNhaCungCapLabel.TabIndex = 2;
            tenNhaCungCapLabel.Text = "Tên nhà cung cấp";
            // 
            // sdtNhaCungCapLabel
            // 
            sdtNhaCungCapLabel.AutoSize = true;
            sdtNhaCungCapLabel.Location = new System.Drawing.Point(438, 24);
            sdtNhaCungCapLabel.Name = "sdtNhaCungCapLabel";
            sdtNhaCungCapLabel.Size = new System.Drawing.Size(105, 18);
            sdtNhaCungCapLabel.TabIndex = 4;
            sdtNhaCungCapLabel.Text = "Số điện thoại";
            // 
            // emailNhaCungCapLabel
            // 
            emailNhaCungCapLabel.AutoSize = true;
            emailNhaCungCapLabel.Location = new System.Drawing.Point(494, 69);
            emailNhaCungCapLabel.Name = "emailNhaCungCapLabel";
            emailNhaCungCapLabel.Size = new System.Drawing.Size(49, 18);
            emailNhaCungCapLabel.TabIndex = 6;
            emailNhaCungCapLabel.Text = "Email";
            // 
            // diaChiNhaCungCapLabel
            // 
            diaChiNhaCungCapLabel.AutoSize = true;
            diaChiNhaCungCapLabel.Location = new System.Drawing.Point(55, 119);
            diaChiNhaCungCapLabel.Name = "diaChiNhaCungCapLabel";
            diaChiNhaCungCapLabel.Size = new System.Drawing.Size(107, 18);
            diaChiNhaCungCapLabel.TabIndex = 8;
            diaChiNhaCungCapLabel.Text = "Địa chỉ trụ sở";
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
            this.maNhaCungCap,
            this.tenNhaCungCap,
            this.sdtNhaCungCap,
            this.emailNhaCungCap,
            this.diaChiNhaCungCap});
            this.nhaCungCapThuocDataGridView.DataSource = this.nhaCungCapThuocBindingSource;
            this.nhaCungCapThuocDataGridView.Location = new System.Drawing.Point(1, 168);
            this.nhaCungCapThuocDataGridView.Name = "nhaCungCapThuocDataGridView";
            this.nhaCungCapThuocDataGridView.Size = new System.Drawing.Size(908, 355);
            this.nhaCungCapThuocDataGridView.TabIndex = 1;
            this.nhaCungCapThuocDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhaCungCapThuocDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(diaChiNhaCungCapLabel);
            this.panel1.Controls.Add(this.diaChiNhaCungCapTextBox);
            this.panel1.Controls.Add(emailNhaCungCapLabel);
            this.panel1.Controls.Add(this.emailNhaCungCapTextBox);
            this.panel1.Controls.Add(sdtNhaCungCapLabel);
            this.panel1.Controls.Add(this.sdtNhaCungCapTextBox);
            this.panel1.Controls.Add(tenNhaCungCapLabel);
            this.panel1.Controls.Add(this.tenNhaCungCapTextBox);
            this.panel1.Controls.Add(maNhaCungCapLabel);
            this.panel1.Controls.Add(this.maNhaCungCapTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 162);
            this.panel1.TabIndex = 2;
            // 
            // diaChiNhaCungCapTextBox
            // 
            this.diaChiNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "diaChiNhaCungCap", true));
            this.diaChiNhaCungCapTextBox.Location = new System.Drawing.Point(179, 115);
            this.diaChiNhaCungCapTextBox.Name = "diaChiNhaCungCapTextBox";
            this.diaChiNhaCungCapTextBox.Size = new System.Drawing.Size(364, 26);
            this.diaChiNhaCungCapTextBox.TabIndex = 9;
            // 
            // emailNhaCungCapTextBox
            // 
            this.emailNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "emailNhaCungCap", true));
            this.emailNhaCungCapTextBox.Location = new System.Drawing.Point(558, 65);
            this.emailNhaCungCapTextBox.Name = "emailNhaCungCapTextBox";
            this.emailNhaCungCapTextBox.Size = new System.Drawing.Size(297, 26);
            this.emailNhaCungCapTextBox.TabIndex = 7;
            this.emailNhaCungCapTextBox.TextChanged += new System.EventHandler(this.emailNhaCungCapTextBox_TextChanged);
            // 
            // sdtNhaCungCapTextBox
            // 
            this.sdtNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "sdtNhaCungCap", true));
            this.sdtNhaCungCapTextBox.Location = new System.Drawing.Point(558, 20);
            this.sdtNhaCungCapTextBox.Name = "sdtNhaCungCapTextBox";
            this.sdtNhaCungCapTextBox.Size = new System.Drawing.Size(213, 26);
            this.sdtNhaCungCapTextBox.TabIndex = 5;
            this.sdtNhaCungCapTextBox.TextChanged += new System.EventHandler(this.sdtNhaCungCapTextBox_TextChanged);
            // 
            // tenNhaCungCapTextBox
            // 
            this.tenNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "tenNhaCungCap", true));
            this.tenNhaCungCapTextBox.Location = new System.Drawing.Point(179, 65);
            this.tenNhaCungCapTextBox.Name = "tenNhaCungCapTextBox";
            this.tenNhaCungCapTextBox.Size = new System.Drawing.Size(231, 26);
            this.tenNhaCungCapTextBox.TabIndex = 3;
            // 
            // maNhaCungCapTextBox
            // 
            this.maNhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaCungCapThuocBindingSource, "maNhaCungCap", true));
            this.maNhaCungCapTextBox.Location = new System.Drawing.Point(179, 20);
            this.maNhaCungCapTextBox.Name = "maNhaCungCapTextBox";
            this.maNhaCungCapTextBox.Size = new System.Drawing.Size(169, 26);
            this.maNhaCungCapTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(324, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 76);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maNhaCungCap
            // 
            this.maNhaCungCap.DataPropertyName = "maNhaCungCap";
            this.maNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.maNhaCungCap.Name = "maNhaCungCap";
            // 
            // tenNhaCungCap
            // 
            this.tenNhaCungCap.DataPropertyName = "tenNhaCungCap";
            this.tenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.tenNhaCungCap.Name = "tenNhaCungCap";
            // 
            // sdtNhaCungCap
            // 
            this.sdtNhaCungCap.DataPropertyName = "sdtNhaCungCap";
            this.sdtNhaCungCap.HeaderText = "Số điện thoại";
            this.sdtNhaCungCap.Name = "sdtNhaCungCap";
            // 
            // emailNhaCungCap
            // 
            this.emailNhaCungCap.DataPropertyName = "emailNhaCungCap";
            this.emailNhaCungCap.HeaderText = "Email";
            this.emailNhaCungCap.Name = "emailNhaCungCap";
            // 
            // diaChiNhaCungCap
            // 
            this.diaChiNhaCungCap.DataPropertyName = "diaChiNhaCungCap";
            this.diaChiNhaCungCap.HeaderText = "Địa chỉ trụ sở";
            this.diaChiNhaCungCap.Name = "diaChiNhaCungCap";
            // 
            // frm_childSuaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(909, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nhaCungCapThuocDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaNCC";
            this.Text = "Sửa thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_childSuaNCC_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox diaChiNhaCungCapTextBox;
        private System.Windows.Forms.TextBox emailNhaCungCapTextBox;
        private System.Windows.Forms.TextBox sdtNhaCungCapTextBox;
        private System.Windows.Forms.TextBox tenNhaCungCapTextBox;
        private System.Windows.Forms.TextBox maNhaCungCapTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNhaCungCap;
    }
}