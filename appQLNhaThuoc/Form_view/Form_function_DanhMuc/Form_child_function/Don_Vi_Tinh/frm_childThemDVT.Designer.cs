﻿
namespace appQLNhaThuoc.Form_view.Form_function.Form_child_function.DonViTinh
{
    partial class frm_childThemDVT
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_tenDVTmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_moTaDVTmoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đơn vị tính";
            // 
            // text_tenDVTmoi
            // 
            this.text_tenDVTmoi.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenDVTmoi.Location = new System.Drawing.Point(181, 49);
            this.text_tenDVTmoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_tenDVTmoi.Name = "text_tenDVTmoi";
            this.text_tenDVTmoi.Size = new System.Drawing.Size(185, 26);
            this.text_tenDVTmoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            // 
            // text_moTaDVTmoi
            // 
            this.text_moTaDVTmoi.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_moTaDVTmoi.Location = new System.Drawing.Point(181, 100);
            this.text_moTaDVTmoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_moTaDVTmoi.Name = "text_moTaDVTmoi";
            this.text_moTaDVTmoi.Size = new System.Drawing.Size(239, 26);
            this.text_moTaDVTmoi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_childThemDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_moTaDVTmoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_tenDVTmoi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_childThemDVT";
            this.Text = "Thêm mới đơn vị tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_tenDVTmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_moTaDVTmoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}