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
    public partial class FormLoading : Form
    {
        private string username;
        public FormLoading(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void timer1Welcome_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05; //Se debe de agregar la cantidad de la opacidad
            pbWelcomeBar.Value += 1;                   //Que se desea agreagar para que, vaya desapareciendo
            if (pbWelcomeBar.Value == 85)
            {
                timer1Welcome.Stop();
                timer2Welcome.Start();
            }
                
        }

        private void timer2Welcome_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2Welcome.Stop();
                this.Close();
            }
                
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            lblUserNameWelcome.Text = username;
            this.Opacity = 0.0;
            timer1Welcome.Start();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
