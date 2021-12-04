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
    public partial class ListCompte : MetroFramework.Forms.MetroForm
    {
        public ListCompte()
        {
            InitializeComponent();
        }

        private void ListCompte_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void afficher()
        {
            List<compteM> pt = UserADO.liste_user();

            dataGridView1.Rows.Clear();
            foreach (compteM p in pt)
            {
                dataGridView1.Rows.Add(p.Id, p.nomC, p.telC, p.login, p.pass);
            }
        }
    }
}
