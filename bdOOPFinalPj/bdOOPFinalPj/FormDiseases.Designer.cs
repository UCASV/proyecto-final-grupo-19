﻿namespace bdOOPFinalPj
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
            this.cbNone = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDisease2 = new System.Windows.Forms.TextBox();
            this.lblDisease2 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(684, 183);
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
            // cbNone
            // 
            this.cbNone.AutoSize = true;
            this.cbNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbNone.ForeColor = System.Drawing.Color.Silver;
            this.cbNone.Location = new System.Drawing.Point(556, 201);
            this.cbNone.Name = "cbNone";
            this.cbNone.Size = new System.Drawing.Size(53, 17);
            this.cbNone.TabIndex = 11;
            this.cbNone.Text = "None";
            this.cbNone.UseVisualStyleBackColor = true;
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
            // FormDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 313);
            this.Controls.Add(this.cbNone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDisease2);
            this.Controls.Add(this.lblDisease2);
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
        private System.Windows.Forms.PictureBox pbCloseDisease;
        private System.Windows.Forms.CheckBox cbNone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDisease2;
        private System.Windows.Forms.Label lblDisease2;
    }
}