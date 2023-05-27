
namespace appQLNhaThuoc.Form_view.Form_function
{
    partial class frm_loginUser
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
            this.text_tenLogin = new System.Windows.Forms.TextBox();
            this.text_passLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_showPass = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_thoatLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // text_tenLogin
            // 
            this.text_tenLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tenLogin.Location = new System.Drawing.Point(236, 97);
            this.text_tenLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_tenLogin.Name = "text_tenLogin";
            this.text_tenLogin.Size = new System.Drawing.Size(277, 30);
            this.text_tenLogin.TabIndex = 1;
            this.text_tenLogin.Text = "thanhday";
            // 
            // text_passLogin
            // 
            this.text_passLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_passLogin.Location = new System.Drawing.Point(236, 156);
            this.text_passLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_passLogin.Name = "text_passLogin";
            this.text_passLogin.Size = new System.Drawing.Size(277, 30);
            this.text_passLogin.TabIndex = 3;
            this.text_passLogin.Text = "abc@123";
            this.text_passLogin.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MẬT KHẨU";
            // 
            // check_showPass
            // 
            this.check_showPass.AutoSize = true;
            this.check_showPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_showPass.Location = new System.Drawing.Point(378, 193);
            this.check_showPass.Name = "check_showPass";
            this.check_showPass.Size = new System.Drawing.Size(135, 18);
            this.check_showPass.TabIndex = 4;
            this.check_showPass.Text = "hiển thị mật khẩu";
            this.check_showPass.UseVisualStyleBackColor = true;
            this.check_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(160, 248);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 37);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_thoatLogin
            // 
            this.btn_thoatLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.btn_thoatLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_thoatLogin.Location = new System.Drawing.Point(293, 248);
            this.btn_thoatLogin.Name = "btn_thoatLogin";
            this.btn_thoatLogin.Size = new System.Drawing.Size(109, 37);
            this.btn_thoatLogin.TabIndex = 6;
            this.btn_thoatLogin.Text = "Thoát";
            this.btn_thoatLogin.UseVisualStyleBackColor = false;
            this.btn_thoatLogin.Click += new System.EventHandler(this.btn_thoatLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frm_loginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(149)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(562, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thoatLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.check_showPass);
            this.Controls.Add(this.text_passLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_tenLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 345);
            this.MinimumSize = new System.Drawing.Size(578, 345);
            this.Name = "frm_loginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_loginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_tenLogin;
        private System.Windows.Forms.TextBox text_passLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_showPass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_thoatLogin;
        private System.Windows.Forms.Label label3;
    }
}