
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Khach_Hang
{
    partial class frm_childThemKH
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
            System.Windows.Forms.Label sdtKHLabel;
            System.Windows.Forms.Label hoHoLotKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label namSinhLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textHoLot = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textNamSinh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            sdtKHLabel = new System.Windows.Forms.Label();
            hoHoLotKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            namSinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdtKHLabel
            // 
            sdtKHLabel.AutoSize = true;
            sdtKHLabel.Location = new System.Drawing.Point(55, 38);
            sdtKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sdtKHLabel.Name = "sdtKHLabel";
            sdtKHLabel.Size = new System.Drawing.Size(143, 23);
            sdtKHLabel.TabIndex = 1;
            sdtKHLabel.Text = "Số điện thoại:";
            // 
            // hoHoLotKHLabel
            // 
            hoHoLotKHLabel.AutoSize = true;
            hoHoLotKHLabel.Location = new System.Drawing.Point(108, 88);
            hoHoLotKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hoHoLotKHLabel.Name = "hoHoLotKHLabel";
            hoHoLotKHLabel.Size = new System.Drawing.Size(76, 23);
            hoHoLotKHLabel.TabIndex = 3;
            hoHoLotKHLabel.Text = "Họ lót:";
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Location = new System.Drawing.Point(125, 131);
            tenKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(52, 23);
            tenKHLabel.TabIndex = 5;
            tenKHLabel.Text = "Tên:";
            // 
            // namSinhLabel
            // 
            namSinhLabel.AutoSize = true;
            namSinhLabel.Location = new System.Drawing.Point(83, 179);
            namSinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            namSinhLabel.Name = "namSinhLabel";
            namSinhLabel.Size = new System.Drawing.Size(107, 23);
            namSinhLabel.TabIndex = 7;
            namSinhLabel.Text = "Năm sinh:";
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
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(183, 35);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(217, 30);
            this.textSDT.TabIndex = 8;
            // 
            // textHoLot
            // 
            this.textHoLot.Location = new System.Drawing.Point(183, 85);
            this.textHoLot.Name = "textHoLot";
            this.textHoLot.Size = new System.Drawing.Size(179, 30);
            this.textHoLot.TabIndex = 9;
            // 
            // textTen
            // 
            this.textTen.Location = new System.Drawing.Point(183, 128);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(137, 30);
            this.textTen.TabIndex = 10;
            // 
            // textNamSinh
            // 
            this.textNamSinh.Location = new System.Drawing.Point(183, 176);
            this.textNamSinh.Name = "textNamSinh";
            this.textNamSinh.Size = new System.Drawing.Size(105, 30);
            this.textNamSinh.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Location = new System.Drawing.Point(103, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 86);
            this.panel1.TabIndex = 12;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(147, 24);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 33);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(8, 24);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 33);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_childThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textNamSinh);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.textHoLot);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(namSinhLabel);
            this.Controls.Add(tenKHLabel);
            this.Controls.Add(hoHoLotKHLabel);
            this.Controls.Add(sdtKHLabel);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemKH";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.frm_childThemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QLNhaThuocDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textHoLot;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textNamSinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
    }
}