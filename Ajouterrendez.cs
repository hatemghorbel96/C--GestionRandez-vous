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
    public partial class Ajouterrendez : MetroFramework.Forms.MetroForm
    {
        public Ajouterrendez()
        {
            InitializeComponent();
        }

        private void Ajouterrendez_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            rendezvous c = new rendezvous();
            c.dateR = dateTimePicker1.Value;
            c.heureR = dateTimePicker2.Value;
            rendezvousADO.ajouter(c);
            MessageBox.Show("rendez vous ajouter avec succee");
            this.Close();
            Accueil m = new Accueil();
            m.Show();
        }

    }
}
