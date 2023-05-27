
namespace appQLNhaThuoc.Form_view.Form_function_HeThong
{
    partial class frm_sauLuuDL
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_url = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "url";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian sao lưu: ";
            // 
            // label2_time
            // 
            this.label2_time.AutoSize = true;
            this.label2_time.ForeColor = System.Drawing.Color.Black;
            this.label2_time.Location = new System.Drawing.Point(245, 26);
            this.label2_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_time.Name = "label2_time";
            this.label2_time.Size = new System.Drawing.Size(79, 15);
            this.label2_time.TabIndex = 2;
            this.label2_time.Text = "25/05/2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn đường dẫn lưu file:";
            // 
            // label3_url
            // 
            this.label3_url.BackColor = System.Drawing.SystemColors.Control;
            this.label3_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_url.ForeColor = System.Drawing.Color.Black;
            this.label3_url.Location = new System.Drawing.Point(113, 85);
            this.label3_url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3_url.Name = "label3_url";
            this.label3_url.Size = new System.Drawing.Size(375, 24);
            this.label3_url.TabIndex = 4;
            this.label3_url.Text = "url";
            this.label3_url.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3_url.Click += new System.EventHandler(this.label3_url_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bắt đầu sao lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_sauLuuDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label2_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_sauLuuDL";
            this.Text = "sau lưu dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_url;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}