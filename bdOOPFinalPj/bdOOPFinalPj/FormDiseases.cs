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
        public FormDiseases()
        {
            InitializeComponent();
        }

        private void pbCloseDisease_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
