
namespace bdOOPFinalPj
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.pnlWELCOME = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserNameWelcome = new System.Windows.Forms.Label();
            this.timer1Welcome = new System.Windows.Forms.Timer(this.components);
            this.timer2Welcome = new System.Windows.Forms.Timer(this.components);
            this.pbWelcomeBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWELCOME
            // 
            this.pnlWELCOME.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlWELCOME.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWELCOME.Location = new System.Drawing.Point(0, 0);
            this.pnlWELCOME.Name = "pnlWELCOME";
            this.pnlWELCOME.Size = new System.Drawing.Size(835, 103);
            this.pnlWELCOME.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bdOOPFinalPj.Properties.Resources.HAPA_logo_transparente;
            this.pictureBox1.Location = new System.Drawing.Point(9, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(420, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME";
            // 
            // lblUserNameWelcome
            // 
            this.lblUserNameWelcome.AutoSize = true;
            this.lblUserNameWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserNameWelcome.Location = new System.Drawing.Point(474, 200);
            this.lblUserNameWelcome.Name = "lblUserNameWelcome";
            this.lblUserNameWelcome.Size = new System.Drawing.Size(148, 32);
            this.lblUserNameWelcome.TabIndex = 3;
            this.lblUserNameWelcome.Text = "UserName";
            // 
            // timer1Welcome
            // 
            this.timer1Welcome.Interval = 32;
            this.timer1Welcome.Tick += new System.EventHandler(this.timer1Welcome_Tick);
            // 
            // timer2Welcome
            // 
            this.timer2Welcome.Interval = 34;
            this.timer2Welcome.Tick += new System.EventHandler(this.timer2Welcome_Tick);
            // 
            // pbWelcomeBar
            // 
            this.pbWelcomeBar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.pbWelcomeBar.Location = new System.Drawing.Point(371, 304);
            this.pbWelcomeBar.Maximum = 85;
            this.pbWelcomeBar.Name = "pbWelcomeBar";
            this.pbWelcomeBar.Size = new System.Drawing.Size(382, 23);
            this.pbWelcomeBar.Step = 25;
            this.pbWelcomeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbWelcomeBar.TabIndex = 4;
            this.pbWelcomeBar.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(774, 344);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 380);
            this.Controls.Add(this.pbWelcomeBar);
            this.Controls.Add(this.lblUserNameWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlWELCOME);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWELCOME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserNameWelcome;
        private System.Windows.Forms.Timer timer1Welcome;
        private System.Windows.Forms.Timer timer2Welcome;
        private System.Windows.Forms.ProgressBar pbWelcomeBar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}