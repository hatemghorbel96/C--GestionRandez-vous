using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entite1;
using ADO;
namespace WindowsFormsApp1
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            metroTextBox2.PasswordChar = '*';

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String login = metroTextBox1.Text;
            String password = metroTextBox2.Text;
            compteM co = UserADO.login(login, password);
            if (co == null)
            {
                MessageBox.Show("Erreur");
            }
            else
            {
                Accueil f = new Accueil();
                f.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Compte f = new Compte();
            f.Show();
        }
        private void Authentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
