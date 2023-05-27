
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Nha_Cung_Cap
{
    partial class frm_childThemNCC
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
            this.textMaNCC = new System.Windows.Forms.TextBox();
            this.textTenNCC = new System.Windows.Forms.TextBox();
            this.textSDTNCC = new System.Windows.Forms.TextBox();
            this.textEmailNCC = new System.Windows.Forms.TextBox();
            this.textDiaChiNCC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            maNhaCungCapLabel = new System.Windows.Forms.Label();
            tenNhaCungCapLabel = new System.Windows.Forms.Label();
            sdtNhaCungCapLabel = new System.Windows.Forms.Label();
            emailNhaCungCapLabel = new System.Windows.Forms.Label();
            diaChiNhaCungCapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNhaCungCapLabel
            // 
            maNhaCungCapLabel.AutoSize = true;
            maNhaCungCapLabel.Location = new System.Drawing.Point(24, 23);
            maNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maNhaCungCapLabel.Name = "maNhaCungCapLabel";
            maNhaCungCapLabel.Size = new System.Drawing.Size(122, 16);
            maNhaCungCapLabel.TabIndex = 1;
            maNhaCungCapLabel.Text = "Mã nhà cung cấp:";
            // 
            // tenNhaCungCapLabel
            // 
            tenNhaCungCapLabel.AutoSize = true;
            tenNhaCungCapLabel.Location = new System.Drawing.Point(20, 77);
            tenNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenNhaCungCapLabel.Name = "tenNhaCungCapLabel";
            tenNhaCungCapLabel.Size = new System.Drawing.Size(126, 16);
            tenNhaCungCapLabel.TabIndex = 3;
            tenNhaCungCapLabel.Text = "Tên nhà cung cấp:";
            // 
            // sdtNhaCungCapLabel
            // 
            sdtNhaCungCapLabel.AutoSize = true;
            sdtNhaCungCapLabel.Location = new System.Drawing.Point(49, 134);
            sdtNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sdtNhaCungCapLabel.Name = "sdtNhaCungCapLabel";
            sdtNhaCungCapLabel.Size = new System.Drawing.Size(97, 16);
            sdtNhaCungCapLabel.TabIndex = 5;
            sdtNhaCungCapLabel.Text = "Số điện thoại:";
            // 
            // emailNhaCungCapLabel
            // 
            emailNhaCungCapLabel.AutoSize = true;
            emailNhaCungCapLabel.Location = new System.Drawing.Point(101, 193);
            emailNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailNhaCungCapLabel.Name = "emailNhaCungCapLabel";
            emailNhaCungCapLabel.Size = new System.Drawing.Size(45, 16);
            emailNhaCungCapLabel.TabIndex = 7;
            emailNhaCungCapLabel.Text = "Email:";
            // 
            // diaChiNhaCungCapLabel
            // 
            diaChiNhaCungCapLabel.AutoSize = true;
            diaChiNhaCungCapLabel.Location = new System.Drawing.Point(47, 250);
            diaChiNhaCungCapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diaChiNhaCungCapLabel.Name = "diaChiNhaCungCapLabel";
            diaChiNhaCungCapLabel.Size = new System.Drawing.Size(99, 16);
            diaChiNhaCungCapLabel.TabIndex = 9;
            diaChiNhaCungCapLabel.Text = "Địa chỉ trụ sở:";
            diaChiNhaCungCapLabel.Click += new System.EventHandler(this.diaChiNhaCungCapLabel_Click);
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
            // textMaNCC
            // 
            this.textMaNCC.Location = new System.Drawing.Point(153, 20);
            this.textMaNCC.Name = "textMaNCC";
            this.textMaNCC.Size = new System.Drawing.Size(124, 23);
            this.textMaNCC.TabIndex = 10;
            // 
            // textTenNCC
            // 
            this.textTenNCC.Location = new System.Drawing.Point(153, 74);
            this.textTenNCC.Name = "textTenNCC";
            this.textTenNCC.Size = new System.Drawing.Size(203, 23);
            this.textTenNCC.TabIndex = 11;
            // 
            // textSDTNCC
            // 
            this.textSDTNCC.Location = new System.Drawing.Point(153, 131);
            this.textSDTNCC.Name = "textSDTNCC";
            this.textSDTNCC.Size = new System.Drawing.Size(170, 23);
            this.textSDTNCC.TabIndex = 12;
            // 
            // textEmailNCC
            // 
            this.textEmailNCC.Location = new System.Drawing.Point(153, 193);
            this.textEmailNCC.Name = "textEmailNCC";
            this.textEmailNCC.Size = new System.Drawing.Size(203, 23);
            this.textEmailNCC.TabIndex = 13;
            // 
            // textDiaChiNCC
            // 
            this.textDiaChiNCC.Location = new System.Drawing.Point(153, 247);
            this.textDiaChiNCC.Name = "textDiaChiNCC";
            this.textDiaChiNCC.Size = new System.Drawing.Size(288, 23);
            this.textDiaChiNCC.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(100, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 76);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 26);
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
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childThemNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textDiaChiNCC);
            this.Controls.Add(this.textEmailNCC);
            this.Controls.Add(this.textSDTNCC);
            this.Controls.Add(this.textTenNCC);
            this.Controls.Add(this.textMaNCC);
            this.Controls.Add(diaChiNhaCungCapLabel);
            this.Controls.Add(emailNhaCungCapLabel);
            this.Controls.Add(sdtNhaCungCapLabel);
            this.Controls.Add(tenNhaCungCapLabel);
            this.Controls.Add(maNhaCungCapLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemNCC";
            this.Text = "frm_childThemNCC";
            this.Load += new System.EventHandler(this.frm_childThemNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapThuocBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhaCungCapThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.nhaCungCapThuocTableAdapter nhaCungCapThuocTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textMaNCC;
        private System.Windows.Forms.TextBox textTenNCC;
        private System.Windows.Forms.TextBox textSDTNCC;
        private System.Windows.Forms.TextBox textEmailNCC;
        private System.Windows.Forms.TextBox textDiaChiNCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}