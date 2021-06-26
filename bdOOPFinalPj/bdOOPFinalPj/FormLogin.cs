using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdOOPFinalPj
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            txtPassword.Text = String.Empty;
            txtUsername.Text = String.Empty;      
            LoadingScreen();
            ShowMainForm();
        }

        public async void LoadingScreen()
        {
            LoadingShow();

            Task oTask = new Task(Wait4it);
            oTask.Start();
            await oTask;

            LoadingHide();
        }

        public void Wait4it()
        {
            Thread.Sleep(7000);
        }

        public void ShowMainForm()
        {
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
            Show();
        }
        
        public void LoadingShow()
        {
            FormLoading formLoading = new FormLoading();
            formLoading.ShowDialog();
            formLoading = null;
            Show();
        }

        public void LoadingHide()
        {
            Hide();
        }

        private void pnlLogin2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
