
namespace bdOOPFinalPj
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlCabain = new System.Windows.Forms.Panel();
            this.cboCabain = new System.Windows.Forms.ComboBox();
            this.lblCabain = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlLogin1 = new System.Windows.Forms.Panel();
            this.lblU2 = new System.Windows.Forms.Label();
            this.lblU1 = new System.Windows.Forms.Label();
            this.pbLogoU = new System.Windows.Forms.PictureBox();
            this.pbLogoApp = new System.Windows.Forms.PictureBox();
            this.pnlLogin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnlCabain.SuspendLayout();
            this.pnlLogin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin2
            // 
            this.pnlLogin2.BackColor = System.Drawing.Color.White;
            this.pnlLogin2.Controls.Add(this.txtPassword);
            this.pnlLogin2.Controls.Add(this.pbClose);
            this.pnlLogin2.Controls.Add(this.lblLogin);
            this.pnlLogin2.Controls.Add(this.lblUsername);
            this.pnlLogin2.Controls.Add(this.txtUsername);
            this.pnlLogin2.Controls.Add(this.lblPassword);
            this.pnlLogin2.Controls.Add(this.btnLogin);
            this.pnlLogin2.Controls.Add(this.pnlCabain);
            this.pnlLogin2.Controls.Add(this.pnlUsername);
            this.pnlLogin2.Controls.Add(this.pnlPassword);
            this.pnlLogin2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLogin2.Location = new System.Drawing.Point(204, 0);
            this.pnlLogin2.Name = "pnlLogin2";
            this.pnlLogin2.Size = new System.Drawing.Size(547, 456);
            this.pnlLogin2.TabIndex = 1;
            this.pnlLogin2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin2_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(156, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::bdOOPFinalPj.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(510, 7);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 32);
            this.pbClose.TabIndex = 16;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(216, 53);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(152, 18);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Log into your account";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Silver;
            this.lblUsername.Location = new System.Drawing.Point(156, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(156, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(156, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(162, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlCabain
            // 
            this.pnlCabain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlCabain.Controls.Add(this.cboCabain);
            this.pnlCabain.Controls.Add(this.lblCabain);
            this.pnlCabain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCabain.Location = new System.Drawing.Point(0, 360);
            this.pnlCabain.Name = "pnlCabain";
            this.pnlCabain.Size = new System.Drawing.Size(547, 96);
            this.pnlCabain.TabIndex = 8;
            // 
            // cboCabain
            // 
            this.cboCabain.BackColor = System.Drawing.Color.White;
            this.cboCabain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCabain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCabain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboCabain.FormattingEnabled = true;
            this.cboCabain.Location = new System.Drawing.Point(219, 41);
            this.cboCabain.Name = "cboCabain";
            this.cboCabain.Size = new System.Drawing.Size(121, 24);
            this.cboCabain.TabIndex = 4;
            // 
            // lblCabain
            // 
            this.lblCabain.AutoSize = true;
            this.lblCabain.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCabain.Location = new System.Drawing.Point(216, 10);
            this.lblCabain.Name = "lblCabain";
            this.lblCabain.Size = new System.Drawing.Size(142, 13);
            this.lblCabain.TabIndex = 0;
            this.lblCabain.Text = "Please, select your cabain ";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Silver;
            this.pnlUsername.Location = new System.Drawing.Point(156, 164);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(243, 1);
            this.pnlUsername.TabIndex = 14;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Silver;
            this.pnlPassword.Location = new System.Drawing.Point(156, 258);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(243, 1);
            this.pnlPassword.TabIndex = 12;
            // 
            // pnlLogin1
            // 
            this.pnlLogin1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlLogin1.Controls.Add(this.lblU2);
            this.pnlLogin1.Controls.Add(this.lblU1);
            this.pnlLogin1.Controls.Add(this.pbLogoU);
            this.pnlLogin1.Controls.Add(this.pbLogoApp);
            this.pnlLogin1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLogin1.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin1.Name = "pnlLogin1";
            this.pnlLogin1.Size = new System.Drawing.Size(206, 456);
            this.pnlLogin1.TabIndex = 0;
            // 
            // lblU2
            // 
            this.lblU2.AutoSize = true;
            this.lblU2.Font = new System.Drawing.Font("Roboto", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblU2.Location = new System.Drawing.Point(92, 422);
            this.lblU2.Name = "lblU2";
            this.lblU2.Size = new System.Drawing.Size(74, 10);
            this.lblU2.TabIndex = 4;
            this.lblU2.Text = "José Simeón Cañas";
            // 
            // lblU1
            // 
            this.lblU1.AutoSize = true;
            this.lblU1.Font = new System.Drawing.Font("Roboto", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblU1.Location = new System.Drawing.Point(77, 409);
            this.lblU1.Name = "lblU1";
            this.lblU1.Size = new System.Drawing.Size(109, 10);
            this.lblU1.TabIndex = 2;
            this.lblU1.Text = "Universidad Centroamericana";
            // 
            // pbLogoU
            // 
            this.pbLogoU.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoU.Image = global::bdOOPFinalPj.Properties.Resources.UCA_logo;
            this.pbLogoU.Location = new System.Drawing.Point(12, 384);
            this.pbLogoU.Name = "pbLogoU";
            this.pbLogoU.Size = new System.Drawing.Size(64, 60);
            this.pbLogoU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoU.TabIndex = 3;
            this.pbLogoU.TabStop = false;
            // 
            // pbLogoApp
            // 
            this.pbLogoApp.Image = global::bdOOPFinalPj.Properties.Resources.HAPPA_littler;
            this.pbLogoApp.Location = new System.Drawing.Point(51, 91);
            this.pbLogoApp.Name = "pbLogoApp";
            this.pbLogoApp.Size = new System.Drawing.Size(101, 93);
            this.pbLogoApp.TabIndex = 0;
            this.pbLogoApp.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 456);
            this.Controls.Add(this.pnlLogin1);
            this.Controls.Add(this.pnlLogin2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.pnlLogin2.ResumeLayout(false);
            this.pnlLogin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnlCabain.ResumeLayout(false);
            this.pnlCabain.PerformLayout();
            this.pnlLogin1.ResumeLayout(false);
            this.pnlLogin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin2;
        private System.Windows.Forms.Panel pnlCabain;
        private System.Windows.Forms.ComboBox cboCabain;
        private System.Windows.Forms.Label lblCabain;
        private System.Windows.Forms.Panel pnlLogin1;
        private System.Windows.Forms.Label lblU2;
        private System.Windows.Forms.PictureBox pbLogoU;
        private System.Windows.Forms.Label lblU1;
        private System.Windows.Forms.PictureBox pbLogoApp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

