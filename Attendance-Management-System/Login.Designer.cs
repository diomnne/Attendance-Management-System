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
            this.lbl_emptyEmail = new System.Windows.Forms.Label();
            this.lbl_emptyPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btn_login.Location = new System.Drawing.Point(1055, 912);
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
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1042, 493);
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
            this.txt_password.Location = new System.Drawing.Point(1055, 781);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Radius = 5;
            this.txt_password.Size = new System.Drawing.Size(502, 65);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "1234";
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
            this.txt_email.Text = "admin@gmail.com";
            // 
            // lbl_emptyEmail
            // 
            this.lbl_emptyEmail.AutoSize = true;
            this.lbl_emptyEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_emptyEmail.Location = new System.Drawing.Point(1321, 712);
            this.lbl_emptyEmail.Name = "lbl_emptyEmail";
            this.lbl_emptyEmail.Size = new System.Drawing.Size(236, 25);
            this.lbl_emptyEmail.TabIndex = 8;
            this.lbl_emptyEmail.Text = "Email is a required field";
            this.lbl_emptyEmail.Visible = false;
            // 
            // lbl_emptyPass
            // 
            this.lbl_emptyPass.AutoSize = true;
            this.lbl_emptyPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_emptyPass.Location = new System.Drawing.Point(1364, 849);
            this.lbl_emptyPass.Name = "lbl_emptyPass";
            this.lbl_emptyPass.Size = new System.Drawing.Size(193, 25);
            this.lbl_emptyPass.TabIndex = 9;
            this.lbl_emptyPass.Text = "Incorrect password";
            this.lbl_emptyPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1049, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(1049, 746);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2534, 1529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_emptyPass);
            this.Controls.Add(this.lbl_emptyEmail);
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
        private System.Windows.Forms.Label lbl_emptyEmail;
        private System.Windows.Forms.Label lbl_emptyPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}