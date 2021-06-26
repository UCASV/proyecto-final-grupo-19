using bdOOPFinalPj.SqlServerContext;
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
        private string username;
        public FormLogin()
        {
            InitializeComponent();
            var db = new PROYECTOFContext();
            cboCabain.DataSource = db.Cabins.ToList();
            cboCabain.DisplayMember = "Id";
            cboCabain.ValueMember = "Id";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            check();
            
        }

        public async void LoadingScreen(string u)
        {
            LoadingShow(u);

            Task oTask = new Task(Wait4it);
            oTask.Start();
            await oTask;

            LoadingHide();
        }

        public void Wait4it()
        {
            Thread.Sleep(7000);
        }

        public void ShowMainForm(int c)
        {
            FormMain formMain = new FormMain(c);
            formMain.ShowDialog();
            Show();
        }
        
        public void LoadingShow(string u)
        {
            FormLoading formLoading = new FormLoading(u);
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

        private void check()
        {
            var db = new PROYECTOFContext();
            List<Manager> managers = db.Managers
                .ToList();

            username = txtUsername.Text;
            string password = txtPassword.Text;
            //obtengo la cabina desde la cual se realizo el registro, para luego poder obtener su id.
            Cabin numero = (Cabin)cboCabain.SelectedItem;
            int idcabin = numero.Id;
            List<Manager> result = managers
                .Where(m => m.Username == username && m.PasswordUser == password)
                .ToList();

            if (result.Count() > 0)
            {
                //Obtengo la hora a la cual se realiza el login 
                var time = DateTime.Now;
                //Si los datos son correctos se despliega un Messagebox dando la bienvenida al usuario
                MessageBox.Show("Bienvenido!", "HAPA COVID-19 APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addRegistration(time, idcabin);
                //Despues de mostrar el Messagebox se despliega la ventana principal 
                Hide();
                txtPassword.Text = String.Empty;
                txtUsername.Text = String.Empty;
                LoadingScreen(username);
                ShowMainForm(idcabin);
            }
            else
            {
                //Si los datos son erroneos mando unMessagebox indicando el error y limpio los textbox. 
                MessageBox.Show("Usuario o contrasena incorrecta", "Clinica UCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = null;
                txtUsername.Text = null;
            }
        }

        private void addRegistration(DateTime time, int idCabin)
        {
            var db = new PROYECTOFContext();
            //creo el nuevo registro
            var registro = new Registration
            {
                DateHour = time,
                IdCabin = idCabin
            };
            //agrego el registro a la base de datos
            db.Add(registro);
            //guardo los cambios realizados a la base de datos
            db.SaveChanges();

        }


    }
}
