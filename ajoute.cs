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
    public partial class ajoute : MetroFramework.Forms.MetroForm
    {
        public ajoute()
        {
            InitializeComponent();
        }

        private void ajoute_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            patient c = new patient();
            c.nomP = metroTextBox1.Text;
            c.telP = metroTextBox2.Text;
            c.dateNaiss = dateTimePicker1.Value;
            c.etatP = richTextBox1.Text;
            patientADO.ajouter(c);
            
            MessageBox.Show("patient ajouter avec succée");
            this.Close();
            Accueil m = new Accueil();
            m.Show();
        }
    }
}
