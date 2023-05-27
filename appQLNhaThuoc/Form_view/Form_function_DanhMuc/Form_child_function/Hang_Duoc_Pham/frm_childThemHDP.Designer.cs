
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Hang_Duoc_Pham
{
    partial class frm_childThemHDP
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
            this.text_maHangDuoc = new System.Windows.Forms.TextBox();
            this.text_tenHangDuoc = new System.Windows.Forms.TextBox();
            this.text_soDienThoai = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_diaChiTruSo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            maHangDuocLabel = new System.Windows.Forms.Label();
            tenHangDuocLabel = new System.Windows.Forms.Label();
            sdtHangDuocLabel = new System.Windows.Forms.Label();
            emailHangDuocLabel = new System.Windows.Forms.Label();
            diaChiHangDuocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maHangDuocLabel
            // 
            maHangDuocLabel.AutoSize = true;
            maHangDuocLabel.Location = new System.Drawing.Point(24, 22);
            maHangDuocLabel.Name = "maHangDuocLabel";
            maHangDuocLabel.Size = new System.Drawing.Size(115, 18);
            maHangDuocLabel.TabIndex = 1;
            maHangDuocLabel.Text = "Mã hãng dược:";
            // 
            // tenHangDuocLabel
            // 
            tenHangDuocLabel.AutoSize = true;
            tenHangDuocLabel.Location = new System.Drawing.Point(24, 77);
            tenHangDuocLabel.Name = "tenHangDuocLabel";
            tenHangDuocLabel.Size = new System.Drawing.Size(120, 18);
            tenHangDuocLabel.TabIndex = 3;
            tenHangDuocLabel.Text = "Tên hãng dược:";
            // 
            // sdtHangDuocLabel
            // 
            sdtHangDuocLabel.AutoSize = true;
            sdtHangDuocLabel.Location = new System.Drawing.Point(24, 136);
            sdtHangDuocLabel.Name = "sdtHangDuocLabel";
            sdtHangDuocLabel.Size = new System.Drawing.Size(110, 18);
            sdtHangDuocLabel.TabIndex = 5;
            sdtHangDuocLabel.Text = "Số điện thoại:";
            // 
            // emailHangDuocLabel
            // 
            emailHangDuocLabel.AutoSize = true;
            emailHangDuocLabel.Location = new System.Drawing.Point(24, 195);
            emailHangDuocLabel.Name = "emailHangDuocLabel";
            emailHangDuocLabel.Size = new System.Drawing.Size(54, 18);
            emailHangDuocLabel.TabIndex = 7;
            emailHangDuocLabel.Text = "Email:";
            // 
            // diaChiHangDuocLabel
            // 
            diaChiHangDuocLabel.AutoSize = true;
            diaChiHangDuocLabel.Location = new System.Drawing.Point(24, 254);
            diaChiHangDuocLabel.Name = "diaChiHangDuocLabel";
            diaChiHangDuocLabel.Size = new System.Drawing.Size(112, 18);
            diaChiHangDuocLabel.TabIndex = 9;
            diaChiHangDuocLabel.Text = "Địa chỉ trụ sở:";
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
            // text_maHangDuoc
            // 
            this.text_maHangDuoc.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_maHangDuoc.Location = new System.Drawing.Point(165, 18);
            this.text_maHangDuoc.Name = "text_maHangDuoc";
            this.text_maHangDuoc.Size = new System.Drawing.Size(150, 26);
            this.text_maHangDuoc.TabIndex = 10;
            // 
            // text_tenHangDuoc
            // 
            this.text_tenHangDuoc.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenHangDuoc.Location = new System.Drawing.Point(165, 74);
            this.text_tenHangDuoc.Name = "text_tenHangDuoc";
            this.text_tenHangDuoc.Size = new System.Drawing.Size(260, 26);
            this.text_tenHangDuoc.TabIndex = 11;
            // 
            // text_soDienThoai
            // 
            this.text_soDienThoai.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_soDienThoai.Location = new System.Drawing.Point(165, 136);
            this.text_soDienThoai.MaxLength = 12;
            this.text_soDienThoai.Name = "text_soDienThoai";
            this.text_soDienThoai.Size = new System.Drawing.Size(150, 26);
            this.text_soDienThoai.TabIndex = 12;
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(165, 195);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(150, 26);
            this.text_email.TabIndex = 13;
            // 
            // text_diaChiTruSo
            // 
            this.text_diaChiTruSo.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_diaChiTruSo.Location = new System.Drawing.Point(165, 246);
            this.text_diaChiTruSo.Name = "text_diaChiTruSo";
            this.text_diaChiTruSo.Size = new System.Drawing.Size(355, 26);
            this.text_diaChiTruSo.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(146, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 76);
            this.panel1.TabIndex = 15;
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
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childThemHDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_diaChiTruSo);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_soDienThoai);
            this.Controls.Add(this.text_tenHangDuoc);
            this.Controls.Add(this.text_maHangDuoc);
            this.Controls.Add(diaChiHangDuocLabel);
            this.Controls.Add(emailHangDuocLabel);
            this.Controls.Add(sdtHangDuocLabel);
            this.Controls.Add(tenHangDuocLabel);
            this.Controls.Add(maHangDuocLabel);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemHDP";
            this.Text = "Thêm thông tin hãng dược";
            this.Load += new System.EventHandler(this.frm_childThemHDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangDuocPhamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource hangDuocPhamBindingSource;
        private QLNhaThuocDataSetTableAdapters.hangDuocPhamTableAdapter hangDuocPhamTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox text_maHangDuoc;
        private System.Windows.Forms.TextBox text_tenHangDuoc;
        private System.Windows.Forms.TextBox text_soDienThoai;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_diaChiTruSo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}