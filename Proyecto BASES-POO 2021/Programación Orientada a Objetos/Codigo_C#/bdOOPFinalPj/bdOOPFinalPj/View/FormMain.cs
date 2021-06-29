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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        private Repository.EffectRepo auxEffect;
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
            auxEffect = new Repository.EffectRepo(); 
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

            txtTraceDUI.Text = String.Empty;
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
            if (ValidDUI(txtTraceDUI.Text) && result.Count != 0) 
            {
                if ((result[0].IdVaccinationP1 != null) && (result[0].IdVaccinationP2 == null))
                { // Usamos variables locales para trabajar los datos que estan relacionando con el dato de CITIZEN.
                    Citizen oneCitizen = result[0];
                    var identi = ListIde.consult().Where(i => i.Id.Equals(result[0].IdIdentifier)).ToList();
                    var cronicals = auxDiseas.consult().Where(d => d.IdCitizen.Equals(result[0].Dui)).ToList();
                    var process = auxVacc.consult().Where(v => v.Id.Equals(result[0].IdVaccinationP1)).ToList();
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
                else if ((result[0].IdVaccinationP1 != null) && (result[0].IdVaccinationP2 != null))
                {
                    if (ValidDUI(txtTraceDUI.Text) && result.Count != 0)
                    { // Usamos variables locales para trabajar los datos que estan relacionando con el dato de CITIZEN.
                        Citizen oneCitizen = result[0];
                        var identi = ListIde.consult().Where(i => i.Id.Equals(result[0].IdIdentifier)).ToList();
                        var cronicals = auxDiseas.consult().Where(d => d.IdCitizen.Equals(result[0].Dui)).ToList();
                        var process = auxVacc.consult().Where(v => v.Id.Equals(result[0].IdVaccinationP2)).ToList();
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

                }
            

            }
            else
            
                MessageBox.Show("¡The citizen was not found!", "HAPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            
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
            txtVaccineDUI.Text = null;
            gbApply.Visible = false;
            gbObservation.Visible = false;
            gbSecond.Visible = false;
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
            int? age = null;
            if (txtAge.Text != String.Empty)
                age = Int32.Parse(txtAge.Text);
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
                        twoCitizen.IdVaccinationP1 = listaConst[0].Id;
                        auxCitizen.insert(twoCitizen);
                        MessageBox.Show("Entered as PRIORITY", "HAPA", MessageBoxButtons.OK);
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
                        twoCitizen.IdVaccinationP1 = listaProcces[0].Id;
                        auxCitizen.insert(twoCitizen);
                    }
                    MessageBox.Show("Save success", "HAPA", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("The person is already registered", "HAPA COVID-19", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Wrong data", "HAPA COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var validation2 = auxVacc.consult().Where(c => c.Id.Equals(validation[0].IdVaccinationP1)).ToList();
            var validation3 = auxVacc.consult().Where(c => c.Id.Equals(validation[0].IdVaccinationP2)).ToList();
            if (validation.Count != 0)
            {
                if (validation2[0].NumberMinutes == null || validation3[0].NumberMinutes == null)
                {
                    if (validation[0].IdVaccinationP2 == null)
                    {
                        DateTime waiting = DateTime.Now;
                        var procces = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP1)).ToList();
                        procces[0].DateHourStart = waiting;
                        auxVacc.update(procces[0]);
                        gbApply.Visible = true;
                        gbWait.Location = new Point(12, 264);
                    }
                    else if (validation[0].IdVaccinationP2 != null)
                    {
                        DateTime waiting = DateTime.Now;
                        var procces = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP2)).ToList();
                        procces[0].DateHourStart = waiting;
                        auxVacc.update(procces[0]);
                        gbApply.Visible = true;
                        gbWait.Location = new Point(12, 264);
                    }
                    else
                    {
                        MessageBox.Show("Dui not found", "HAPA", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("The patient has already finished his vaccination process", "HAPA", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("The DUI is not registered", "HAPA COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveSynthoms_Click(object sender, EventArgs e)
        {
            
            //Ejecutar luego de validar la selección del CheckedListBox
            var validation = auxCitizen.consult().Where(c => c.Dui.Equals(txtVaccineDUI.Text)).ToList();
            if (validation[0].IdVaccinationP2 == null)
            {
                for (int i = 0; i < clbSynthoms.CheckedItems.Count; i++)
                { // recorremos los elementos seleccionados del grupo y los guardamos en variables
                    var selected = clbSynthoms.CheckedItems[i].ToString();
                    var process = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP1)).ToList();
                    Effect efe = new Effect(); // se instancia variable tipo efecto para guardarla
                    efe.SideEffects = selected;
                    efe.IdProcess = process[0].Id;
                    auxEffect.insert(efe); // lo insertamos con ayuda del patron repositorio a la BDD
                }           
                gbSecond.Visible = true;
            }
            else
            {
                for (int i = 0; i < clbSynthoms.CheckedItems.Count; i++)
                { // recorremos los elementos seleccionados del grupo y los guardamos en variables
                    var selected = clbSynthoms.CheckedItems[i].ToString();
                    var process = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP2)).ToList();
                    Effect efe = new Effect(); // se instancia variable tipo efecto para guardarla
                    efe.SideEffects = selected;
                    efe.IdProcess = process[0].Id;
                    auxEffect.insert(efe); // lo insertamos con ayuda del patron repositorio a la BDD
                }
                gbSecond.Visible = true;
            }
        }

        private void btnVaccineApplication_Click(object sender, EventArgs e)
        {
            var validation = auxCitizen.consult().Where(c => c.Dui.Equals(txtVaccineDUI.Text)).ToList();
            if (validation[0].IdVaccinationP2 == null)
            {
                if (validation.Count != 0)
                {
                    DateTime hInit, hVaccination = DateTime.Now;
                    int minute = 0;
                    var vaccination = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP1)).ToList();

                    hInit = (DateTime)vaccination[0].DateHourStart;
                    minute = hVaccination.Minute - hInit.Minute;

                    vaccination[0].DateHourVaccinated = hVaccination;
                    vaccination[0].NumberMinutes = minute;

                    auxVacc.update(vaccination[0]);
                    gbObservation.Visible = true;


                }
                else
                {
                    MessageBox.Show("Dui not found", "HAPA", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (validation.Count != 0)
                {
                    DateTime hInit, hVaccination = DateTime.Now;
                    int minute = 0;
                    var vaccination = auxVacc.consult().Where(v => v.Id.Equals(validation[0].IdVaccinationP2)).ToList();

                    hInit = (DateTime)vaccination[0].DateHourStart;
                    minute = hVaccination.Minute - hInit.Minute;

                    vaccination[0].DateHourVaccinated = hVaccination;
                    vaccination[0].NumberMinutes = minute;

                    auxVacc.update(vaccination[0]);
                    gbObservation.Visible = true;


                }
                else
                {
                    MessageBox.Show("Dui not found", "HAPA", MessageBoxButtons.OK);
                }
            }
            
        }


        private void btnRegisterSecondDose_Click(object sender, EventArgs e)
        {
            clbSynthoms.ClearSelected();
            List<Citizen> citizen = auxCitizen.consult().Where(c => c.Dui.Equals(txtVaccineDUI.Text)).ToList();

            if (citizen[0].IdVaccinationP2 == null)
            {
                //Añadir Message Box con la fecha y hora de la segunda dósis, luego de eso, el formulario se refrescará
                var db = new PROYECTOFContext();
                var listInstitution = db.Identifiers.ToList();


                //cambios la ventana q se muestra
                tabControl.SelectedTab = pageTracing;


                pnlIndicator.Height = panel5.Height;
                pnlIndicator.Top = panel5.Top;
                //obtengo toda la informacion del ciudadano para llenar los campos de la ventana


                txtTraceDUI.Text = txtVaccineDUI.Text;
                txtTraceName.Text = citizen[0].NameCitizen;
                txtTracePhoneNmbr.Text = citizen[0].Phone.ToString();
                txtTraceAge.Text = citizen[0].Age.ToString();
                txtTraceAddress.Text = citizen[0].Addres;
                //busco el identificador del ciudadano
                List<Identifier> result = listInstitution
                    .Where(i => i.Id == citizen[0].IdIdentifier)
                    .ToList();
                cboID.Text = result[0].Identifier1.ToString();
                //obtengo todas las enfermedades conicas  del ciudadano
                var resulDiseases = db.Diseases.Where(d => d.IdCitizen.Equals(citizen[0].Dui)).ToList();
                foreach (var d in resulDiseases)
                {
                    txtTraceIllness.Text += d.Diseases + ", ";
                }

                txtTraceEmail.Text = citizen[0].Mail;
                //creo la nueva fecha de vacunacion
                DateTime newdate = DateTime.Now.AddDays(42);
                txtTraceDate1.Text = newdate.ToString();
                txtTraceHour1.Text = newdate.Hour.ToString() + ":00";
                txtTracePlace1.Text = "Hospital El Salvador";
                saveNewAppoiment(newdate, (int)citizen[0].Age);
                //obtengo el ultimo proceso de vacunacion
                var listaProcces = auxVacc.consult().OrderByDescending(c => c.Id).ToList();
                citizen[0].IdVaccinationP2 = listaProcces[0].Id;
                //actualizo el proceso de cita del paciente
                auxCitizen.update(citizen[0]);


                //this.Controls.Clear();
                //this.InitializeComponent();
                Design_TabControl();
            }
            else
            {
               MessageBox.Show("The patient has finished the vaccination process", "HAPA", MessageBoxButtons.OK);
                //this.Controls.Clear();
                //this.InitializeComponent();
                Design_TabControl();
            }

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

            if (sfdSavedoc.ShowDialog() == DialogResult.OK)
            {

                string direction = sfdSavedoc.FileName;
                DateTime schedule = getDate();
                string location = getLocation();
                createpdf(schedule, location, direction);
                MessageBox.Show("Successfully created PDF file", "HAPA COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDownloadVerify_Click(object sender, EventArgs e)
        {
            List<Citizen> listCitizen = auxCitizen.consult();
            var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList(); 

            if (exists() == true)
            {
                label13.Visible = true;
                txtPatientDownload.Visible = true ;
                txtPatientDownload.Text = result[0].NameCitizen.ToString();
                button4.Visible = true;
            }
            else
                MessageBox.Show("The user is not found, please register the user who makes an appointment", "HAPA COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool exists ()
        {
            List<Citizen> listCitizen = auxCitizen.consult();
            var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList();

            if (result.Count > 0)

                return true;
            else
            
                return false;
            
        }

        public void createpdf(DateTime schedule, string location, string directionDoc)
        {
            //con esto obtengo el user name del usuario de la pc para poder crear la cadena de direccion de la ubicacion
            string nameuser = Environment.UserName;
            //sacando un dato especifico del usuario se puede crear el nombre del pdf asi:
            string nombredoc = txtPatientDownload.Text;

            //si decimos que el instalador lo pongan en el escritorio, con esto el pdf se crea en el escritorio, asi :
            string direction = directionDoc + ".pdf";


            //direccion donde se crea el pdf de manera dinamica: 
            FileStream fs = new FileStream(direction, FileMode.Create);
            //FileStream fs = new FileStream(@"C:\Users\Oscar Carpio\Desktop\nuevo2pdf.pdf", FileMode.Create);


            //configuracion de la fuente del tamano de pagina y margenes del pdf: 
            Document doc = new Document(PageSize.A7.Rotate(), 5, 5, 7, 7);
            // instancia q tiene como parametro el boosquejo del doc y la ubicacion donde generara:
            PdfWriter pdw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //definir titulo y autor 
            doc.AddAuthor("HAPA COVID-19");
            doc.AddTitle("Appointment");
            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //configuro los tipos de fuente que tenfra el pdf
            iTextSharp.text.Font timesRoman1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font timesRoman2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            iTextSharp.text.Font normal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 5, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // obtengo la imagen de los recursos del proyecto
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(bdOOPFinalPj.Properties.Resources.HAPA_logo_transparente, System.Drawing.Imaging.ImageFormat.Png);
            logo.ScalePercent(10);


            //creo la tabla que agregare al documento pdf
            var table = new PdfPTable(new float[] { 15f, 30f, 15f, 40f }) { WidthPercentage = 100 };

            //creo las celdas
            var c1 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("------------------------", timesRoman1));
            var c3 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c4 = new PdfPCell(logo) { Rowspan = 3 };

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);



            c1.Phrase = new Phrase(new Phrase("", timesRoman1));
            c2.Phrase = new Phrase(new Phrase("HAPA COVID-19", timesRoman1));
            c3.Phrase = new Phrase(new Phrase("", timesRoman1));

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);

            c1.Phrase = new Phrase(new Phrase("", timesRoman1));
            c2.Phrase = new Phrase(new Phrase("Healt Aid Program Against Covid-19", timesRoman2));
            c3.Phrase = new Phrase(new Phrase("", timesRoman1));

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);

            model(table);

            indented(table);
            indented(table);
            date(table, schedule);
            indented(table);
            hour(table, schedule);
            indented(table);
            place(table, location);


            doc.Add(table);
            doc.Close();
            pdw.Close();
        }

        private void model(PdfPTable table)
        {
            //Configuracion de la fuente
            iTextSharp.text.Font timesRoman1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            var c1 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("------------------------", timesRoman1));
            var c3 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c4 = new PdfPCell(new Phrase("-----------------------", timesRoman1)); // se coloco para darle formato
            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);
        }

        private void indented(PdfPTable table)
        {
            //configuracion de la fuente del texto
            iTextSharp.text.Font timesRoman4 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

            var c1 = new PdfPCell(new Phrase(".", timesRoman4)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase(".", timesRoman4));
            var c3 = new PdfPCell(new Phrase(".", timesRoman4)); // se coloco para darle formato
            var c4 = new PdfPCell(new Phrase(".", timesRoman4)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);
        }

        private void date(PdfPTable table, DateTime schedule)
        {
            string date = schedule.Date.ToString();
            iTextSharp.text.Font timesRoman3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            var c1 = new PdfPCell(new Phrase("Date:", timesRoman3)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("", timesRoman3));
            var c3 = new PdfPCell(new Phrase(date, timesRoman3)); // se coloco para darle formato
            var c4 = new PdfPCell(new Phrase("", timesRoman3)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);
        }

        private void hour(PdfPTable table, DateTime schedule)
        {
            string hour = schedule.Hour.ToString() + ":" + schedule.Minute.ToString() + ":" + schedule.Second.ToString();
            iTextSharp.text.Font timesRoman3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            var c1 = new PdfPCell(new Phrase("Hour:", timesRoman3)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("", timesRoman3));
            var c3 = new PdfPCell(new Phrase(hour, timesRoman3)); // se coloco para darle formato
            var c4 = new PdfPCell(new Phrase("", timesRoman3)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);
        }

        private void place (PdfPTable table, string location)
        {
            iTextSharp.text.Font timesRoman3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            var c1 = new PdfPCell(new Phrase("Place:", timesRoman3)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("", timesRoman3));
            var c3 = new PdfPCell(new Phrase(location, timesRoman3)); // se coloco para darle formato
            var c4 = new PdfPCell(new Phrase("", timesRoman3)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);
        }

        private DateTime getDate()
        {
            DateTime schedule;
            List<Citizen> listCitizen = auxCitizen.consult();
            if (listCitizen[0].IdVaccinationP2 == null)
            {
                var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList();
                //Citizen citizen = result[1];

                List<VaccinationProcess> appointmentdDate = auxVacc.consult();
                var resultserch = appointmentdDate.Where(u => u.Id.Equals(result[0].IdVaccinationP1)).ToList();

                schedule = (DateTime)resultserch[0].DateHourVaccination;
            }
            else
            {
                var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList();
                //Citizen citizen = result[1];

                List<VaccinationProcess> appointmentdDate = auxVacc.consult();
                var resultserch = appointmentdDate.Where(u => u.Id.Equals(result[0].IdVaccinationP2)).ToList();

                schedule = (DateTime)resultserch[0].DateHourVaccination;
            }
            

            return schedule;
        }

        private string getLocation()
        {
            string location;
            List<Citizen> listCitizen = auxCitizen.consult();

            if (listCitizen[0].IdVaccinationP2 == null)
            {
                var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList();

                List<VaccinationProcess> appointmentdDate = auxVacc.consult();
                List<VaccinationProcess> resultserch = appointmentdDate.Where(u => u.Id.Equals(result[0].IdVaccinationP1)).ToList();

                location = resultserch[0].Place;
            }
            else
            {
                var result = listCitizen.Where(u => u.Dui.Equals(txtDownloadDUICheck.Text)).ToList();

                List<VaccinationProcess> appointmentdDate = auxVacc.consult();
                List<VaccinationProcess> resultserch = appointmentdDate.Where(u => u.Id.Equals(result[0].IdVaccinationP2)).ToList();

                location = resultserch[0].Place;

            }

            return location;
        }

        private void saveNewAppoiment (DateTime date, int age)
        {
            
            VaccinationProcess vaccination = new VaccinationProcess()
            {
                            DateHourVaccination = date ,
                            Place = "Hospital El Salvador"
            };
            auxVacc.insert(vaccination);

                       
        }


    }
}
