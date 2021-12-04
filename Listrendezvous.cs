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
    public partial class Listrendezvous : MetroFramework.Forms.MetroForm
    {
        public Listrendezvous()
        {
            InitializeComponent();
        }

        private void Listrendezvous_Load(object sender, EventArgs e)
        {
            afficher();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, a].Value.ToString();
            dateTimePicker1.Text = dataGridView1[1, a].Value.ToString();
            dateTimePicker2.Text = dataGridView1[2, a].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            rendezvous c = new rendezvous();
            c.IdR = int.Parse(textBox1.Text);
            c.dateR = dateTimePicker1.Value;
            c.heureR = dateTimePicker2.Value;
            rendezvousADO.modifier(c);
            MessageBox.Show("Patient Modifié");
            afficher();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int IdR = int.Parse(textBox1.Text);
            rendezvousADO.supprimer(IdR);
            MessageBox.Show("Rendez-vous Annuler");
            afficher();
        }
        public void afficher()
        {
            List<rendezvous> pt = rendezvousADO.liste_RDV();

            dataGridView1.Rows.Clear();
            foreach (rendezvous p in pt)
            {
                dataGridView1.Rows.Add(p.IdR, p.dateR, p.heureR);
            }
        }

    }
}
