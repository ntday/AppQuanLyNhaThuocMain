
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.hinhThucThanhToan
{
    partial class frm_childThemHTTT
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
            System.Windows.Forms.Label tenDangTTLabel;
            System.Windows.Forms.Label tenNganHangLabel;
            System.Windows.Forms.Label soTaiKhoangLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.dangThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangThanhToanTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.dangThanhToanTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_tenDangThanhT = new System.Windows.Forms.TextBox();
            this.text_tenTaiKhoangTT = new System.Windows.Forms.TextBox();
            this.text_stkThanhToan = new System.Windows.Forms.TextBox();
            tenDangTTLabel = new System.Windows.Forms.Label();
            tenNganHangLabel = new System.Windows.Forms.Label();
            soTaiKhoangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenDangTTLabel
            // 
            tenDangTTLabel.AutoSize = true;
            tenDangTTLabel.Location = new System.Drawing.Point(15, 18);
            tenDangTTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenDangTTLabel.Name = "tenDangTTLabel";
            tenDangTTLabel.Size = new System.Drawing.Size(143, 16);
            tenDangTTLabel.TabIndex = 3;
            tenDangTTLabel.Text = "Tên dạng thanh toán";
            // 
            // tenNganHangLabel
            // 
            tenNganHangLabel.AutoSize = true;
            tenNganHangLabel.Location = new System.Drawing.Point(55, 73);
            tenNganHangLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenNganHangLabel.Name = "tenNganHangLabel";
            tenNganHangLabel.Size = new System.Drawing.Size(103, 16);
            tenNganHangLabel.TabIndex = 5;
            tenNganHangLabel.Text = "Tên ngân hàng";
            // 
            // soTaiKhoangLabel
            // 
            soTaiKhoangLabel.AutoSize = true;
            soTaiKhoangLabel.Location = new System.Drawing.Point(70, 129);
            soTaiKhoangLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soTaiKhoangLabel.Name = "soTaiKhoangLabel";
            soTaiKhoangLabel.Size = new System.Drawing.Size(88, 16);
            soTaiKhoangLabel.TabIndex = 7;
            soTaiKhoangLabel.Text = "Số tài khoản";
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangThanhToanBindingSource
            // 
            this.dangThanhToanBindingSource.DataMember = "dangThanhToan";
            this.dangThanhToanBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // dangThanhToanTableAdapter
            // 
            this.dangThanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.chiTietPhiepNhapTableAdapter = null;
            this.tableAdapterManager.DangKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.dangThanhToanTableAdapter = this.dangThanhToanTableAdapter;
            this.tableAdapterManager.donViTinhTableAdapter = null;
            this.tableAdapterManager.hangDuocPhamTableAdapter = null;
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(102, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 70);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_tenDangThanhT
            // 
            this.text_tenDangThanhT.Location = new System.Drawing.Point(166, 18);
            this.text_tenDangThanhT.Name = "text_tenDangThanhT";
            this.text_tenDangThanhT.Size = new System.Drawing.Size(159, 23);
            this.text_tenDangThanhT.TabIndex = 10;
            // 
            // text_tenTaiKhoangTT
            // 
            this.text_tenTaiKhoangTT.Location = new System.Drawing.Point(166, 73);
            this.text_tenTaiKhoangTT.Name = "text_tenTaiKhoangTT";
            this.text_tenTaiKhoangTT.Size = new System.Drawing.Size(210, 23);
            this.text_tenTaiKhoangTT.TabIndex = 11;
            // 
            // text_stkThanhToan
            // 
            this.text_stkThanhToan.Location = new System.Drawing.Point(166, 122);
            this.text_stkThanhToan.Name = "text_stkThanhToan";
            this.text_stkThanhToan.Size = new System.Drawing.Size(252, 23);
            this.text_stkThanhToan.TabIndex = 12;
            // 
            // frm_childThemHTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.text_stkThanhToan);
            this.Controls.Add(this.text_tenTaiKhoangTT);
            this.Controls.Add(this.text_tenDangThanhT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(soTaiKhoangLabel);
            this.Controls.Add(tenNganHangLabel);
            this.Controls.Add(tenDangTTLabel);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(613, 416);
            this.Name = "frm_childThemHTTT";
            this.Text = "Thêm dạng thanh toán";
            this.Load += new System.EventHandler(this.frm_childThemHTTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangThanhToanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource dangThanhToanBindingSource;
        private QLNhaThuocDataSetTableAdapters.dangThanhToanTableAdapter dangThanhToanTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_tenDangThanhT;
        private System.Windows.Forms.TextBox text_tenTaiKhoangTT;
        private System.Windows.Forms.TextBox text_stkThanhToan;
    }
}