
namespace appQLNhaThuoc.Form_view.Form_function
{
    partial class frm_thongTinNhaThuoc
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
            System.Windows.Forms.Label tenNhaThuocLabel;
            System.Windows.Forms.Label diaChiNhaThuocLabel;
            System.Windows.Forms.Label maSoThueLabel;
            System.Windows.Forms.Label sdtNhaThuocLabel;
            this.qLNhaThuocDataSet = new appQLNhaThuoc.QLNhaThuocDataSet();
            this.nhaThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaThuocTableAdapter = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.NhaThuocTableAdapter();
            this.tableAdapterManager = new appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager();
            this.tenNhaThuocTextBox = new System.Windows.Forms.TextBox();
            this.diaChiNhaThuocTextBox = new System.Windows.Forms.TextBox();
            this.maSoThueTextBox = new System.Windows.Forms.TextBox();
            this.sdtNhaThuocTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themSuaNT = new System.Windows.Forms.Button();
            this.btn_thoatDongNT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            tenNhaThuocLabel = new System.Windows.Forms.Label();
            diaChiNhaThuocLabel = new System.Windows.Forms.Label();
            maSoThueLabel = new System.Windows.Forms.Label();
            sdtNhaThuocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenNhaThuocLabel
            // 
            tenNhaThuocLabel.AutoSize = true;
            tenNhaThuocLabel.Location = new System.Drawing.Point(26, 72);
            tenNhaThuocLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tenNhaThuocLabel.Name = "tenNhaThuocLabel";
            tenNhaThuocLabel.Size = new System.Drawing.Size(125, 19);
            tenNhaThuocLabel.TabIndex = 1;
            tenNhaThuocLabel.Text = "Tên nhà thuốc";
            // 
            // diaChiNhaThuocLabel
            // 
            diaChiNhaThuocLabel.AutoSize = true;
            diaChiNhaThuocLabel.Location = new System.Drawing.Point(87, 184);
            diaChiNhaThuocLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            diaChiNhaThuocLabel.Name = "diaChiNhaThuocLabel";
            diaChiNhaThuocLabel.Size = new System.Drawing.Size(64, 19);
            diaChiNhaThuocLabel.TabIndex = 5;
            diaChiNhaThuocLabel.Text = "Địa chỉ";
            // 
            // maSoThueLabel
            // 
            maSoThueLabel.AutoSize = true;
            maSoThueLabel.Location = new System.Drawing.Point(53, 240);
            maSoThueLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            maSoThueLabel.Name = "maSoThueLabel";
            maSoThueLabel.Size = new System.Drawing.Size(98, 19);
            maSoThueLabel.TabIndex = 7;
            maSoThueLabel.Text = "Mã số thuế";
            // 
            // sdtNhaThuocLabel
            // 
            sdtNhaThuocLabel.AutoSize = true;
            sdtNhaThuocLabel.Location = new System.Drawing.Point(35, 128);
            sdtNhaThuocLabel.Name = "sdtNhaThuocLabel";
            sdtNhaThuocLabel.Size = new System.Drawing.Size(116, 19);
            sdtNhaThuocLabel.TabIndex = 8;
            sdtNhaThuocLabel.Text = "Số điện thoại";
            sdtNhaThuocLabel.Click += new System.EventHandler(this.sdtNhaThuocLabel_Click);
            // 
            // qLNhaThuocDataSet
            // 
            this.qLNhaThuocDataSet.DataSetName = "QLNhaThuocDataSet";
            this.qLNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaThuocBindingSource
            // 
            this.nhaThuocBindingSource.DataMember = "NhaThuoc";
            this.nhaThuocBindingSource.DataSource = this.qLNhaThuocDataSet;
            // 
            // nhaThuocTableAdapter
            // 
            this.nhaThuocTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.nhaCungCapThuocTableAdapter = null;
            this.tableAdapterManager.nhanVienTableAdapter = null;
            this.tableAdapterManager.NhaThuocTableAdapter = this.nhaThuocTableAdapter;
            this.tableAdapterManager.phieuNhapThuocTableAdapter = null;
            this.tableAdapterManager.quyenHanTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appQLNhaThuoc.QLNhaThuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tenNhaThuocTextBox
            // 
            this.tenNhaThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaThuocBindingSource, "tenNhaThuoc", true));
            this.tenNhaThuocTextBox.Location = new System.Drawing.Point(195, 68);
            this.tenNhaThuocTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tenNhaThuocTextBox.Name = "tenNhaThuocTextBox";
            this.tenNhaThuocTextBox.Size = new System.Drawing.Size(359, 27);
            this.tenNhaThuocTextBox.TabIndex = 2;
            // 
            // diaChiNhaThuocTextBox
            // 
            this.diaChiNhaThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaThuocBindingSource, "diaChiNhaThuoc", true));
            this.diaChiNhaThuocTextBox.Location = new System.Drawing.Point(195, 180);
            this.diaChiNhaThuocTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.diaChiNhaThuocTextBox.Name = "diaChiNhaThuocTextBox";
            this.diaChiNhaThuocTextBox.Size = new System.Drawing.Size(359, 27);
            this.diaChiNhaThuocTextBox.TabIndex = 6;
            // 
            // maSoThueTextBox
            // 
            this.maSoThueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaThuocBindingSource, "maSoThue", true));
            this.maSoThueTextBox.Location = new System.Drawing.Point(195, 236);
            this.maSoThueTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maSoThueTextBox.Name = "maSoThueTextBox";
            this.maSoThueTextBox.Size = new System.Drawing.Size(248, 27);
            this.maSoThueTextBox.TabIndex = 8;
            // 
            // sdtNhaThuocTextBox
            // 
            this.sdtNhaThuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhaThuocBindingSource, "sdtNhaThuoc", true));
            this.sdtNhaThuocTextBox.Location = new System.Drawing.Point(195, 124);
            this.sdtNhaThuocTextBox.Name = "sdtNhaThuocTextBox";
            this.sdtNhaThuocTextBox.Size = new System.Drawing.Size(164, 27);
            this.sdtNhaThuocTextBox.TabIndex = 9;
            this.sdtNhaThuocTextBox.TextChanged += new System.EventHandler(this.sdtNhaThuocTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG TIN NHÀ THUỐC";
            // 
            // btn_themSuaNT
            // 
            this.btn_themSuaNT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themSuaNT.Location = new System.Drawing.Point(184, 315);
            this.btn_themSuaNT.Name = "btn_themSuaNT";
            this.btn_themSuaNT.Size = new System.Drawing.Size(88, 36);
            this.btn_themSuaNT.TabIndex = 11;
            this.btn_themSuaNT.Text = "THÊM";
            this.btn_themSuaNT.UseVisualStyleBackColor = true;
            this.btn_themSuaNT.Click += new System.EventHandler(this.btn_themSuaNT_Click);
            // 
            // btn_thoatDongNT
            // 
            this.btn_thoatDongNT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoatDongNT.Location = new System.Drawing.Point(309, 315);
            this.btn_thoatDongNT.Name = "btn_thoatDongNT";
            this.btn_thoatDongNT.Size = new System.Drawing.Size(88, 36);
            this.btn_thoatDongNT.TabIndex = 12;
            this.btn_thoatDongNT.Text = "THOÁT";
            this.btn_thoatDongNT.UseVisualStyleBackColor = true;
            this.btn_thoatDongNT.Click += new System.EventHandler(this.btn_thoatDongNT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(176, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(176, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(176, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // frm_thongTinNhaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(149)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thoatDongNT);
            this.Controls.Add(this.btn_themSuaNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(sdtNhaThuocLabel);
            this.Controls.Add(this.sdtNhaThuocTextBox);
            this.Controls.Add(maSoThueLabel);
            this.Controls.Add(this.maSoThueTextBox);
            this.Controls.Add(diaChiNhaThuocLabel);
            this.Controls.Add(this.diaChiNhaThuocTextBox);
            this.Controls.Add(tenNhaThuocLabel);
            this.Controls.Add(this.tenNhaThuocTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 425);
            this.MinimumSize = new System.Drawing.Size(604, 425);
            this.Name = "frm_thongTinNhaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN NHÀ THUỐC";
            this.Load += new System.EventHandler(this.frm_thongTinNhaThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaThuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNhaThuocDataSet qLNhaThuocDataSet;
        private System.Windows.Forms.BindingSource nhaThuocBindingSource;
        private QLNhaThuocDataSetTableAdapters.NhaThuocTableAdapter nhaThuocTableAdapter;
        private QLNhaThuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tenNhaThuocTextBox;
        private System.Windows.Forms.TextBox diaChiNhaThuocTextBox;
        private System.Windows.Forms.TextBox maSoThueTextBox;
        private System.Windows.Forms.TextBox sdtNhaThuocTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themSuaNT;
        private System.Windows.Forms.Button btn_thoatDongNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}