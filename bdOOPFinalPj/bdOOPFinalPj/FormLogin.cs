using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdOOPFinalPj
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            formMain = null;
            Show();
        }

        private void pnlLogin2_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
=======
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> 9573a056cab2e50b6f6fcd23838d1c70b047c6ee
        }
    }
}
