namespace bdOOPFinalPj
{
    partial class FormDiseases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiseases));
            this.pnlDiseasesTitle = new System.Windows.Forms.Panel();
            this.pbCloseDisease = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveDiseases = new System.Windows.Forms.Button();
            this.lblDisease1 = new System.Windows.Forms.Label();
            this.txtDisease1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDisease2 = new System.Windows.Forms.TextBox();
            this.lblDisease2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDisease3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDiseases = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNone = new System.Windows.Forms.CheckBox();
            this.pnlDiseasesTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDiseasesTitle
            // 
            this.pnlDiseasesTitle.Controls.Add(this.pbCloseDisease);
            this.pnlDiseasesTitle.Controls.Add(this.pictureBox1);
            this.pnlDiseasesTitle.Controls.Add(this.label1);
            this.pnlDiseasesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiseasesTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlDiseasesTitle.Name = "pnlDiseasesTitle";
            this.pnlDiseasesTitle.Size = new System.Drawing.Size(786, 132);
            this.pnlDiseasesTitle.TabIndex = 0;
            // 
            // pbCloseDisease
            // 
            this.pbCloseDisease.Image = global::bdOOPFinalPj.Properties.Resources.close;
            this.pbCloseDisease.Location = new System.Drawing.Point(744, 12);
            this.pbCloseDisease.Name = "pbCloseDisease";
            this.pbCloseDisease.Size = new System.Drawing.Size(30, 31);
            this.pbCloseDisease.TabIndex = 18;
            this.pbCloseDisease.TabStop = false;
            this.pbCloseDisease.Click += new System.EventHandler(this.pbCloseDisease_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bdOOPFinalPj.Properties.Resources.chronicalIllness;
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chronic Diseases";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveDiseases);
            this.panel1.Location = new System.Drawing.Point(697, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveDiseases
            // 
            this.btnSaveDiseases.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveDiseases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveDiseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDiseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDiseases.Image = global::bdOOPFinalPj.Properties.Resources.Save;
            this.btnSaveDiseases.Location = new System.Drawing.Point(0, 0);
            this.btnSaveDiseases.Name = "btnSaveDiseases";
            this.btnSaveDiseases.Size = new System.Drawing.Size(77, 39);
            this.btnSaveDiseases.TabIndex = 2;
            this.btnSaveDiseases.UseVisualStyleBackColor = false;
            this.btnSaveDiseases.Click += new System.EventHandler(this.btnSaveDiseases_Click);
            // 
            // lblDisease1
            // 
            this.lblDisease1.AutoSize = true;
            this.lblDisease1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisease1.ForeColor = System.Drawing.Color.Silver;
            this.lblDisease1.Location = new System.Drawing.Point(32, 180);
            this.lblDisease1.Name = "lblDisease1";
            this.lblDisease1.Size = new System.Drawing.Size(56, 13);
            this.lblDisease1.TabIndex = 2;
            this.lblDisease1.Text = "Disease:";
            // 
            // txtDisease1
            // 
            this.txtDisease1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisease1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisease1.Location = new System.Drawing.Point(32, 201);
            this.txtDisease1.Name = "txtDisease1";
            this.txtDisease1.Size = new System.Drawing.Size(174, 17);
            this.txtDisease1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(32, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(290, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 1);
            this.panel3.TabIndex = 7;
            // 
            // txtDisease2
            // 
            this.txtDisease2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisease2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisease2.Location = new System.Drawing.Point(290, 201);
            this.txtDisease2.Name = "txtDisease2";
            this.txtDisease2.Size = new System.Drawing.Size(174, 17);
            this.txtDisease2.TabIndex = 6;
            // 
            // lblDisease2
            // 
            this.lblDisease2.AutoSize = true;
            this.lblDisease2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisease2.ForeColor = System.Drawing.Color.Silver;
            this.lblDisease2.Location = new System.Drawing.Point(290, 180);
            this.lblDisease2.Name = "lblDisease2";
            this.lblDisease2.Size = new System.Drawing.Size(56, 13);
            this.lblDisease2.TabIndex = 5;
            this.lblDisease2.Text = "Disease:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(563, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 1);
            this.panel4.TabIndex = 10;
            // 
            // txtDisease3
            // 
            this.txtDisease3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisease3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisease3.Location = new System.Drawing.Point(563, 201);
            this.txtDisease3.Name = "txtDisease3";
            this.txtDisease3.Size = new System.Drawing.Size(174, 17);
            this.txtDisease3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(563, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Disease:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(290, 330);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 1);
            this.panel5.TabIndex = 10;
            // 
            // txtDiseases
            // 
            this.txtDiseases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDiseases.Location = new System.Drawing.Point(290, 310);
            this.txtDiseases.Name = "txtDiseases";
            this.txtDiseases.Size = new System.Drawing.Size(174, 17);
            this.txtDiseases.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(290, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Diseases:";
            // 
            // cbNone
            // 
            this.cbNone.AutoSize = true;
            this.cbNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbNone.ForeColor = System.Drawing.Color.Silver;
            this.cbNone.Location = new System.Drawing.Point(563, 312);
            this.cbNone.Name = "cbNone";
            this.cbNone.Size = new System.Drawing.Size(53, 17);
            this.cbNone.TabIndex = 11;
            this.cbNone.Text = "None";
            this.cbNone.UseVisualStyleBackColor = true;
            // 
            // FormDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 367);
            this.Controls.Add(this.cbNone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtDiseases);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisease3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisease2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDisease2);
            this.Controls.Add(this.txtDisease1);
            this.Controls.Add(this.lblDisease1);
            this.Controls.Add(this.pnlDiseasesTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiseases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlDiseasesTitle.ResumeLayout(false);
            this.pnlDiseasesTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiseasesTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveDiseases;
        private System.Windows.Forms.Label lblDisease1;
        private System.Windows.Forms.TextBox txtDisease1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDisease2;
        private System.Windows.Forms.Label lblDisease2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDisease3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDiseases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCloseDisease;
        private System.Windows.Forms.CheckBox cbNone;
    }
}