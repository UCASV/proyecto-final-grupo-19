using bdOOPFinalPj.SqlServerContext;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
            pnlIndicator.Height = panelBase.Height;
            pnlIndicator.Top = panelBase.Top;
        }

        private bool ValidDUI(string dui)
        {
            if (dui.Length > 9 && Regex.IsMatch(dui.Substring(0, 7), @"^[0-9]+$") &&
                    (dui[9] == '0' || dui[9] == '1' || dui[9] == '2' || dui[9] == '3' || dui[9] == '4' || dui[9] == '5' || dui[9] == '6' ||
                        dui[9] == '7' || dui[9] == '8' || dui[9] == '9'))
            {
                if (dui[8] == '-')
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

        private void Design_TabControl()
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabStop = false;
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
            // cboIllness.SelectedIndex = -1;
        }
        private void btnTracing_Click(object sender, EventArgs e)
        {   
            
            tabControl.SelectedTab = pageTracing;

            pnlIndicator.Height = panel4.Height;
            pnlIndicator.Top = panel4.Top;

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
            //-------------------------------------------------------------------------------------------
            // llAMAMOS A LA BDD Y DENTRO DE ESTE CODIGO SACAMOS UNA LISTA QUE GUARDARA A LOS CIUDADANOS
            var db = new PROYECTOFContext();
            List<Citizen> listCitizen = db.Citizens
                .Include(x => x.IdIdentifierNavigation)
                .Include(c => c.IdVaccinationPNavigation)
                .ToList();
            // AHORA BUSCAMOS AL CUIDADANO CON EL MISMO DUI QUE ESCRIBIMOS EN EL TxtTraceDUI
            var result = listCitizen.Where(u => u.Dui.Equals(txtTraceDUI.Text)).ToList();
            //-------------------------------------------------------------------------------------------

            if(ValidDUI(txtTraceDUI.Text) && result.Count != 0 )
            { // Usamos variables locales para trabajar los datos que estan relacionando con el dato de CITIZEN.
                Citizen oneCitizen = result[0];
                var identi = db.Identifiers.Where(i => i.Id.Equals(result[0].IdIdentifier)).ToList();
                var cronicals = db.Diseases.Where(d => d.IdCitizen.Equals(result[0].Dui)).ToList();
                var process = db.VaccinationProcesses.Where(v => v.Id.Equals(result[0].IdVaccinationP)).ToList();
                DateTime? date = process[0].DateHourVaccination;
                lblTraceAddress.Visible = true;
                lblTraceAge.Visible = true;
                lblTraceDate1.Visible = true;
                lblTraceEmail.Visible = true;
                lblTraceHour1.Visible = true;
                lblTraceIdInstitution.Visible = true;
                lblTraceIllness.Visible = true;
                lblTraceName.Visible = true;
                lblTracePhoneNmbr.Visible = true;
                lblTracePlace1.Visible = true;

                //Mostramos los datos del Cuidadano con las variables locales, acorde a su dui en cada TXT
                txtTraceAddress.Visible = true;
                txtTraceAddress.Text = oneCitizen.Addres;
                txtTraceAge.Visible = true;
                txtTraceAge.Text = oneCitizen.Age.ToString();
                txtTraceDate1.Visible = true;
                txtTraceDate1.Text = date.Value.Date.ToString();
                txtTraceEmail.Visible = true;
                txtTraceEmail.Text = oneCitizen.Mail;
                txtTraceHour1.Visible = true;
                txtTraceHour1.Text = date.Value.Hour.ToString();
                txtTraceIDInstitution.Visible = true;
                txtTraceIDInstitution.Text = identi[0].Identifier1;
                txtTracePhoneNmbr.Visible = true;
                txtTracePhoneNmbr.Text = oneCitizen.Phone.ToString();
                txtTraceName.Visible = true;
                txtTraceName.Text = oneCitizen.NameCitizen;
                txtTraceIllness.Visible = true;
                //txtTraceIllness.Text = 
                txtTracePlace1.Visible = true;
                txtTracePlace1.Text = process[0].Place;

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
            else
            {
                MessageBox.Show("¡No se encuentra Cuidadano!", "HAPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
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

            pnlIndicator.Height = panel1.Height;
            pnlIndicator.Top = panel1.Top;
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
            Design_TabControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = ValidDUI(txtDUI.Text);
            if (valid)
            {
                MessageBox.Show("Exito", "HAPA", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "HAPA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pageVaccination_Click(object sender, EventArgs e)
        {

        }

        private void pbClose5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMin1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMin2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMin3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMin4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMin5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWaitingLineRegister_Click(object sender, EventArgs e)
        {
            //Ejecutar luego de validar el DUI
            gbApply.Visible = true;
            gbWait.Location = new Point(12, 264);
        }

        private void btnSaveSynthoms_Click(object sender, EventArgs e)
        {
            //Ejecutar luego de validar la selección del CheckedListBox
            gbSecond.Visible = true;
        }

        private void btnVaccineApplication_Click(object sender, EventArgs e)
        {
            //Ejecutar luego de validar la selección del CheckedListBox
            gbObservation.Visible = true;
           
        }

        private void btnRegisterSecondDose_Click(object sender, EventArgs e)
        {
            //Añadir Message Box con la fecha y hora de la segunda dósis, luego de eso, el formulario se refrescará
            
            this.Controls.Clear();
            this.InitializeComponent();
            Design_TabControl();

            tabControl.SelectedTab = pageVaccination;

            pnlIndicator.Height = panel5.Height;
            pnlIndicator.Top = panel5.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDiseases formDiseases = new FormDiseases();
            formDiseases.ShowDialog();
            formDiseases = null;
            Show();
        }
    }
}
