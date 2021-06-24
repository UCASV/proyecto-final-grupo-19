using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdOOPFinalPj
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pnlIndicator.Height = panelBase.Height;
            pnlIndicator.Top = panelBase.Top;
        }
        private void btbAppointment_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageAppointment;

            pnlIndicator.Height = panelBase.Height;
            pnlIndicator.Top = panelBase.Top;

            txtName.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtDUI.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhoneNmbr.Text = String.Empty;

            cboID.SelectedIndex = -1;
            cboIllness.SelectedIndex = -1;
        }
        private void btnTracing_Click(object sender, EventArgs e)
        {   
            
            tabControl.SelectedTab = pageTracing;

            pnlIndicator.Height = panel1.Height;
            pnlIndicator.Top = panel1.Top;

            txtTraceName.Text = String.Empty;
            txtTraceAddress.Text = String.Empty;
            txtTraceAge.Text = String.Empty;
            txtTraceDate1.Text = String.Empty;
            txtTraceEmail.Text = String.Empty;
            txtTraceHour1.Text = String.Empty;
            txtTraceIDInstitution.Text = String.Empty;
            txtTracePhoneNmbr.Text = String.Empty;
            txtTraceName.Text = String.Empty;
            txtTraceIllness.Text = String.Empty;
            txtTracePlace1.Text = String.Empty;

            lblTraceAddress.Visible = false;
            lblTraceAge.Visible = false;
            lblTraceDate1.Visible = false;
            lblTraceEmail.Visible = false;
            lblTraceHour1.Visible = false;
            txtTraceIDInstitution.Visible = false; 
            lblTraceIllness.Visible = false;
            lblTraceName.Visible = false;
            lblTracePhoneNmbr.Visible = false;
            lblTracePlace1.Visible = false;
            lblTraceIdInstitution.Visible = false;

            txtTraceAddress.Visible = false;
            txtTraceAge.Visible = false;
            txtTraceDate1.Visible = false;
            txtTraceEmail.Visible = false;
            txtTraceHour1.Visible = false;

           
            txtTracePhoneNmbr.Visible = false;
            txtTraceName.Visible = false;
            txtTraceIllness.Visible = false;
            txtTracePlace1.Visible = false;

            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel11.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel23.Visible = false;
            panel25.Visible = false;
            
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            lblTraceAddress.Visible = true;
            lblTraceAge.Visible = true;
            lblTraceDate1.Visible = true;
            lblTraceEmail.Visible = true;
            lblTraceHour1.Visible = true;
            txtTraceIDInstitution.Visible = true;
            lblTraceIllness.Visible = true;
            lblTraceName.Visible = true;
            lblTracePhoneNmbr.Visible = true;
            lblTracePlace1.Visible = true;
            txtTraceIDInstitution.Visible = false;
            lblTraceIdInstitution.Visible = true;


            txtTraceAddress.Visible = true;
            txtTraceAge.Visible = true;
            txtTraceDate1.Visible = true;
            txtTraceEmail.Visible = true;
            txtTraceHour1.Visible = true;
            txtTraceIDInstitution.Visible = true;
            txtTracePhoneNmbr.Visible = true;
            txtTraceName.Visible = true;
            txtTraceIllness.Visible = true;
            txtTracePlace1.Visible = true;


            panel14.Visible = true;
            panel15.Visible = true;
            panel16.Visible = true;
            panel11.Visible = true;
            panel18.Visible = true;
            panel19.Visible = true;
            panel20.Visible = true;
            panel21.Visible = true;
            panel23.Visible = true;
            panel25.Visible = true;
        }

        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrinting_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageDownload;

            pnlIndicator.Height = panel4.Height;
            pnlIndicator.Top = panel4.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageVaccination;

            pnlIndicator.Height = panel5.Height;
            pnlIndicator.Top = panel5.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageStats;

            pnlIndicator.Height = panel3.Height;
            pnlIndicator.Top = panel3.Top;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabStop = false;
        }

        private bool ValidDUI()
        {
            int n;
            if (txtDUI.Text.Length > 9 && Regex.IsMatch(txtDUI.Text.Substring(0, 7), @"^[0-9]+$") &&
                    (txtDUI.Text[9] == '0' || txtDUI.Text[9] == '1' || txtDUI.Text[9] == '2' || txtDUI.Text[9] == '3' || txtDUI.Text[9] == '4' || txtDUI.Text[9] == '5' || txtDUI.Text[9] == '6' ||
                        txtDUI.Text[9] == '7' || txtDUI.Text[9] == '8' || txtDUI.Text[9] == '9'))
            {
                if (txtDUI.Text[8] == '-')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = ValidDUI();
            if (valid)
            {
                MessageBox.Show("Exito", "HAPA", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "HAPA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
