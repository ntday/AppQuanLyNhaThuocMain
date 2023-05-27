
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham
{
    partial class frm_childSuaHDP
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
            System.Windows.Forms.Label maHangDuocLabel;
            System.Windows.Forms.Label tenHangDuocLabel;
            System.Windows.Forms.Label sdtHangDuocLabel;
            System.Windows.Forms.Label emailHangDuocLabel;
            System.Windows.Forms.Label diaChiHangDuocLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.hangDuocPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangDuocPhamTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hangDuocPhamDataGridView = new System.Windows.Forms.DataGridView();
            this.maHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiHangDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.tenHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.sdtHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.emailHangDuocTextBox = new System.Windows.Forms.TextBox();
            this.diaChiHangDuocTextBox = new System.Windows.Forms.TextBox();
            maHangDuocLabel = new System.Windows.Forms.Label();
            tenHangDuocLabel = new System.Windows.Forms.Label();
            sdtHangDuocLabel = new System.Windows.Forms.Label();
            emailHangDuocLabel = new System.Windows.Forms.Label();
            diaChiHangDuocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tenHangDuocLabel
            // 
            tenHangDuocLabel.AutoSize = true;
            tenHangDuocLabel.Location = new System.Drawing.Point(15, 68);
            tenHangDuocLabel.Name = "tenHangDuocLabel";
            tenHangDuocLabel.Size = new System.Drawing.Size(103, 16);
            tenHangDuocLabel.TabIndex = 2;
            tenHangDuocLabel.Text = "Tên hãng dược";
            // 
            // sdtHangDuocLabel
            // 
            sdtHangDuocLabel.AutoSize = true;
            sdtHangDuocLabel.Location = new System.Drawing.Point(428, 20);
            sdtHangDuocLabel.Name = "sdtHangDuocLabel";
            sdtHangDuocLabel.Size = new System.Drawing.Size(92, 16);
            sdtHangDuocLabel.TabIndex = 4;
            sdtHangDuocLabel.Text = "Số điện thoại";
            // 
            // emailHangDuocLabel
            // 
            emailHangDuocLabel.AutoSize = true;
            emailHangDuocLabel.Location = new System.Drawing.Point(480, 64);
            emailHangDuocLabel.Name = "emailHangDuocLabel";
            emailHangDuocLabel.Size = new System.Drawing.Size(40, 16);
            emailHangDuocLabel.TabIndex = 6;
            emailHangDuocLabel.Text = "Email";
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
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangDuocPhamBindingSource
            // 
            this.hangDuocPhamBindingSource.DataMember = "hangDuocPham";
            this.hangDuocPhamBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // hangDuocPhamTableAdapter
            // 
            this.hangDuocPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = null;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = this.hangDuocPhamTableAdapter;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(272, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 84);
            this.panel1.TabIndex = 16;
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
            this.panel2.Size = new System.Drawing.Size(815, 167);
            this.panel2.TabIndex = 17;
            // 
            // hangDuocPhamDataGridView
            // 
            this.hangDuocPhamDataGridView.AutoGenerateColumns = false;
            this.hangDuocPhamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hangDuocPhamDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.hangDuocPhamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangDuocPhamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDuoc,
            this.tenHangDuoc,
            this.sdtHangDuoc,
            this.emailHangDuoc,
            this.diaChiHangDuoc});
            this.hangDuocPhamDataGridView.DataSource = this.hangDuocPhamBindingSource;
            this.hangDuocPhamDataGridView.Location = new System.Drawing.Point(0, 172);
            this.hangDuocPhamDataGridView.Name = "hangDuocPhamDataGridView";
            this.hangDuocPhamDataGridView.Size = new System.Drawing.Size(815, 296);
            this.hangDuocPhamDataGridView.TabIndex = 17;
            this.hangDuocPhamDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hangDuocPhamDataGridView_CellClick_1);
            this.hangDuocPhamDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hangDuocPhamDataGridView_CellContentClick_1);
            // 
            // maHangDuoc
            // 
            this.maHangDuoc.DataPropertyName = "maHangDuoc";
            this.maHangDuoc.HeaderText = "Mã hãng dược";
            this.maHangDuoc.Name = "maHangDuoc";
            // 
            // tenHangDuoc
            // 
            this.tenHangDuoc.DataPropertyName = "tenHangDuoc";
            this.tenHangDuoc.HeaderText = "Tên hãng dược";
            this.tenHangDuoc.Name = "tenHangDuoc";
            // 
            // sdtHangDuoc
            // 
            this.sdtHangDuoc.DataPropertyName = "sdtHangDuoc";
            this.sdtHangDuoc.HeaderText = "Số điện thoại";
            this.sdtHangDuoc.Name = "sdtHangDuoc";
            // 
            // emailHangDuoc
            // 
            this.emailHangDuoc.DataPropertyName = "emailHangDuoc";
            this.emailHangDuoc.HeaderText = "Email";
            this.emailHangDuoc.Name = "emailHangDuoc";
            // 
            // diaChiHangDuoc
            // 
            this.diaChiHangDuoc.DataPropertyName = "diaChiHangDuoc";
            this.diaChiHangDuoc.HeaderText = "Địa chỉ trụ sở";
            this.diaChiHangDuoc.Name = "diaChiHangDuoc";
            // 
            // maHangDuocTextBox
            // 
            this.maHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "maHangDuoc", true));
            this.maHangDuocTextBox.Location = new System.Drawing.Point(145, 17);
            this.maHangDuocTextBox.Name = "maHangDuocTextBox";
            this.maHangDuocTextBox.Size = new System.Drawing.Size(100, 23);
            this.maHangDuocTextBox.TabIndex = 9;
            // 
            // tenHangDuocTextBox
            // 
            this.tenHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "tenHangDuoc", true));
            this.tenHangDuocTextBox.Location = new System.Drawing.Point(145, 68);
            this.tenHangDuocTextBox.Name = "tenHangDuocTextBox";
            this.tenHangDuocTextBox.Size = new System.Drawing.Size(155, 23);
            this.tenHangDuocTextBox.TabIndex = 10;
            // 
            // sdtHangDuocTextBox
            // 
            this.sdtHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "sdtHangDuoc", true));
            this.sdtHangDuocTextBox.Location = new System.Drawing.Point(545, 17);
            this.sdtHangDuocTextBox.Name = "sdtHangDuocTextBox";
            this.sdtHangDuocTextBox.Size = new System.Drawing.Size(171, 23);
            this.sdtHangDuocTextBox.TabIndex = 11;
            // 
            // emailHangDuocTextBox
            // 
            this.emailHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "emailHangDuoc", true));
            this.emailHangDuocTextBox.Location = new System.Drawing.Point(545, 64);
            this.emailHangDuocTextBox.Name = "emailHangDuocTextBox";
            this.emailHangDuocTextBox.Size = new System.Drawing.Size(214, 23);
            this.emailHangDuocTextBox.TabIndex = 12;
            // 
            // diaChiHangDuocTextBox
            // 
            this.diaChiHangDuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangDuocPhamBindingSource, "diaChiHangDuoc", true));
            this.diaChiHangDuocTextBox.Location = new System.Drawing.Point(145, 124);
            this.diaChiHangDuocTextBox.Name = "diaChiHangDuocTextBox";
            this.diaChiHangDuocTextBox.Size = new System.Drawing.Size(192, 23);
            this.diaChiHangDuocTextBox.TabIndex = 13;
            // 
            // frm_childSuaHDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(815, 570);
            this.Controls.Add(this.hangDuocPhamDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childSuaHDP";
            this.Text = "Sửa thông tin hãng dược";
            this.Load += new System.EventHandler(this.frm_childSuaHDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource hangDuocPhamBindingSource;
        private QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter hangDuocPhamTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView hangDuocPhamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailHangDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiHangDuoc;
        private System.Windows.Forms.TextBox diaChiHangDuocTextBox;
        private System.Windows.Forms.TextBox emailHangDuocTextBox;
        private System.Windows.Forms.TextBox sdtHangDuocTextBox;
        private System.Windows.Forms.TextBox tenHangDuocTextBox;
        private System.Windows.Forms.TextBox maHangDuocTextBox;
    }
}