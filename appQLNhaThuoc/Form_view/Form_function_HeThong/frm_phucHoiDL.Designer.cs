
namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    partial class frm_phucHoiDL
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
            this.label3_url = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label2_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3_url
            // 
            this.label3_url.BackColor = System.Drawing.SystemColors.Control;
            this.label3_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_url.ForeColor = System.Drawing.Color.Black;
            this.label3_url.Location = new System.Drawing.Point(150, 107);
            this.label3_url.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3_url.Name = "label3_url";
            this.label3_url.Size = new System.Drawing.Size(421, 24);
            this.label3_url.TabIndex = 10;
            this.label3_url.Text = "url";
            this.label3_url.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn đường dẫn chứa file sau lưu:";
            // 
            // label2_time
            // 
            this.label2_time.AutoSize = true;
            this.label2_time.ForeColor = System.Drawing.Color.Black;
            this.label2_time.Location = new System.Drawing.Point(190, 48);
            this.label2_time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2_time.Name = "label2_time";
            this.label2_time.Size = new System.Drawing.Size(75, 13);
            this.label2_time.TabIndex = 8;
            this.label2_time.Text = "25/05/2023";
            this.label2_time.Click += new System.EventHandler(this.label2_time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời gian sao lưu: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "url";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 152);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Bắt đầu khôi phục";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_phucHoiDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 268);
            this.Controls.Add(this.label3_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label2_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_phucHoiDL";
            this.Text = "Phục hòi dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label2_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}