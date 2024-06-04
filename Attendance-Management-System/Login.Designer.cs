namespace Attendance_Management_System
{
    partial class Login
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
            this.btn_login = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_password = new Guna.UI.WinForms.GunaTextBox();
            this.txt_email = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = null;
            this.btn_login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_login.Location = new System.Drawing.Point(1055, 906);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_login.Radius = 5;
            this.btn_login.Size = new System.Drawing.Size(502, 65);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Log in";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1042, 519);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(515, 75);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Welcome Back!";
            // 
            // txt_password
            // 
            this.txt_password.BaseColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.Silver;
            this.txt_password.BorderSize = 1;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.Location = new System.Drawing.Point(1055, 762);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.Radius = 5;
            this.txt_password.Size = new System.Drawing.Size(502, 65);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.BaseColor = System.Drawing.Color.White;
            this.txt_email.BorderColor = System.Drawing.Color.Silver;
            this.txt_email.BorderSize = 1;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.Location = new System.Drawing.Point(1055, 644);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.Radius = 5;
            this.txt_email.Size = new System.Drawing.Size(502, 65);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_login;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_password;
        private Guna.UI.WinForms.GunaTextBox txt_email;
    }
}