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
    public partial class UTILISATEUR : Form
    {
        public UTILISATEUR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panRap.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panRap.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminUser un = new adminUser();
            un.Show();
            this.Hide();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AFFICHIER.Controls.Clear();
            AJOUTE_UTILISATEUR app = new AJOUTE_UTILISATEUR();
            this.AFFICHIER.Controls.Add(app);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
        }

        private void menu_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RAPPORT_MEMBRE menu = new RAPPORT_MEMBRE();
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RAPORT_REMBOURSER menu = new RAPORT_REMBOURSER();
            menu.Show();
        }
    }
}
