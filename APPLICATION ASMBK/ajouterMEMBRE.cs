using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPLICATION_ASMBK
{
    public partial class ajouterMEMBRE : Form
    {
        public ajouterMEMBRE()
        {
            InitializeComponent();
        }

        private void ajouterMEMBRE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enregistrement m1 = new enregistrement(matricule.Text, Tnom.Text, Tadresse.Text, Tcontact.Text, textSECTEUR.Text, Tsexe.Text);
            m1.inser_MEMBRE(m1);
            connexion d = new connexion();

            //d.remplirDGV("SELECT * FROM MEMBRE", table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enregistrement m1 = new enregistrement(int.Parse(Tid.Text));
            m1.SUPPRIMER(m1);
            connexion d = new connexion();
            //d.remplirDGV("select * from MEMBRE", table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enregistrement m1 = new enregistrement(int.Parse(Tid.Text), matricule.Text, Tnom.Text, Tadresse.Text, Tcontact.Text, textSECTEUR.Text, Tsexe.Text);
            m1.MODIFIER(m1);
            connexion d = new connexion();
            //d.remplirDGV("SELECT * FROM MEMBRE", table);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            MEMBRE M = new MEMBRE();
            M.Show();
            this.Hide();
           
        } 
    }
}
