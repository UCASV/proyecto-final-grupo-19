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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();

            txtPassword.PasswordChar = '*';

            int xC = 0;
            int yC = 0;

            xC = (pnlCabain.Width / 2) - (lblCabain.Width / 2);
            yC = (pnlCabain.Height / 2) - (lblCabain.Height / 2);

            lblCabain.Location = new System.Drawing.Point(xC, 10);
            cboCabain.Location = new System.Drawing.Point(xC + 9, 40);

            

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            formMain = null;
            Show();
         }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
