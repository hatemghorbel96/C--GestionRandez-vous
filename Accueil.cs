using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Accueil : MetroFramework.Forms.MetroForm
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCompte a = new ListCompte();
            a.Show();
        }

        private void ajouterUnPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoute a = new ajoute();
            a.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gererPatient a = new gererPatient();
            a.Show();
        }

        private void ajouterUnRendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouterrendez a = new Ajouterrendez();
            a.Show();
        }

        private void listeDesRendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listrendezvous a = new Listrendezvous();
            a.Show();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login a = new login();
            a.Show();
        }

        private void Accueil_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
