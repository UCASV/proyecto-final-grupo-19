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
    public partial class FormMain : Form
    {
        private int idcabin;
        //Aplicando patron de diseño: Repositorio.
        private Repository.IdentifierRepo ListIde;
        private Repository.CitizenRepo auxCitizen;
        private Repository.vaccinationRepo auxVacc;
        private Repository.DiseaseRepo auxDiseas;
        public FormMain(int c)
        {
            InitializeComponent();
            label13.Visible = false;
            txtPatientDownload.Visible = false;
            button4.Visible = false;
            pnlIndicator.Height = panelBase.Height;
            pnlIndicator.Top = panelBase.Top;
            this.idcabin = c;
            auxCitizen = new Repository.CitizenRepo();
            ListIde = new Repository.IdentifierRepo();
            auxVacc = new Repository.vaccinationRepo();
            auxDiseas = new Repository.DiseaseRepo();
            var auxIde = ListIde.consult();
            cboID.DataSource = auxIde;
            cboID.ValueMember = "Id";
            cboID.DisplayMember = "Identifier1";
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
            txtTraceIllness.Text = string.Empty;
            //-------------------------------------------------------------------------------------------
            // llAMAMOS A LA BDD Y DENTRO DE ESTE CODIGO SACAMOS UNA LISTA QUE GUARDARA A LOS CIUDADANOS
            List<Citizen> listCitizen = auxCitizen.consult();
            // AHORA BUSCAMOS AL CUIDADANO CON EL MISMO DUI QUE ESCRIBIMOS EN EL TxtTraceDUI
            var result = listCitizen.Where(u => u.Dui.Equals(txtTraceDUI.Text)).ToList();
            //-------------------------------------------------------------------------------------------
            string di;
            if (ValidDUI(txtTraceDUI.Text) && result.Count != 0 )
            { // Usamos variables locales para trabajar los datos que estan relacionando con el dato de CITIZEN.
                Citizen oneCitizen = result[0];
                var identi = ListIde.consult().Where(i => i.Id.Equals(result[0].IdIdentifier)).ToList();
                var cronicals = auxDiseas.consult().Where(d => d.IdCitizen.Equals(result[0].Dui)).ToList();
                var process = auxVacc.consult().Where(v => v.Id.Equals(result[0].IdVaccinationP)).ToList();
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
                foreach (var d in cronicals)
                {
                    txtTraceIllness.Text += d.Diseases + ", ";
                }
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
            int? age = Int32.Parse(txtAge.Text);
            if (valid && age > 18) // validamos primero el DUI
            {
                var resultCitizen = auxCitizen.consult().Where(c => c.Dui.Equals(txtDUI.Text)).ToList();
                if (resultCitizen.Count == 0)
                {// validamos si ya esta registrado la persona con su DUI.
                    if (Int32.Parse(txtAge.Text) > 60 && cboID.SelectedItem.ToString() != "none")
                    { // validamos si pertenece al grupo de prioridad y asignamos una fecha temprana
                        DateTime newDate = DateTime.Now;
                        Random days = new Random();
                        int day = days.Next(5, 10);
                        newDate = newDate.AddDays(day);
                        VaccinationProcess vaccination = new VaccinationProcess()
                        {
                            DateHourVaccination = newDate,
                            Place = "Hospital El Salvador"
                        };
                        auxVacc.insert(vaccination);
                        //ingresamos datos de cuidadano
                        var listaConst = auxVacc.consult().OrderByDescending(c => c.Id).ToList();

                        Citizen twoCitizen = new Citizen();
                        twoCitizen.Dui = txtDUI.Text;
                        twoCitizen.NameCitizen = txtName.Text;
                        twoCitizen.Addres = txtAddress.Text;
                        twoCitizen.Age = Int32.Parse(txtAge.Text);
                        twoCitizen.Phone = Int32.Parse(txtPhoneNmbr.Text);
                        twoCitizen.Mail = txtEmail.Text;
                        twoCitizen.IdIdentifier = Int32.Parse(cboID.SelectedValue.ToString());
                        twoCitizen.IdCabin = idcabin;
                        twoCitizen.IdVaccinationP = listaConst[0].Id;
                        auxCitizen.insert(twoCitizen);
                        MessageBox.Show("Ingresado como PRIORIDAD", "HAPA", MessageBoxButtons.OK);
                    }
                    else // Si no pertenence al grupo de prioridad se dara una fecha general
                    {
                        DateTime newDate = DateTime.Now;
                        Random days = new Random();
                        int day = days.Next(10, 15);
                        newDate = newDate.AddDays(day);
                        VaccinationProcess vaccination = new VaccinationProcess()
                        {
                            DateHourVaccination = newDate,
                            Place = "Hospital El Salvador"
                        };
                        auxVacc.insert(vaccination);
                        //ingresamos datos de cuidadano
                        var listaProcces = auxVacc.consult().OrderByDescending(c => c.Id).ToList();

                        Citizen twoCitizen = new Citizen();
                        twoCitizen.Dui = txtDUI.Text;
                        twoCitizen.NameCitizen = txtName.Text;
                        twoCitizen.Addres = txtAddress.Text;
                        twoCitizen.Age = Int32.Parse(txtAge.Text);
                        twoCitizen.Phone = Int32.Parse(txtPhoneNmbr.Text);
                        twoCitizen.Mail = txtEmail.Text;
                        twoCitizen.IdIdentifier = Int32.Parse(cboID.SelectedValue.ToString());
                        twoCitizen.IdCabin = idcabin;
                        twoCitizen.IdVaccinationP = listaProcces[0].Id;
                        auxCitizen.insert(twoCitizen);
                    }
                    MessageBox.Show("Exito al guardar", "HAPA", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("La persona ya esta registrada", "HAPA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Dato erroneo", "HAPA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var validation = auxCitizen.consult().Where(c => c.Dui.Equals(txtVaccineDUI.Text)).ToList();
            if(validation.Count != 0)
            {
                DateTime waiting = DateTime.Now;
                var procces =  auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP)).ToList();
                procces[0].DateHourStart = waiting;
                auxVacc.update(procces[0]);
                gbApply.Visible = true;
                gbWait.Location = new Point(12, 264);
            }
            else
            {
                MessageBox.Show("DUI no encontrado", "HAPA", MessageBoxButtons.OK);
            }
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
            bool valid = ValidDUI(txtDUI.Text);
            if (valid)
            {
                FormDiseases formDiseases = new FormDiseases(txtDUI.Text);
                formDiseases.ShowDialog();
                formDiseases = null;
                Show();
            }
            else
            {
                MessageBox.Show("DUI invalido", "HAPA", MessageBoxButtons.OK);
            }
        }

        private void pageAppointment_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDownloadVerify_Click(object sender, EventArgs e)
        {
            List<Citizen> listCitizen = auxCitizen.consult();
            var result = listCitizen.Where(u => u.Dui.Equals(txtPatientDownload.Text)).ToList(); 

            if (exists())
            {
                label13.Visible = true;
                txtPatientDownload.Visible = true ;
                txtPatientDownload.Text = result[0].NameCitizen;
                button4.Visible = true;
            }
            else
                MessageBox.Show("The user is not found, please register the user who makes an appointment", "HAPA COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool exists ()
        {
            List<Citizen> listCitizen = auxCitizen.consult();
            var result = listCitizen.Where(u => u.Dui.Equals(txtPatientDownload.Text)).ToList();

            if (result.Count > 0)

                return true;
            else
            
                return false;
            
        }
    }
}
