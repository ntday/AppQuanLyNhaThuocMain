
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.Thuoc_child
{
    partial class frm_childThemThuo
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
            this.nhomThuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_congDung = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.nhomThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter();
            this.textBox_thanhPhan = new System.Windows.Forms.TextBox();
            this.textBox_tenThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nhomThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_maThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_nhomThuoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhomThuocBindingSource1
            // 
            this.nhomThuocBindingSource1.DataMember = "nhomThuoc";
            this.nhomThuocBindingSource1.DataSource = this.qLNhaThuocDataSet;
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(99, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 74);
            this.panel1.TabIndex = 31;
            // 
            // textBox_congDung
            // 
            this.textBox_congDung.Location = new System.Drawing.Point(177, 268);
            this.textBox_congDung.Multiline = true;
            this.textBox_congDung.Name = "textBox_congDung";
            this.textBox_congDung.Size = new System.Drawing.Size(232, 69);
            this.textBox_congDung.TabIndex = 30;
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
            // nhomThuocTableAdapter
            // 
            this.nhomThuocTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_thanhPhan
            // 
            this.textBox_thanhPhan.Location = new System.Drawing.Point(177, 168);
            this.textBox_thanhPhan.Multiline = true;
            this.textBox_thanhPhan.Name = "textBox_thanhPhan";
            this.textBox_thanhPhan.Size = new System.Drawing.Size(232, 69);
            this.textBox_thanhPhan.TabIndex = 29;
            // 
            // textBox_tenThuoc
            // 
            this.textBox_tenThuoc.Location = new System.Drawing.Point(177, 67);
            this.textBox_tenThuoc.Name = "textBox_tenThuoc";
            this.textBox_tenThuoc.Size = new System.Drawing.Size(232, 23);
            this.textBox_tenThuoc.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Công dụng chính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Thành phần chính";
            // 
            // nhomThuocBindingSource
            // 
            this.nhomThuocBindingSource.DataMember = "nhomThuoc";
            this.nhomThuocBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // textBox_maThuoc
            // 
            this.textBox_maThuoc.Location = new System.Drawing.Point(177, 18);
            this.textBox_maThuoc.Name = "textBox_maThuoc";
            this.textBox_maThuoc.Size = new System.Drawing.Size(189, 23);
            this.textBox_maThuoc.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhóm thuốc";
            // 
            // comboBox_nhomThuoc
            // 
            this.comboBox_nhomThuoc.DataSource = this.nhomThuocBindingSource1;
            this.comboBox_nhomThuoc.DisplayMember = "tenNhomThuoc";
            this.comboBox_nhomThuoc.FormattingEnabled = true;
            this.comboBox_nhomThuoc.Location = new System.Drawing.Point(181, 118);
            this.comboBox_nhomThuoc.Name = "comboBox_nhomThuoc";
            this.comboBox_nhomThuoc.Size = new System.Drawing.Size(185, 24);
            this.comboBox_nhomThuoc.TabIndex = 34;
            // 
            // frm_childThemThuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(139)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(431, 471);
            this.Controls.Add(this.comboBox_nhomThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_congDung);
            this.Controls.Add(this.textBox_thanhPhan);
            this.Controls.Add(this.textBox_tenThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_maThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_childThemThuo";
            this.Text = "Thêm thông tin thuốc";
            this.Load += new System.EventHandler(this.frm_childThemThuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomThuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nhomThuocBindingSource1;
        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_congDung;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLNhaThuocDataSetTableAdapters.nhomThuocTableAdapter nhomThuocTableAdapter;
        private System.Windows.Forms.TextBox textBox_thanhPhan;
        private System.Windows.Forms.TextBox textBox_tenThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource nhomThuocBindingSource;
        private System.Windows.Forms.TextBox textBox_maThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_nhomThuoc;
    }
}