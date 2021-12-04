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
    public partial class gererPatient : MetroFramework.Forms.MetroForm
    {
        public gererPatient()
        {
            InitializeComponent();
        }

        private void gererPatient_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int IdP = int.Parse(textBox1.Text);
            patientADO.supprimer(IdP);
            MessageBox.Show("Patient Supprimé");
            afficher();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, a].Value.ToString();
            textBox2.Text = dataGridView1[1, a].Value.ToString();
            textBox3.Text = dataGridView1[2, a].Value.ToString();
            dateTimePicker1.Text = dataGridView1[3, a].Value.ToString();
            richTextBox1.Text = dataGridView1[4, a].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            patient c = new patient();
            c.IdP = int.Parse(textBox1.Text);
            c.nomP = textBox2.Text;
            c.telP = textBox3.Text;
            c.dateNaiss = dateTimePicker1.Value;
            c.etatP = richTextBox1.Text;
            patientADO.modifier(c);
            MessageBox.Show("Patient Modifié");
            afficher();
        }
        public void afficher()
        {
            List<patient> pt = patientADO.liste_patient();

            dataGridView1.Rows.Clear();
            foreach (patient p in pt)
            {
                dataGridView1.Rows.Add(p.IdP, p.nomP, p.telP, p.dateNaiss, p.etatP);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
