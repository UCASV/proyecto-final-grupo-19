using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdPooFinalPj
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pnlIndicator.Height = panel2.Height - 2;
            pnlIndicator.Top = panel2.Top + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageAppointment;

            pnlIndicator.Height = panel2.Height - 2;
            pnlIndicator.Top = panel2.Top + 1;

            txtAddress.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtDUI.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtName.Text = String.Empty;
            txtPhoneNmbr.Text = String.Empty;

            cboID.SelectedIndex = -1;
            cboIllness.SelectedIndex = -1;
        }

        private void tabControl1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pageAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnTracing_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageTracing;

            pnlIndicator.Height = panel3.Height - 2;
            pnlIndicator.Top = panel3.Top + 1;

            txtTraceDUI.Text = String.Empty;
            txtTraceAddress.Text = String.Empty;
            txtTraceAge.Text = String.Empty;
            txtTraceDate1.Text = String.Empty;
            txtTraceEmail.Text = String.Empty;
            txtTraceHour1.Text = String.Empty;
            txtTraceIDInstitution.Text = String.Empty;
            txtTraceIllness.Text = String.Empty;
            txtTraceName.Text = String.Empty;
            txtTracePhoneNmbr.Text = String.Empty;
            txtTracePlace1.Text = String.Empty;

            lblTraceAddress.Visible = false;
            lblTraceAge.Visible = false;
            lblTraceDate1.Visible = false;
            lblTraceEmail.Visible = false;
            lblTraceHour1.Visible = false;
            lblTraceIDInstitution.Visible = false;
            lblTraceIllness.Visible = false;
            lblTraceName.Visible = false;
            lblTracePhoneNmbr.Visible = false;
            lblTracePlace1.Visible = false;

            txtTraceAddress.Visible = false;
            txtTraceAge.Visible = false;
            txtTraceDate1.Visible = false;
            txtTraceEmail.Visible = false;
            txtTraceHour1.Visible = false;
            txtTraceIDInstitution.Visible = false;
            txtTraceIllness.Visible = false;
            txtTraceName.Visible = false;
            txtTracePhoneNmbr.Visible = false;
            txtTracePlace1.Visible = false;

            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
 
        }

        private void gbTraceData_Enter(object sender, EventArgs e)
        {

        }

        private void pageTracing_Click(object sender, EventArgs e)
        {

        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            lblTraceAddress.Visible = true;
            lblTraceAge.Visible = true;
            lblTraceDate1.Visible = true;
            lblTraceEmail.Visible = true;
            lblTraceHour1.Visible = true;
            lblTraceIDInstitution.Visible = true;
            lblTraceIllness.Visible = true;
            lblTraceName.Visible = true;
            lblTracePhoneNmbr.Visible = true;
            lblTracePlace1.Visible = true;

            txtTraceAddress.Visible = true;
            txtTraceAge.Visible = true;
            txtTraceDate1.Visible = true;
            txtTraceEmail.Visible = true;
            txtTraceHour1.Visible = true;
            txtTraceIDInstitution.Visible = true;
            txtTraceIllness.Visible = true;
            txtTraceName.Visible = true;
            txtTracePhoneNmbr.Visible = true;
            txtTracePlace1.Visible = true;

            panel12.Visible = true;
            panel13.Visible = true;
            panel14.Visible = true;
            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            panel18.Visible = true;
            panel19.Visible = true;
            panel20.Visible = true;
            panel21.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // CODE PARA ALMACENAR EN LA BASE DE DATOS

            // ↓ CODE PARA LIMPIAR TXTBOXS LUEGO DE HABER GUARDADO REGISTRO EN DB
            txtAddress.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtDUI.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtName.Text = String.Empty;
            txtPhoneNmbr.Text = String.Empty;

            cboID.SelectedIndex = -1;
            cboIllness.SelectedIndex = -1;
        }
    }
}
