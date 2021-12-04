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
    public partial class Compte : MetroFramework.Forms.MetroForm
    {
        public Compte()
        {
            InitializeComponent();
        }

        private void Compte_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            compteM c = new compteM();
            c.nomC = metroTextBox1.Text;
            c.telC = metroTextBox4.Text;
            c.login = metroTextBox2.Text;
            c.pass = metroTextBox3.Text;
            UserADO.Ajouter(c);
            MessageBox.Show("votre compte est creer");
        }
    }
}
