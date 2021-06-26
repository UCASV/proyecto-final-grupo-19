using bdOOPFinalPj.SqlServerContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bdOOPFinalPj
{
    public partial class FormDiseases : System.Windows.Forms.Form
    {
        private string DuiCitizen;
        private Repository.DiseaseRepo auxDiseas;
        public FormDiseases(string dui)
        {
            InitializeComponent();
            this.DuiCitizen = dui;
            auxDiseas = new Repository.DiseaseRepo();
        }

        private void pbCloseDisease_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveDiseases_Click(object sender, EventArgs e)
        {
            if (cbNone.Checked)
            {
                Disease di = new Disease();
                di.Diseases = "none";
                di.IdCitizen = DuiCitizen;
                auxDiseas.insert(di);
            }
            if(txtDisease1.Text != null)
            {
                Disease di = new Disease();
                di.Diseases = txtDisease1.Text;
                di.IdCitizen = DuiCitizen;
                auxDiseas.insert(di);
            }
            if(txtDisease2.Text != null)
            {
                Disease di = new Disease();
                di.Diseases = txtDisease2.Text;
                di.IdCitizen = DuiCitizen;
                auxDiseas.insert(di);
            }
            if(txtDisease3.Text != null)
            {
                Disease di = new Disease();
                di.Diseases = txtDisease3.Text;
                di.IdCitizen = DuiCitizen;
                auxDiseas.insert(di);
            }
            if(txtDiseases.Text != null)
            {
                Disease di = new Disease();
                di.Diseases = txtDiseases.Text;
                di.IdCitizen = DuiCitizen;
                auxDiseas.insert(di);
            }
            txtDisease1.Text = String.Empty;
            txtDisease2.Text = String.Empty;
            txtDisease3.Text = String.Empty;
            txtDiseases.Text = String.Empty;
            cbNone.Checked = false;
        }
    }
}
